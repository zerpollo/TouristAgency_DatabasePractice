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

namespace TouristAgency_DatabasePractice.UserControls
{
    public partial class RestaurantControl : UserControl
    {
        public Restaraunt Restaraunt;

        public RestaurantControl(Restaraunt restaraunt)
        {
            string FilePath = "C:\\Users\\zerpollo-PC\\source\\repos\\TouristAgency_DatabasePractice\\TouristAgency_DatabasePractice\\sample.bmp";
            InitializeComponent();
            if (File.Exists(FilePath))
            {
                    pictureBox.Image = new Bitmap(FilePath);
            }
            else
            {
                MessageBox.Show("Not found");
            }
            Restaraunt = restaraunt;
            NameLabel.Text = restaraunt.Name;
            LocationLabel.Text = restaraunt.Location;
            PhoneNumberLabel.Text = restaraunt.PhoneNumber;
            OpenTimeLabel.Text = restaraunt.OpenTime.ToString();
            CloseTimeLabel.Text = Restaraunt.CloseTime.ToString();
            DescriptionTextBox.Text = restaraunt.Description;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }
    }
}
