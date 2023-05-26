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
        private List<DateTimeDB> availableTimes = new List<DateTimeDB>();

        public ActivityControl(Activity activity)
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
            ActivityModel = activity;
            NameLabel.Text = activity.Name;
            LocationLabel.Text = activity.Location;
            PriceLabel.Text = activity.Price.ToString();
            DurationLabel.Text = activity.Duration.ToString();
            DescriptionTextBox.Text = activity.Description;

           List<LanguageActivities> tempLang = GlobalVariables.LanguageActivities.Where(activitylang => activitylang.ActivityID == activity.ID).ToList();

           var IenumLanguages = from al in tempLang join lang in GlobalVariables.Languages on al.LanguageID equals lang.ID where al.ActivityID == activity.ID select lang;

           availableLanguages = IenumLanguages.ToList();

            // setting datetime combobox
            
            List<ActivitiesDateTime> tempdates = GlobalVariables.activitiesDateTimes.Where(activityTime => activityTime.ActivityID == activity.ID).ToList();

            var IenumDates = from ad in tempdates join dates in GlobalVariables.DateTimes on ad.DateTimeID equals dates.ID where ad.ActivityID == activity.ID select dates;

            availableTimes = IenumDates.ToList();

            // fill drop downs
            LanguageComboBox.DataSource = availableLanguages;
            LanguageComboBox.DisplayMember = "Name";

            DateTimeComboBox.DataSource = availableTimes;
            DateTimeComboBox.DisplayMember = "DateTime";
    }

        private void AddButton_Click(object sender, EventArgs e)
        {
            GlobalVariables.SelectedActivities.Add(ActivityModel);
            AddButton.Text = "Added";
            AddButton.Enabled = false;
        }
    }
}
