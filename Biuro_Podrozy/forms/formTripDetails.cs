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
    public partial class formTripDetails : Form
    {
        private int tripNumber;
        public formTripDetails(int i)
        {
            InitializeComponent();
            tripNumber = i;
        }

        Connection_Class db = new Connection_Class();
        decimal cena_za_osobe = 0.00M;

        private void formTripDetails_Load(object sender, EventArgs e)
        {
            string data_wyjazdu = "", data_przyjazdu = "", standard_pokoju = "";
            bool posilek = false, wifi = false, klimatyzacja = false, atrakcje_dla_dzieci = false;
            

            lblTrip.Text = "Wycieczka " + tripNumber.ToString();

            SqlConnection connection = db.GetConnection();
            try
            {
                connection.Open();

                string query1 = $"SELECT * FROM Wycieczka WHERE id = {tripNumber}";
                DataTable result = db.ReturnQueryValues(query1, connection);
                if (result != null)
                {
                    for (int i = 1; i < result.Columns.Count; i++)
                    {
                        switch (i - 2)
                        {
                            case 0:
                                break;
                            case 1:
                                data_wyjazdu = Truncate(result.Rows[0][2].ToString(), 10);
                                break;
                            case 2:
                                data_przyjazdu = Truncate(result.Rows[0][3].ToString(), 10);
                                break;
                            case 3:
                                standard_pokoju = result.Rows[0][4].ToString();
                                break;
                            case 4:
                                if (result.Rows[0][5].ToString() == "True")
                                {
                                    posilek = true;
                                }
                                else
                                {
                                    posilek = false;
                                }
                                break;
                            case 5:
                                if (result.Rows[0][6].ToString() == "True")
                                {
                                    wifi = true;
                                }
                                else
                                {
                                    wifi = false;
                                }
                                break;
                            case 6:
                                if (result.Rows[0][7].ToString() == "True")
                                {
                                    klimatyzacja = true;
                                }
                                else
                                {
                                    klimatyzacja = false;
                                }
                                break;
                            case 7:
                                if (result.Rows[0][8].ToString() == "True")
                                {
                                    atrakcje_dla_dzieci = true;
                                }
                                else
                                {
                                    atrakcje_dla_dzieci = true;
                                }
                                break;
                            case 8:
                                cena_za_osobe = Convert.ToDecimal(result.Rows[0][9].ToString());
                                break;
                        }
                    }
                }
                string query = $"SELECT zdjecie FROM Wycieczka WHERE id = {tripNumber}";
                pictureBox1.Image = db.ReturnImage(query, connection);

                if (pictureBox1.Image == null)
                {
                    pictureBox1.Image = pictureBox1.ErrorImage;
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

            txtBoxDateOfStart.Text = data_wyjazdu;
            txtBoxDateOfEnd.Text = data_przyjazdu;
            txtBoxKindOfRoom.Text = standard_pokoju;
            if (posilek == false)
            {
                txtBoxMealIncluded.Text = "nie";
            }
            else
            {
                txtBoxMealIncluded.Text = "tak";
            }
            if (wifi)
            {
                txtBoxAdditionalInfo.Text += "WiFi: tak; ";
            }
            if (klimatyzacja)
            {
                txtBoxAdditionalInfo.Text += "Klimatyzacja: tak; ";
            }
            if (atrakcje_dla_dzieci)
            {
                txtBoxAdditionalInfo.Text += "Atrakcje dla dzieci: tak; ";
            }
            lblPricePerPerson.Text = "Cena za osobę: " + cena_za_osobe.ToString() + " PLN";
        }

        private void formTripDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            formClientVersion fClientVersion = new formClientVersion();
            this.Hide();
            fClientVersion.Show();
        }

        public string Truncate(string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }

        private void btnBookTrip_Click(object sender, EventArgs e)
        {
            formBookTrip fBookTrip = new formBookTrip(tripNumber, cena_za_osobe);
            this.Hide();
            fBookTrip.Show();
        }
    }
}
