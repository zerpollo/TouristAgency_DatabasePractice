using DataAcessUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TouristAgency_DatabasePractice.ModelClasses.Junction;

namespace TouristAgency_DatabasePractice.Forms.AdminPanelWindows
{
    public partial class AddLanguageToActivityWindow : Form
    {
        public AddLanguageToActivityWindow()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess da = new DataAccess();
                LanguageActivities languageActivities = new LanguageActivities();
                languageActivities.ActivityID = Convert.ToInt32(ActivityIDTextBox.Text);
                languageActivities.LanguageID = Convert.ToInt32(LangIDTextBox.Text);
                await da.SaveData("dbo.AddLanguageToActivityProc", new { languageActivities.ActivityID, languageActivities.LanguageID });
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
                return;
            }
            MessageBox.Show("Success!");
            ActivityIDTextBox.Text = "";
            LangIDTextBox.Text = "";
        }
    }
}
