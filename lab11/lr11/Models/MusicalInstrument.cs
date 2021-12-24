using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr11.Models
{
    public class MusicalInstrument
    {
        private static readonly string _selectMusicalInstrumentCommand = @"SELECT p.[id], p.[names], p.[typeId], c.[title] as typeName, p.[brand] FROM [dbo].[Musical_Instrument] p inner join dbo.Musical_Instrument_Type c on c.typeId = p.typeId";
        private static readonly string _insertMusicalInstrumentCommand = @"INSERT INTO [dbo].[Musical_Instrument] ([names], [typeId], [brand]) VALUES (@names, @typeId, @brand)";
        private static readonly string _updateMusicalInstrumentCommand = @"UPDATE [dbo].[Musical_Instrument] SET [names] = @names, [typeId] = @typeId, [brand] = @brand WHERE [id] = @id";
        private static readonly string _deleteMusicalInstrumentCommand = @"DELETE FROM [dbo].[Musical_Instrument] WHERE [id] = @id";

        public int id { get; set; }
        public string names { get; set; }
        public int typeId { get; set; }
        public string typeName { get; set; }
        public string brand { get; set; }
        public byte[] Photo { get; set; }


        public static List<MusicalInstrument> List(SqlConnection connection)
        {
            List<MusicalInstrument> musicalInstruments = new List<MusicalInstrument>();
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _selectMusicalInstrumentCommand;
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        MusicalInstrument MusicalInstrument = new MusicalInstrument
                        {
                            id = (int)reader["id"],
                            typeId = (int)reader["typeId"],
                            typeName = (string)reader["typeName"],
                            names = (string)reader["names"],
                            brand = (string)reader["brand"]
                        };
                        musicalInstruments.Add(MusicalInstrument);
                    }
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
            return musicalInstruments;
        }

        public static void Insert(SqlConnection connection, MusicalInstrument MusicalInstrument)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _insertMusicalInstrumentCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@names", SqlDbType.NVarChar, 256).Value = MusicalInstrument.names;
                    command.Parameters.Add("@typeId", SqlDbType.Int).Value = MusicalInstrument.typeId;
                    command.Parameters.Add("@brand", SqlDbType.NVarChar, 256).Value = MusicalInstrument.brand;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }

        public static void Update(SqlConnection connection, MusicalInstrument MusicalInstrument)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _updateMusicalInstrumentCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@names", SqlDbType.NVarChar, 256).Value = MusicalInstrument.names;
                    command.Parameters.Add("@typeId", SqlDbType.Int).Value = MusicalInstrument.typeId;
                    command.Parameters.Add("@brand", SqlDbType.NVarChar, 256).Value = MusicalInstrument.brand;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = MusicalInstrument.id;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }

        public static void Delete(SqlConnection connection, int MusicalInstrumentId)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _deleteMusicalInstrumentCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = MusicalInstrumentId;
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

