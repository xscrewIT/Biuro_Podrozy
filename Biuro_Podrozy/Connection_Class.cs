using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Biuro_Podrozy
{
    public class Connection_Class
    {
        private readonly string connectionString = "Server=IP;Database=Biuro_podrozy;User Id=user_name;Password=password; TrustServerCertificate=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public void OpenConnection(SqlConnection connection)
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas nawiązywania połączenia: {ex.Message}");
            }
            
        }

        public void CloseConnection(SqlConnection connection)
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas zamykania połączenia: {ex.Message}");
            }
            
        }

        public void ExecuteQuery(SqlConnection connection, string query)
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Błąd: Połączenie nie jest otwarte.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas wykonywania zapytania SQL: {ex.Message}");
            }
        }

        public bool ReturnQueryBoolValue(string query, SqlConnection connection)
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    bool result = (bool)cmd.ExecuteScalar(); //rzutowanie
                    return result;
                }
                else
                {
                    MessageBox.Show("Błąd: Połączenie nie jest otwarte.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas wykonywania zapytania SQL: {ex.Message}");
            }
            return false;
        }

        public string ReturnQueryValue(string query, SqlConnection connection)
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    string? result = (string)cmd.ExecuteScalar();
                    return result;
                }
                else
                {
                    MessageBox.Show("Błąd: Połączenie nie jest otwarte.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas wykonywania zapytania SQL: {ex.Message}");
            }
            return "0";
        }

        public DataTable ReturnQueryValues(string query, SqlConnection connection)
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    List<string> result = new List<string>();
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    return dt;
                }
                else
                {
                    MessageBox.Show("Błąd: Połączenie nie jest otwarte.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas wykonywania zapytania SQL: {ex.Message}");
            }
            return null;
        }

        public Image ReturnImage(string query, SqlConnection connection)
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                byte[] img_arr1 = (byte[])reader["zdjecie"];
                                Stream str = new MemoryStream(img_arr1);
                                return Image.FromStream(str);
                            }
                            
                        }
                        reader.Close();
                    }
                    cmd.Cancel();
                }
                else
                {
                    MessageBox.Show("Błąd: Połączenie nie jest otwarte.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas wykonywania zapytania SQL: {ex.Message}");
            }
            return null;
        }
    }
}
