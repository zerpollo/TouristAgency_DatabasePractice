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

namespace TouristAgency_DatabasePractice.UserControls
{
    public partial class ShopControl : UserControl
    {
        public Shop Shop;
        public ShopControl(Shop shop)
        {
            string FilePath = "..//..//..//el-gato.jpg";
            // initializing new Control
            InitializeComponent();
            if (File.Exists(FilePath))
            {
                pictureBox.Image = Image.FromFile(FilePath);
            }
            else
            {
                MessageBox.Show("Not found");
            }
            Shop = shop;
            NameLabel.Text = shop.Name;
            LocationLabel.Text = shop.Location;
            OpenTimeLabel.Text = shop.OpenTime.ToString();
            CloseTimeLabel.Text = shop.CloseTime.ToString();
            DescriptionTextBox.Text = shop.Description;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            GlobalVariables.SelectedShops.Add(Shop);
            AddButton.Text = "Added";
            AddButton.Enabled = false;
        }
    }
}
