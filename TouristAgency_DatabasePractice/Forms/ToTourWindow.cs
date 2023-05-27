using DataAcessUtils;
using ModelClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TouristAgency_DatabasePractice.Core;
using TouristAgency_DatabasePractice.ModelClasses.Junction;
using TouristAgency_DatabasePractice.UserControls;
using Activity = ModelClasses.Activity;

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

        private async void PayButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you!");
            GlobalVariables.CurrentTour.Price = Convert.ToInt32(FinalPriceLabel.Text);
            GlobalVariables.CurrentTour.IssuanceDate = DateTime.Now;
            GlobalVariables.CurrentTour.PeopleQuantity = (int)NumberOfPeopleComboBox.SelectedValue;

            DataAccess da = new DataAccess();
            //  await da.SaveData("dbo.InsertNewRestaurantProc", new { res.Name, res.PhoneNumber, res.Location, res.OpenTime, res.CloseTime, res.Description });
            await da.SaveData("dbo.UpdateTourProc", new { GlobalVariables.CurrentTour.ClientID, GlobalVariables.CurrentTour.IssuanceDate, GlobalVariables.CurrentTour.PeopleQuantity, GlobalVariables.CurrentTour.Price });

            foreach (Shop shop in GlobalVariables.SelectedShops)
            {
                ToursShops TS = new ToursShops(GlobalVariables.CurrentTour.ID,shop.ID);
                await da.SaveData("dbo.InsertNewToursShopsProc", new { TS.TourID, TS.ShopID});
            }
            foreach(Activity activity in GlobalVariables.SelectedActivities)
            {
                ToursActivities TA = new ToursActivities(GlobalVariables.CurrentTour.ID, activity.ID);
                await da.SaveData("dbo.InsertNewToursActivitiesProc", new { TA.TourID, TA.ActivityID});
            }
            foreach(Museum mus in GlobalVariables.SelectedMuseums)
            {
                ToursMuseums TM = new ToursMuseums(GlobalVariables.CurrentTour.ID, mus.ID);
                await da.SaveData("dbo.InsertNewToursMuseumsProc", new { TM.TourID, TM.MuseumID });
            }
            foreach(Restaraunt rest in GlobalVariables.SelectedRestaraunts)
            {
                ToursRestaurants TR = new ToursRestaurants(GlobalVariables.CurrentTour.ID, rest.ID);
                await da.SaveData("dbo.InsertNewToursRestaurantsProc", new { TR.TourID, TR.RestaurantID });
            }
        }

        private void NumberOfPeopleComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var mult = finalPrice * (int)NumberOfPeopleComboBox.SelectedValue;
            FinalPriceLabel.Text = mult.ToString();
        }
    }
}
