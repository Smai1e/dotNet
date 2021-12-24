using lr10Plants;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr10PlantsClient
{
    public partial class FormMain : Form
    {
        private byte[] bytes = new byte[10240];
        private IPHostEntry ipHost;
        private IPAddress ipAddr;
        private IPEndPoint ipEndPoint;
        private Socket socket;
        private PlantRequest request;
        private PlantResponse response;

        public FormMain()
        {
            InitializeComponent();

            ipHost = Dns.GetHostEntry("localhost");
            ipAddr = ipHost.AddressList[0];
            ipEndPoint = new IPEndPoint(ipAddr, 11000);

            socket = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                socket.Connect(ipEndPoint);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нет соединения с сервером!");
            }
        }

        private void getToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGetDeletePlant form = new FormGetDeletePlant("Получить информацию о растении", "Получить");

            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    request = new PlantRequest
                    {
                        Key = form.Key,
                        Type = PlantRequestType.Get
                    };

                    string jsonRequest = JsonConvert.SerializeObject(request);
                    byte[] msg = Encoding.UTF8.GetBytes(jsonRequest);

                    socket.Send(msg);

                    int bytesRec = socket.Receive(bytes);

                    response = JsonConvert.DeserializeObject<PlantResponse>(Encoding.UTF8.GetString(bytes, 0, bytesRec));

                    if (!response.IsSuccess)
                        throw new Exception(response.ErrorMessage);

                    MessageBox.Show("Полученное растение:\n\n" + response.Plant.ToString(), "Удачно");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManipPlant form = new FormManipPlant("Добавить растение", "Добавить");
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (!form.Plant.isValid())
                        throw new Exception("Неправильно заполнена информация о растении!");

                    request = new PlantRequest
                    {
                        Key = form.Plant.Title,
                        Type = PlantRequestType.Add,
                        Plant = form.Plant
                    };

                    string jsonRequest = JsonConvert.SerializeObject(request);
                    byte[] msg = Encoding.UTF8.GetBytes(jsonRequest);

                    socket.Send(msg);

                    int bytesRec = socket.Receive(bytes);

                    response = JsonConvert.DeserializeObject<PlantResponse>(Encoding.UTF8.GetString(bytes, 0, bytesRec));

                    if (!response.IsSuccess)
                        throw new Exception(response.ErrorMessage);

                    MessageBox.Show("Растение успешно добавлено", "Удачно");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGetDeletePlant form = new FormGetDeletePlant("Удалить информацию о растении", "Удалить");

            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    request = new PlantRequest
                    {
                        Key = form.Key,
                        Type = PlantRequestType.Remove
                    };

                    string jsonRequest = JsonConvert.SerializeObject(request);
                    byte[] msg = Encoding.UTF8.GetBytes(jsonRequest);

                    socket.Send(msg);

                    int bytesRec = socket.Receive(bytes);

                    response = JsonConvert.DeserializeObject<PlantResponse>(Encoding.UTF8.GetString(bytes, 0, bytesRec));

                    if (!response.IsSuccess)
                        throw new Exception(response.ErrorMessage);

                    MessageBox.Show("Информация о растении успешно удалена", "Удачно");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManipPlant form = new FormManipPlant("Изменить растение", "Заменить");
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (!form.Plant.isValid())
                        throw new Exception("Неправильно заполнена информация о растении!");

                    request = new PlantRequest
                    {
                        Key = form.Plant.Title,
                        Type = PlantRequestType.Update,
                        Plant = form.Plant
                    };

                    string jsonRequest = JsonConvert.SerializeObject(request);
                    byte[] msg = Encoding.UTF8.GetBytes(jsonRequest);

                    socket.Send(msg);

                    int bytesRec = socket.Receive(bytes);

                    response = JsonConvert.DeserializeObject<PlantResponse>(Encoding.UTF8.GetString(bytes, 0, bytesRec));

                    if (!response.IsSuccess)
                        throw new Exception(response.ErrorMessage);

                    MessageBox.Show("Информация о растении успешно обновлена", "Удачно");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }
        }
    }
}
