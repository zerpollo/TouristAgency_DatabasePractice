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
using TouristAgency_DatabasePractice.ModelClasses.Junction;

namespace TouristAgency_DatabasePractice.UserControls
{
    public partial class ActivityControl : UserControl
    {
        public Activity ActivityModel;

        private List<Language> availableLanguages = new List<Language>();

        public ActivityControl(Activity activity)
        {
            string FilePath = @"pictures/plaza-de-espana.jpg";
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
            ActivityModel = activity;
            NameLabel.Text = activity.Name;
            LocationLabel.Text = activity.Location;
            PriceLabel.Text = activity.Price.ToString();
            DurationLabel.Text = activity.Duration.ToString();
            DescriptionTextBox.Text = activity.Description;

           // availableLanguages = GlobalVariables.Languages.Where<>
           List<LanguageActivities> tempLang = GlobalVariables.LanguageActivities.Where(activitylang => activitylang.ActivityID == activity.ID).ToList();

           var IenumLanguages = from al in tempLang join lang in GlobalVariables.Languages on al.LanguageID equals lang.ID where al.ActivityID == activity.ID select lang;

           availableLanguages = IenumLanguages.ToList();


            // fill drop downs
            LanguageComboBox.DataSource = availableLanguages;
            LanguageComboBox.DisplayMember = "Name";
    }

        private void AddButton_Click(object sender, EventArgs e)
        {
            GlobalVariables.SelectedActivities.Add(ActivityModel);
            AddButton.Text = "Added";
            AddButton.Enabled = false;
        }
    }
}
