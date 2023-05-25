using DataAcessUtils;
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

namespace TouristAgency_DatabasePractice.Forms.AdminPanelWindows
{
    public partial class NewActivityWindow : Form
    {
        public NewActivityWindow()
        {
            InitializeComponent();
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess da = new DataAccess();
                Activity actv = new Activity();
                actv.Name = NameTextBox.Text;
                actv.Location = LocationTextBox.Text;
                actv.Price = Convert.ToInt32(PriceTextBox.Text);
                actv.Duration = Convert.ToInt32(DurationTextBox.Text);
                actv.Description = DescriptionTextBox.Text;
                await da.SaveData("dbo.InsertNewActivityProc", new { actv.Name, actv.Duration, actv.Location, actv.Price, actv.Description });
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return;
            }
            MessageBox.Show("Success!");
            NameTextBox.Text = "";
            LocationTextBox.Text = "";
            PriceTextBox.Text = "";
            DurationTextBox.Text = "";
            DescriptionTextBox.Text = "";
        }
    }
}
