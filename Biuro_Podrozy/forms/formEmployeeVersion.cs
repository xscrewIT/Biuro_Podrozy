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
    public partial class formEmployeeVersion : Form
    {

        private string imie;

        public formEmployeeVersion(string result1)
        {
            InitializeComponent();
            this.imie = result1;
        }

        Connection_Class db = new Connection_Class();

        private void formEmployeeVersion_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Witaj, " + imie;

            SqlConnection connection = db.GetConnection();
            PictureBox[] pictureBoxes = { picBoxTrip1, picBoxTrip2, picBoxTrip3 };

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

        private void formEmployeeVersion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //nie wracamy do trybu klienta
        }

        private void btnGoToClientVersion_Click(object sender, EventArgs e)
        {
            formClientVersion fClientVersion = new formClientVersion();
            this.Hide();
            fClientVersion.Show();
        }

        private void btnEditTrip1_Click(object sender, EventArgs e)
        {
            formEditTripDetails fEditTripDetails = new formEditTripDetails(1, imie);
            this.Hide();
            fEditTripDetails.Show();
        }

        private void btnEditTrip2_Click(object sender, EventArgs e)
        {
            formEditTripDetails fEditTripDetails = new formEditTripDetails(2, imie);
            this.Hide();
            fEditTripDetails.Show();
        }

        private void btnEditTrip3_Click(object sender, EventArgs e)
        {
            formEditTripDetails fEditTripDetails = new formEditTripDetails(3, imie);
            this.Hide();
            fEditTripDetails.Show();
        }
    }
}
