using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Introduzione
{
    public static class DAL
    {
        public static void insertUser(Persona p)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["MainDB"].ConnectionString;
            string query = "insert into [dbo].[Persone] values (newid(),@username, @password, @nome, @cognome, @eta, getdate())";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", p.Username);
                    command.Parameters.AddWithValue("@Password", p.Password);

                    if (string.IsNullOrEmpty(p.Nome))
                        command.Parameters.AddWithValue("@Nome", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@Nome", p.Nome);

                    if (string.IsNullOrEmpty(p.Cognome))
                        command.Parameters.AddWithValue("@Cognome", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@Cognome", p.Cognome);

                    if (string.IsNullOrEmpty(p.Eta))
                        command.Parameters.AddWithValue("@Eta", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@Eta", p.Eta);

                    connection.Open();
                    command.ExecuteReader();

                }
                catch (Exception ex)
                {

                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public static List<Persona> getPersone()
        {
            List<Persona> persone = new List<Persona>();

            string connectionString = WebConfigurationManager.ConnectionStrings["MainDB"].ConnectionString;
            string query = "SELECT [ID],[Nome],[Cognome],[Eta] FROM [dbo].[Persone]";  

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    DataTable dt = new DataTable();

                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        da.Fill(dt);
                    }

                    foreach (DataRow row in dt.Rows)
                    {
                        Persona p = new Persona();
                        p.ID = Guid.Parse(row["ID"].ToString());
                        p.Nome = row["Nome"].ToString();
                        p.Cognome = row["Cognome"].ToString();
                        p.Eta = row["Eta"].ToString();
                        persone.Add(p);
                    }

                }
                catch (Exception ex)
                {

                }
                finally
                {
                    connection.Close();
                }
            }
            return persone;
        }
    }
}