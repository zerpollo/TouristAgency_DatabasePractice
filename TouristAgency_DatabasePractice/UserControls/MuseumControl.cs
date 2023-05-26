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
    public partial class MuseumControl : UserControl
    {
        public Museum Museum;
        public MuseumControl(Museum museum)
        {
            InitializeComponent();
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

        }
    }
}
