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
    public partial class NewShopWindow : Form
    {
        public NewShopWindow()
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
                Shop shop = new Shop();
                shop.Name = NameTextBox.Text;
                shop.Location = LocationTextBox.Text;
                shop.CloseTime = (TimeSpan)CloseTimeComboBox.SelectedItem;
                shop.OpenTime = (TimeSpan)OpenTimeComboBox.SelectedItem;
                shop.Description = DescriptionTextBox.Text;
                await da.SaveData("dbo.InsertNewShopProc", new { shop.Name, shop.Location, shop.OpenTime, shop.CloseTime, shop.Description });
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return;
            }
            MessageBox.Show("Success!");
            NameTextBox.Text = "";
            LocationTextBox.Text = "";
            DescriptionTextBox.Text = "";
        }

        private void NewShopWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
