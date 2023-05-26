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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            DateLabel.Text = "Welcome, today is: " + DateTime.Today.ToShortDateString();

            //getting info from db and creating controls in flow panels
            GetGlobalVariablesFromDB();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            if(GlobalVariables.CurrentClient.FirstName == "admin")
            {
              AdminWindow adminWindow = new AdminWindow();
              adminWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("You don't have rights.");
            }
        }

        private void ToTourButton_Click(object sender, EventArgs e)
        {
            ToTourWindow toTourWindow = new ToTourWindow();
            toTourWindow.ShowDialog();
        }
        public async void GetGlobalVariablesFromDB()
        {
            DataAccess da = new DataAccess();

            Task<IEnumerable<Language>> TaskLanguage = da.LoadData<Language, dynamic>("dbo.GetLanguagesProc", new { });
            IEnumerable<Language> ILanguage = await TaskLanguage;
            GlobalVariables.Languages = ILanguage.ToList();

            Task<IEnumerable<Museum>> TaskMuseums = da.LoadData<Museum, dynamic>("dbo.GetMuseumsProc", new { });
            IEnumerable<Museum> IMuseums = await TaskMuseums;
            GlobalVariables.Museums = IMuseums.ToList();

            Task<IEnumerable<Shop>> TaskShops = da.LoadData<Shop, dynamic>("dbo.GetShopsProc", new { });
            IEnumerable<Shop> IShop = await TaskShops;
            GlobalVariables.Shops = IShop.ToList();

            Task<IEnumerable<Restaraunt>> TaskRestaraunt = da.LoadData<Restaraunt, dynamic>("dbo.GetRestaurantsProc", new { });
            IEnumerable<Restaraunt> IRestaraunts = await TaskRestaraunt;
            GlobalVariables.Restaraunts = IRestaraunts.ToList();

            Task<IEnumerable<Activity>> TaskActivity = da.LoadData<Activity, dynamic>("dbo.GetActivitiesProc", new { });
            IEnumerable<Activity> IActivity = await TaskActivity;
            GlobalVariables.Activities = IActivity.ToList();

            Task<IEnumerable<LanguageActivities>> TaskLanguageActivities = da.LoadData<LanguageActivities, dynamic>("dbo.GetLanguageActivitiesProc", new { });
            IEnumerable<LanguageActivities> ILanguageActivities = await TaskLanguageActivities;
            GlobalVariables.LanguageActivities = ILanguageActivities.ToList();

            Task<IEnumerable<ActivitiesDateTime>> TaskActivitiesDateTime = da.LoadData<ActivitiesDateTime, dynamic>("dbo.GetActivitiesDateTimeProc", new { });
            IEnumerable<ActivitiesDateTime> IActivitiesDateTime = await TaskActivitiesDateTime;
            GlobalVariables.activitiesDateTimes = IActivitiesDateTime.ToList();

            SpawnControls();
        }
        public void SpawnControls()
        {
            foreach(Shop shop in GlobalVariables.Shops)
            {
                ShopPanel.Controls.Add(new ShopControl(shop));
            }
            foreach (Restaraunt rest in GlobalVariables.Restaraunts)
            {
                RestarauntsPanel.Controls.Add(new RestaurantControl(rest));
            }
            foreach (Museum mus in GlobalVariables.Museums)
            {
                MuseumsPanel.Controls.Add(new MuseumControl(mus));
            }
            foreach (Activity act in GlobalVariables.Activities)
            {
                ActivitiesPanel.Controls.Add(new ActivityControl(act));
            }
        }
    }
}
