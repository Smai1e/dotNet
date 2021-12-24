using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr11.Models
{
    public class MusicalInstrumentType
    {
        private static readonly string _selectMusicalInstrumentTypeCommand = @"SELECT [typeId], [title], [description] FROM [dbo].[Musical_Instrument_Type]";
        private static readonly string _insertMusicalInstrumentTypeCommand = @"INSERT INTO [dbo].[Musical_Instrument_Type] ([title], [description]) VALUES (@title, @description)";
        private static readonly string _updateMusicalInstrumentTypeCommand = @"UPDATE [dbo].[Musical_Instrument_Type] SET [title] = @title, [description] = @description WHERE [id] = @id";
        private static readonly string _deleteMusicalInstrumentTypeCommand = @"DELETE FROM [dbo].[Musical_Instrument_Type] WHERE [id] = @id";

        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }

        public static List<MusicalInstrumentType> List(SqlConnection connection)
        {
            List<MusicalInstrumentType> types = new List<MusicalInstrumentType>();
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _selectMusicalInstrumentTypeCommand;
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        MusicalInstrumentType type = new MusicalInstrumentType
                        {
                            id = (int)reader["typeId"],
                            title = (string)reader["title"],
                            description = (string)reader["description"],
                        };
                        types.Add(type);
                    }
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
            return types;
        }

        public static void Insert(SqlConnection connection, MusicalInstrumentType type)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _insertMusicalInstrumentTypeCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@title", SqlDbType.NVarChar, 256).Value = type.title;
                    command.Parameters.Add("@description", SqlDbType.NVarChar, 1024).Value = type.description;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }

        public static void Update(SqlConnection connection, MusicalInstrumentType type)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _updateMusicalInstrumentTypeCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@title", SqlDbType.NVarChar, 256).Value = type.title;
                    command.Parameters.Add("@description", SqlDbType.NVarChar, 256).Value = type.description;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = type.id;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }

        public static void Delete(SqlConnection connection, int typeId)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _deleteMusicalInstrumentTypeCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = typeId;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }
    }
}
