using Biuro_Podrozy.forms;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Biuro_Podrozy
{
    public partial class formClientVersion : Form
    {
        public formClientVersion()
        {
            InitializeComponent();
        }

        Connection_Class db = new Connection_Class();

        private void formClientVersion_Load(object sender, EventArgs e)
        {
            SqlConnection connection = db.GetConnection();
            PictureBox[] pictureBoxes = { picBoxTrip1, picBoxTrip2, picBoxTrip3 };
            Button[] btn = { btnDetailsTrip1, btnDetailsTrip2, btnDetailsTrip3 };

            try
            {
                connection.Open();

                for (int i = 0; i < pictureBoxes.Length; i++)
                {
                    string query = $"SELECT zdjecie FROM Wycieczka WHERE id = {i + 1}";
                    Image result = db.ReturnImage(query, connection);

                    if (result != null)
                    {
                        pictureBoxes[i].Image = result;
                    }
                    else
                    {
                        pictureBoxes[i].Image = null;
                    }
                }
                for (int i = 0; i < btn.Length; i++)
                {
                    string query1 = $"SELECT czyAktualne FROM Wycieczka WHERE id = {i + 1}";
                    bool result1 = db.ReturnQueryBoolValue(query1, connection);

                    if (result1 != true)
                    {
                        btn[i].Enabled = false;
                        btn[i].Text = "Niedostępne";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnDetailsTrip1_Click(object sender, EventArgs e)
        {
            formTripDetails fTripDetails = new formTripDetails(1);
            this.Hide();
            fTripDetails.Show();

        }

        private void btnDetailsTrip2_Click(object sender, EventArgs e)
        {
            formTripDetails fTripDetails = new formTripDetails(2);
            this.Hide();
            fTripDetails.Show();
        }

        private void btnDetailsTrip3_Click(object sender, EventArgs e)
        {
            formTripDetails fTripDetails = new formTripDetails(3);
            this.Hide();
            fTripDetails.Show();
        }

        private void formClientVersion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnGoToEmployeeVersion_Click(object sender, EventArgs e)
        {
            formLogin fLogin = new formLogin();
            this.Hide();
            fLogin.Show();
        }
    }
}
