using Microsoft.Data.SqlClient;

namespace Ejercicio2
{
    internal class Program
    {
        
        
            async static Task Main(string[] args)
            {

            string string_conection = "Data Source=santi1maquina;Initial Catalog=Guia6_1_Ejercicio1_Ansa_db;Integrated Security=True;Pooling=False;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Name=vscode-mssql;Connect Retry Count=1;Connect Retry Interval=10;Command Timeout=30";


                string query = "SELECT f.Id , f.Tipo FROM Figuras f";

                using SqlConnection conn = new SqlConnection(string_conection);

                SqlCommand sqlc = new SqlCommand(query, conn);
                await conn.OpenAsync();

                var reader = await sqlc.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {

                    int id = Convert.ToInt32(reader["Id"]);
                    int tipo = Convert.ToInt32(reader["Tipo"]);

                    //double? Area = reader["Area"] != DBNull.Value ? Convert.ToDouble(reader["Area"]) : null;
                    //double? Ancho = reader["Ancho"] != DBNull.Value ? Convert.ToDouble(reader["Ancho"]) : null;
                    //double? Largo = reader["Largo"] != DBNull.Value ? Convert.ToDouble(reader["Largo"]) : null;
                    //double? Radio = reader["Radio"] != DBNull.Value ? Convert.ToDouble(reader["Radio"]) : null;

                    Console.WriteLine($"{id} {tipo}");
                }
            }
        }
    }

    

