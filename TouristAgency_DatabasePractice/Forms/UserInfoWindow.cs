using ModelClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TouristAgency_DatabasePractice.Core;
using TouristAgency_DatabasePractice.Forms;

namespace TouristAgency_DatabasePractice
{
    public partial class UserInfoWindow : Form
    {
        public UserInfoWindow()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // long-ass check there's a way to make it better but idk
            if(!string.IsNullOrEmpty(FNTextBox.Text) && !string.IsNullOrEmpty(LNTextBox.Text) && !string.IsNullOrEmpty(AddressTextBox.Text)
            && !string.IsNullOrEmpty(CountryTextBox.Text) && !string.IsNullOrEmpty(PhoneNTextBox.Text))
            {
                // creating new user to put it in Global variables class
                Client client = new Client(FNTextBox.Text, LNTextBox.Text, AddressTextBox.Text, CountryTextBox.Text, PhoneNTextBox.Text);
                GlobalVariables.CurrentClient = client;

                // opening main window
                MainWindow mainwindow = new MainWindow();
                Hide();
                mainwindow.ShowDialog();
                Close();
                
            }
            else
            {
                MessageBox.Show("There is error in provided information");
            }
        }
    }
}
