using System;
using System.Collections.Concurrent;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using lr10Plants;
using Newtonsoft.Json;

namespace lr10PlantsServer
{
    class Program
    {
        private static string fileName = "db.json";
        private static ConcurrentDictionary<string, Plant> _plants = new ConcurrentDictionary<string, Plant>();

        static void save_th()
        {
            while (true)
            {
                Thread.Sleep(10000);

                try
                {
                    using (StreamWriter jsonStreamWriter = File.CreateText(fileName))
                    {
                        JsonSerializer jsonSerializer = new JsonSerializer { Formatting = Formatting.Indented };
                        jsonSerializer.Serialize(jsonStreamWriter, _plants);
                    }
                    Console.WriteLine("Данные сохранены");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Не удалось сохранить данные!");
                }
            }
        }

        static void Main(string[] args)
        {
            // Устанавливаем для сокета локальную конечную точку
            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 11000);

            // Создаем сокет Tcp/Ip
            Socket sListener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            //Подтягиваем данные с диска
            try
            {
                StreamReader jsonStreamReader = File.OpenText(fileName);
                JsonSerializer jsonSerializer = new JsonSerializer();
                _plants = (ConcurrentDictionary<string, Plant>)jsonSerializer.Deserialize(jsonStreamReader, typeof(ConcurrentDictionary<string, Plant>));
                jsonStreamReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Нет сохраненных данных на диске");
            }

            // Назначаем сокет локальной конечной точке и слушаем входящие сокеты
            try
            {
                sListener.Bind(ipEndPoint);
                sListener.Listen(10);

                //запускаем сохранения раз в 10сек
                Thread th = new Thread(save_th);
                th.Start();

                // Начинаем слушать соединения
                while (true)
                {
                    Console.WriteLine("Ожидаем соединение через порт {0}", ipEndPoint);
                    // Программа приостанавливается, ожидая входящее соединение
                    Socket socket = sListener.Accept();
                    Task taskSocket = new Task(Action, socket);
                    taskSocket.Start();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }
            finally
            {
                Console.ReadLine();
            }
        }

        private static void Action(object o)
        {
            Socket socket = o as Socket;
            if (socket != null)
            {
                while (true)
                {
                    try
                    {
                        // Мы дождались клиента, пытающегося с нами соединиться
                        byte[] bytes = new byte[10240];
                        int bytesRec = socket.Receive(bytes);
                        string json = Encoding.UTF8.GetString(bytes, 0, bytesRec);
                        PlantResponse response = new PlantResponse { IsSuccess = false };
                        try
                        {
                            var request = JsonConvert.DeserializeObject<PlantRequest>(json);
                            if (request != null)
                            {
                                response.Key = request.Key;
                                Plant plant;
                                switch (request.Type)
                                {
                                    case PlantRequestType.Get:
                                        if (_plants.TryGetValue(request.Key, out plant))
                                        {
                                            response.Plant = plant;
                                            response.IsSuccess = true;
                                        }
                                        else
                                        {
                                            response.ErrorMessage = "Растение не найдено";
                                        }
                                        break;
                                    case PlantRequestType.Add:
                                        if (_plants.ContainsKey(request.Key))
                                        {
                                            response.ErrorMessage = "Растение с таким ключем уже существует";
                                        }
                                        else
                                        {
                                            _plants.AddOrUpdate(request.Key, request.Plant, (s, Bank1) => request.Plant);
                                            response.IsSuccess = true;
                                        }
                                        break;
                                    case PlantRequestType.Update:
                                        if (_plants.ContainsKey(request.Key))
                                        {
                                            _plants.AddOrUpdate(request.Key, request.Plant, (s, Bank1) => request.Plant);
                                            response.IsSuccess = true;
                                        }
                                        else
                                        {
                                            response.ErrorMessage = "Растение с таким ключем не существует";
                                        }
                                        break;
                                    case PlantRequestType.Remove:
                                        if (_plants.ContainsKey(request.Key))
                                        {
                                            if (_plants.TryRemove(request.Key, out plant))
                                            {
                                                response.IsSuccess = true;
                                            }
                                            else
                                            {
                                                response.ErrorMessage = "Не удалось удалить растение";
                                            }
                                        }
                                        else
                                        {
                                            response.ErrorMessage = "Растение с таким ключем не существует";
                                        }
                                        break;
                                    default:
                                        throw new ArgumentOutOfRangeException();
                                }
                            }
                        }
                        catch (Exception exception)
                        {
                            response.ErrorMessage = exception.Message;
                        }
                        // Показываем данные на консоли
                        Console.WriteLine("Полученный json: " + json);
                        // Отправляем ответ клиенту\
                        var jsonResponse = JsonConvert.SerializeObject(response);
                        byte[] msg = Encoding.UTF8.GetBytes(jsonResponse);
                        Console.WriteLine("Отправленный json: " + jsonResponse);
                        socket.Send(msg);
                    }
                    catch (Exception)
                    {
                        break;
                    }
                }
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
        }
    }
}
