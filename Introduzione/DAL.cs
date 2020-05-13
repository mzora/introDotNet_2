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
        static string connectionString = WebConfigurationManager.ConnectionStrings["MainDB"].ConnectionString;

        public static void insertUser(Persona p)
        {
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
            string query = "SELECT [ID],[Nome],[Cognome],[Eta],[CreationDate] FROM [dbo].[Persone] ORDER BY [CreationDate]";  
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
                        p.CreationDate = (DateTime)row["CreationDate"];
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

        public static bool validLogin(string usr, string psw)
        {
            string query = @"SELECT Username, Password FROM dbo.LoginUsers WHERE Username=@username AND Password=@password";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", usr);
                    command.Parameters.AddWithValue("@Password", psw);
                    connection.Open();
                    DataTable dt = new DataTable();

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        da.Fill(dt);
                    }

                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["Username"].ToString() == usr && row["Password"].ToString()== psw)
                        {
                            return true;
                        }
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    connection.Close();
                }
                return false;
            }
        }
    }
}