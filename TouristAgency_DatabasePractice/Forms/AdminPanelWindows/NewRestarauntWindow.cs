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
    public partial class NewRestarauntWindow : Form
    {
        public NewRestarauntWindow()
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
                Restaraunt res = new Restaraunt();
                res.Name = NameTextBox.Text;
                res.Location = LocationTextBox.Text;
                res.PhoneNumber = PhoneNumberTextBox.Text;
                res.CloseTime = (TimeSpan)CloseTimeComboBox.SelectedItem;
                res.OpenTime = (TimeSpan)OpenTimeComboBox.SelectedItem;
                res.Description = DescriptionTextBox.Text;
                await da.SaveData("dbo.InsertNewRestaurantProc", new { res.Name, res.PhoneNumber, res.Location, res.OpenTime, res.CloseTime, res.Description });
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return;
            }
            MessageBox.Show("Success!");
            NameTextBox.Text = "";
            LocationTextBox.Text = "";
            PhoneNumberTextBox.Text = "";
            DescriptionTextBox.Text = "";
        }
    }
}
