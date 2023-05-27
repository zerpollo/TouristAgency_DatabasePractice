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
    public partial class DeleteActivityWindow : Form
    {
        private int SelectedID { get; set; }
        public DeleteActivityWindow()
        {
            InitializeComponent();
            LoadData();
        }
        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Activity activity = new Activity();
                SelectedID = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                activity.ID = SelectedID;
                DataAccess da = new DataAccess();
                await da.SaveData("dbo.DeleteActivityProc", new { activity.ID });
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return;
            }
            MessageBox.Show("Success!");
            LoadData();
        }
        private async void LoadData()
        {
            DataAccess da = new DataAccess();
            Task<IEnumerable<Activity>> TaskActivity = da.LoadData<Activity, dynamic>("dbo.GetActivitiesProc", new { });
            IEnumerable<Activity> IActivity = await TaskActivity;
            DataTable dtactivity = new DataTable();
            dtactivity.Columns.Add("ID", typeof(int));
            dtactivity.Columns.Add("Name", typeof(string));
            dtactivity.Columns.Add("Location", typeof(string));
            dtactivity.Columns.Add("Duration", typeof(int));
            dtactivity.Columns.Add("Price", typeof(int));
            dtactivity.Columns.Add("Description", typeof(string));
            foreach (Activity activity in IActivity)
            {
                DataRow row = dtactivity.NewRow();
                row["ID"] = activity.ID;
                row["Name"] = activity.Name;
                row["Location"] = activity.Location;
                row["Duration"] = activity.Duration;
                row["Price"] = activity.Price;
                row["Description"] = activity.Description;
                dtactivity.Rows.Add(row);
            }
            dataGridView.DataSource = dtactivity;
        }
    }
}
