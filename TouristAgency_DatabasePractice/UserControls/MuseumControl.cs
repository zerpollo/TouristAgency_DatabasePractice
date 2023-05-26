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
    public partial class MuseumControl : UserControl
    {
        public Museum Museum;
        public MuseumControl(Museum museum)
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
            this.Museum = museum;
            NameLabel.Text = museum.Name;
            LocationLabel.Text = museum.Location;
            PhoneNumberLabel.Text = museum.PhoneNumber;
            PriceLabel.Text = museum.Price.ToString();
            OpenTimeLabel.Text = museum.OpenTime.ToString();
            CloseTimeLabel.Text = museum.CloseTime.ToString();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
           GlobalVariables.SelectedMuseums.Add(Museum);
           AddButton.Text = "Added";
           AddButton.Enabled = false;
        }
    }
}
