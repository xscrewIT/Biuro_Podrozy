using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlClient.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biuro_Podrozy.forms
{
    public partial class formBookTrip : Form
    {
        private int tripNumber;
        private decimal cena_za_osobe;
        public formBookTrip(int number, decimal price)
        {
            InitializeComponent();
            this.tripNumber = number;
            this.cena_za_osobe = price;
        }

        Connection_Class db = new Connection_Class();

        private void formBookTrip_Load(object sender, EventArgs e)
        {
            lblTrip.Text = "Wycieczka " + tripNumber;
        }

        private void btnConfirmBook_Click(object sender, EventArgs e)
        {
            string imie = "", nazwisko = "", email = "";
            int nr_telefonu = 0;
            decimal dorosli = 0, dzieci = 0, liczba_osob = 0, calkowita_kwota = 0;
            bool validImie = false, validNazwisko = false, validNumer = false, validEmail = false, validPeopleNumber = false;

            if (txtBoxFirstName.Text.Length < 50 && txtBoxFirstName.Text.Length > 2)
            {
                imie = txtBoxFirstName.Text;
                validImie = true;
            }
            else
            {
                MessageBox.Show("Niepoprawna długość imienia, proszę wpisać poprawne!");
                txtBoxFirstName.Text = string.Empty;
            }
            
            if (txtBoxLastName.Text.Length < 50 && txtBoxLastName.Text.Length > 2)
            {
                nazwisko = txtBoxLastName.Text;
                validNazwisko = true;
            }
            else
            {
                MessageBox.Show("Niepoprawna długość nazwiska, proszę wpisać poprawne!");
                txtBoxLastName.Text = string.Empty;
            }
            
            if (txtBoxPhoneNumber.Text.Length < 15 && txtBoxPhoneNumber.Text.Length >= 9)
            {
                nr_telefonu = Convert.ToInt32(txtBoxPhoneNumber.Text);
                validNumer = true;
            }
            else
            {
                MessageBox.Show("Numer telefonu nie jest poprawny, proszę wprowadzić ponownie!");
                txtBoxPhoneNumber.Text = string.Empty;
            }

            if (txtBoxEmailAddress.Text.Length < 100 && txtBoxEmailAddress.Text.Length > 3)
            {
                if (IsValidEmail(txtBoxEmailAddress.Text))
                {
                    email = txtBoxEmailAddress.Text;
                    validEmail = true;
                }
                else
                {
                    MessageBox.Show("Adres email nie jest poprawny, spróbuj ponownie!");
                    txtBoxEmailAddress.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Niepoprawna długość adresu email, spróbuj jeszcze raz!");
                txtBoxEmailAddress.Text = string.Empty;
            }

            if (numericAdults.Value != 0 || numericKids.Value != 0)
            {
                if (numericAdults.Value != 0 || numericKids.Value == 0)
                {
                    dorosli = numericAdults.Value;
                    dzieci = numericKids.Value;
                    liczba_osob = dorosli + dzieci;
                    validPeopleNumber = true;
                }
                else
                {
                    MessageBox.Show("Dzieci nie mogą podróżować same!");
                }
            }
            else
            {
                MessageBox.Show("Podaj odpowiednią ilość osób będących na wycieczce!");
            }
            

            if (validImie && validNazwisko && validNumer && validEmail && validPeopleNumber)
            {
                SqlConnection connection = db.GetConnection();
                try
                {
                    connection.Open();

                    string query = $"INSERT INTO Rezerwacja (imie, nazwisko, nr_telefonu, adres_email, osoby_dorosle, dzieci, id_wycieczka) VALUES ('{imie}', '{nazwisko}', '{nr_telefonu}', '{email}', {dorosli}, {dzieci}, {tripNumber})"; //id_wycieczka klucz obcy
                    db.ExecuteQuery(connection, query);

                    calkowita_kwota = cena_za_osobe * liczba_osob;
                    MessageBox.Show("Zapisano rezerwację! Finalna kwota wycieczki: " + calkowita_kwota + " PLN");

                    formTripDetails fTripDetails = new formTripDetails(tripNumber);
                    this.Hide();
                    fTripDetails.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void formBookTrip_FormClosed(object sender, FormClosedEventArgs e)
        {
            formTripDetails fTripDetails = new formTripDetails(tripNumber);
            this.Hide();
            fTripDetails.Show();
        }

        private void txtBoxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+.[a-zA-Z]{2,}$";

            if (string.IsNullOrEmpty(email))
                return false;

            Regex regex = new Regex(emailPattern); //wyrażenie regularne
            return regex.IsMatch(email);
        }
    }
}
