using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biuro_Podrozy.forms
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        Connection_Class db = new Connection_Class();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = db.GetConnection();
            string login = txtBoxLogin.Text;
            string password = txtBoxPassword.Text;

            try
            {
                connection.Open();
                string query = $"SELECT haslo FROM Pracownik WHERE login = '{login}'";
                string query1 = $"SELECT imie FROM Pracownik WHERE login = '{login}'";
                string result = db.ReturnQueryValue(query, connection);
                string result1 = db.ReturnQueryValue(query1, connection);

                if (result == password)
                {
                    MessageBox.Show("Logowanie poprawne");
                    formEmployeeVersion fEmployeeVersion = new formEmployeeVersion(result1);
                    this.Hide();
                    fEmployeeVersion.Show();
                }
                else
                {
                    MessageBox.Show("Niepoprawne dane logowania, spróbuj ponownie");
                    txtBoxLogin.Text = string.Empty;
                    txtBoxPassword.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void formLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            formClientVersion fClientVersion = new formClientVersion();
            this.Hide();
            fClientVersion.Show();
        }
    }
}
