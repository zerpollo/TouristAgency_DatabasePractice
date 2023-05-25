using DataAcessUtils;
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

namespace TouristAgency_DatabasePractice.Forms.AdminPanelWindows
{
    public partial class NewMuseumWindow : Form
    {
        public NewMuseumWindow()
        {
            InitializeComponent();

            OpenTimeComboBox.DataSource = StandartValues.timeOptions;
            OpenTimeComboBox.DisplayMember = "ToString";

            CloseTimeComboBox.BindingContext = new BindingContext();
            CloseTimeComboBox.DataSource = StandartValues.timeOptions;
            CloseTimeComboBox.DisplayMember = "ToString";
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess da = new DataAccess();
                Museum mus = new Museum();
                mus.Name = NameTextBox.Text;
                mus.Price = Convert.ToInt32(PriceTextBox.Text);
                mus.Location = LocationTextBox.Text;
                mus.PhoneNumber = PhoneNumberTextBox.Text;
                mus.CloseTime = (TimeSpan)CloseTimeComboBox.SelectedItem;
                mus.OpenTime = (TimeSpan)OpenTimeComboBox.SelectedItem;
                await da.SaveData("dbo.InsertNewMuseumProc", new { mus.Name, mus.Location, mus.OpenTime, mus.CloseTime, mus.Price, mus.PhoneNumber });
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return;
            }
            MessageBox.Show("Success!");
            NameTextBox.Text = "";
            PriceTextBox.Text = "";
            LocationTextBox.Text = "";
        }
    }
}
