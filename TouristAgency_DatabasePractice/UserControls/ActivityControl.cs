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
    public partial class ActivityControl : UserControl
    {
        public Activity ActivityModel;
        public ActivityControl(Activity activity)
        {
            InitializeComponent();
            // initializing new Control
            ActivityModel = activity;
            NameLabel.Text = activity.Name;
            LocationLabel.Text = activity.Location;
            PriceLabel.Text = activity.Price.ToString();
            DurationLabel.Text = activity.Duration.ToString();
            DescriptionTextBox.Text = activity.Description;

            // fill drop downs

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }
    }
}
