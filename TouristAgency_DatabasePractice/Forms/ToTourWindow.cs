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
using TouristAgency_DatabasePractice.UserControls;

namespace TouristAgency_DatabasePractice.Forms
{
    public partial class ToTourWindow : Form
    {
        private float finalPrice;
        public ToTourWindow()
        {
            InitializeComponent();

            // calculating final price
            foreach (Museum mus in GlobalVariables.SelectedMuseums)
            {
                finalPrice += mus.Price; 
            }
            foreach (Activity act in GlobalVariables.SelectedActivities)
            {
                finalPrice += act.Price;
            }

            // setting source for number of people
            NumberOfPeopleComboBox.DataSource = StandartValues.NumberOfPeople;

            // setting initial price
            FinalPriceLabel.Text = finalPrice.ToString();

            // setting controls of selected items
            foreach (Shop shop in GlobalVariables.SelectedShops)
            {
                SelectedItemsFlowLayoutPanel.Controls.Add(new ShopControl(shop));
            }
            foreach (Restaraunt rest in GlobalVariables.SelectedRestaraunts)
            {
                SelectedItemsFlowLayoutPanel.Controls.Add(new RestaurantControl(rest));
            }
            foreach (Museum mus in GlobalVariables.SelectedMuseums)
            {
                SelectedItemsFlowLayoutPanel.Controls.Add(new MuseumControl(mus));
            }
            foreach (Activity act in GlobalVariables.SelectedActivities)
            {
                SelectedItemsFlowLayoutPanel.Controls.Add(new ActivityControl(act));
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you!");
        }

        private void NumberOfPeopleComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var mult = finalPrice * (int)NumberOfPeopleComboBox.SelectedValue;
            FinalPriceLabel.Text = mult.ToString();
        }
    }
}
