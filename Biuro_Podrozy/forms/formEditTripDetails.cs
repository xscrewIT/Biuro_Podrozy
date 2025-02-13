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
using static System.Net.Mime.MediaTypeNames;

namespace Biuro_Podrozy.forms
{
    public partial class formEditTripDetails : Form
    {

        private int tripNumber;
        private string imie;

        public formEditTripDetails(int i, string imie)
        {
            InitializeComponent();
            this.tripNumber = i;
            this.imie = imie;
        }

        Connection_Class db = new Connection_Class();

        private void formEditTripDetails_Load(object sender, EventArgs e)
        {
            lblTrip.Text = "Wycieczka " + tripNumber.ToString();

            System.Drawing.Image imgTrip;
            string data_wyjazdu = "", data_przyjazdu = "", standard_pokoju = "";
            bool posilek = false, wifi = false, klimatyzacja = false, atrakcje_dla_dzieci = false, czyAktualne = false;
            decimal cena_za_osobe = 0.00M;

            SqlConnection connection = db.GetConnection();
            try
            {
                connection.Open();

                string query1 = $"SELECT * FROM Wycieczka WHERE id = {tripNumber}";
                DataTable result = db.ReturnQueryValues(query1, connection);
                if (result != null)
                {
                    for (int i = 1; i <= result.Columns.Count; i++)
                    {
                        switch (i - 2)
                        {
                            case 0:
                                break;
                            case 1:
                                data_wyjazdu = result.Rows[0][2].ToString();
                                break;
                            case 2:
                                data_przyjazdu = result.Rows[0][3].ToString();
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
                            case 9:
                                if (result.Rows[0][10].ToString() == "True")
                                {
                                    czyAktualne = true;
                                }
                                else
                                {
                                    czyAktualne = false;
                                }
                                break;
                        }
                    }
                }
                string query = $"SELECT zdjecie FROM Wycieczka WHERE id = {tripNumber}";
                imgTrip = db.ReturnImage(query, connection);

                if (imgTrip == null)
                {
                    pictureBox1.Image = pictureBox1.ErrorImage;
                }
                else
                {
                    pictureBox1.Image = imgTrip;
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

            dateTimePickerDateOfStart.Text = data_wyjazdu;
            dateTimePickerDateOfEnd.Text = data_przyjazdu;
            comboKindOfRoom.Text = standard_pokoju;
            if (posilek)
            {
                checkBoxMealIncluded.Checked = true;
            }
            if (wifi)
            {
                checkBoxWiFi.Checked = true;
            }
            if (klimatyzacja)
            {
                checkBoxAC.Checked = true;
            }
            if (atrakcje_dla_dzieci)
            {
                checkBoxKidsEntertainment.Checked = true;
            }
            txtBoxPricePerPerson.Text = cena_za_osobe.ToString();
            if (czyAktualne)
            {
                checkBoxIsAvailable.Checked = true;
            }
        }

        private void formEditTripDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            formEmployeeVersion fEmployeeVersion = new formEmployeeVersion(imie);
            this.Hide();
            fEmployeeVersion.Show();
        }

        private void btnBookTrip_Click(object sender, EventArgs e)
        {
            SqlConnection connection = db.GetConnection();

            string data_wyjazdu = "", data_przyjazdu = "", standard_pokoju = "";
            bool posilek = false, wifi = false, klimatyzacja = false, atrakcje_dla_dzieci = false, czyAktualne = false;
            decimal cena_za_osobe = 0.00M;

            data_wyjazdu = dateTimePickerDateOfStart.Value.ToString("yyyy-MM-dd");
            data_przyjazdu = dateTimePickerDateOfEnd.Value.ToString("yyyy-MM-dd");
            standard_pokoju = comboKindOfRoom.Text;
            if (checkBoxMealIncluded.Checked)
            {
                posilek = true;
            }
            if (checkBoxWiFi.Checked)
            {
                wifi = true;
            }
            if (checkBoxAC.Checked)
            {
                klimatyzacja = true;
            }
            if (checkBoxKidsEntertainment.Checked)
            {
                atrakcje_dla_dzieci = true;
            }
            if (checkBoxIsAvailable.Checked)
            {
                czyAktualne = true;
            }
            cena_za_osobe = Convert.ToDecimal(txtBoxPricePerPerson.Text);

            try
            {
                connection.Open();

                string query = $"UPDATE Wycieczka SET data_wyjazdu = '{data_wyjazdu}', data_przyjazdu = '{data_przyjazdu}', standard_pokoju = '{standard_pokoju}', posilek = {boolToBit(posilek)}, wifi = {boolToBit(wifi)}, klimatyzacja = {boolToBit(klimatyzacja)}, " +
                    $"atrakcje_dla_dzieci = {boolToBit(atrakcje_dla_dzieci)}, cena_za_osobe = {cena_za_osobe}, czyAktualne = {boolToBit(czyAktualne)} WHERE id = {tripNumber};";

                if (pictureBox1.Image != pictureBox1.ErrorImage)
                {
                    SqlCommand insertCommand = new SqlCommand($"UPDATE Wycieczka SET zdjecie = @Pic WHERE id = {tripNumber}", connection);
                    insertCommand.Parameters.Add("Pic", SqlDbType.Image, 0).Value = ConvertImageToByteArray(pictureBox1.Image, System.Drawing.Imaging.ImageFormat.Jpeg);
                    int queryResult = insertCommand.ExecuteNonQuery();
                    if (queryResult == 1)
                        MessageBox.Show("Zapisano zdjęcie");
                }

                db.ExecuteQuery(connection, query);

                MessageBox.Show("Zapisano dane!");
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

        private byte[] ConvertImageToByteArray(System.Drawing.Image imageToConvert, System.Drawing.Imaging.ImageFormat formatOfImage)
        {
            byte[] Ret;
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    imageToConvert.Save(ms, formatOfImage);
                    Ret = ms.ToArray();
                }
            }
            catch (Exception) { throw; }
            return Ret;
        }

        private int boolToBit(bool param)
        {
            if (param)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        private void btnChangePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.png) | *.jpg; *.png";
            dialog.ShowDialog();
            System.Drawing.Image newImage = System.Drawing.Image.FromFile(dialog.FileName);
            pictureBox1.Image = newImage;
        }

        private void txtBoxPricePerPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
