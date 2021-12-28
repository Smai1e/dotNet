using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
    public static class Database
    {
        private static readonly string _dbName = "dotNetRGR";
        private static readonly string _connectionString = $"Data Source=localhost;Initial Catalog={_dbName};Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True";
        private static readonly string _insertCommand =
            @"INSERT INTO [dbo].[plant]
               ([genus]
               ,[variety]
               ,[img]
               ,[decorative_qualities])
            VALUES
               (@Genus, @Variety, @Img, @DecorativeQualities)";
        private static readonly string _selectCommand =
            @"SELECT [genus]
            FROM [dbo].[plant]
            WHERE 
	            [genus] = @Genus";

        private static readonly string _truncateCommand = "TRUNCATE TABLE [dbo].[plant]";

        private static readonly string _logs = "./logs.txt";

        private static SqlConnection _sqlConnection;

        static Database()
        {
            _sqlConnection = new SqlConnection(_connectionString);
        }

        public static int AddNewPlant(Plant plant)
        {
            if (!string.IsNullOrWhiteSpace(SelectPlant(plant)))
            {
                return -1;
            }
            return InsertPlant(plant);
        }

        public static void TruncateTable()
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = _sqlConnection;
                    command.CommandText = _truncateCommand;
                    command.CommandType = CommandType.Text;

                    _sqlConnection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception exception)
                {
                    File.AppendAllText(_logs, $"{DateTime.Now} {exception.Message}\r\n{exception.StackTrace}\r\n\r\n");
                }
                finally
                {
                    if (_sqlConnection != null && _sqlConnection.State == ConnectionState.Open)
                        _sqlConnection.Close();
                }
            }
        }

        private static int InsertPlant(Plant plant)
        {
            int result = 0;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = _sqlConnection;
                    command.CommandText = _insertCommand;
                    command.CommandType = CommandType.Text;

                    command.Parameters.Add("@Genus", SqlDbType.VarChar, 32).Value = plant._genus;
                    command.Parameters.Add("@Variety", SqlDbType.VarChar, 32).Value = plant._variety;
                    command.Parameters.Add("@Img", SqlDbType.Image).Value = plant._img != null ? plant._img : Convert.DBNull;
                    command.Parameters.Add("@DecorativeQualities", SqlDbType.VarChar, 256).Value = plant._decorative_qualities;

                    _sqlConnection.Open();
                    result = command.ExecuteNonQuery();
                }
                catch (Exception exception)
                {
                    File.AppendAllText(_logs, $"{DateTime.Now} {exception.Message}\r\n{exception.StackTrace}\r\n\r\n");
                }
                finally
                {
                    if (_sqlConnection != null && _sqlConnection.State == ConnectionState.Open)
                        _sqlConnection.Close();
                }
            }
            return result;
        }

        private static string SelectPlant(Plant plant)
        {
            string result = string.Empty;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = _sqlConnection;
                    command.CommandText = _selectCommand;
                    command.CommandType = CommandType.Text;

                    command.Parameters.Add("@Genus", SqlDbType.VarChar, 32).Value = plant._genus;

                    _sqlConnection.Open();
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        result = reader["genus"] as string;
                    }
                }
                catch (Exception)
                {
                    result = SelectPlant(plant);
                }
                finally
                {
                    if (_sqlConnection != null && _sqlConnection.State == ConnectionState.Open)
                        _sqlConnection.Close();
                }
            }
            return result;
        }
    }
}
