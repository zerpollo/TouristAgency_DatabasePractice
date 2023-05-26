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
using TouristAgency_DatabasePractice.Core;

namespace TouristAgency_DatabasePractice.Forms.AdminPanelWindows
{
    public partial class NewDateTimeWindow : Form
    {
        public NewDateTimeWindow()
        {
            InitializeComponent();
            TimeComboBox.DataSource = StandartValues.timeOptions;
            TimeComboBox.DisplayMember = "ToString";
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            DateTimeDB dateTimeDB = new DateTimeDB();
            TimeSpan time = (TimeSpan)TimeComboBox.SelectedValue;
            DateTime dateTime = new DateTime(DatePicker.Value.Year, DatePicker.Value.Month, DatePicker.Value.Day, time.Hours, time.Minutes, time.Seconds);
            dateTimeDB.DateTime = dateTime;
            try
            {
                DataAccess da = new DataAccess();
                await da.SaveData("dbo.InsertNewDateTimeProc", new { dateTimeDB.DateTime });
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return;
            }
            MessageBox.Show("Success!");
        }
    }
}
