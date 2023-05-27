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
    public partial class DeleteRestaurantWindow : Form
    {
        private int SelectedID { get; set; }
        private List<Restaraunt> restaraunts;
        public DeleteRestaurantWindow()
        {
            InitializeComponent();
            LoadData();
        }
        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Restaraunt restaraunt;
                SelectedID = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                restaraunt = restaraunts.Where(x => x.ID == SelectedID).FirstOrDefault();
                DataAccess da = new DataAccess();
                await da.SaveData("dbo.DeleteRestaurantProc", new { restaraunt.ID });
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
            Task<IEnumerable<Restaraunt>> TaskRestaraunt = da.LoadData<Restaraunt, dynamic>("dbo.GetRestaurantsProc", new { });
            IEnumerable<Restaraunt> IRestaraunts = await TaskRestaraunt;
            restaraunts = IRestaraunts.ToList();
            DataTable dtrestaurant = new DataTable();
            dtrestaurant.Columns.Add("ID", typeof(int));
            dtrestaurant.Columns.Add("Name", typeof(string));
            dtrestaurant.Columns.Add("Location", typeof(string));
            dtrestaurant.Columns.Add("PhoneNumber", typeof(string));
            dtrestaurant.Columns.Add("OpenTime", typeof(TimeSpan));
            dtrestaurant.Columns.Add("CloseTime", typeof(TimeSpan));
            dtrestaurant.Columns.Add("Description", typeof(string));
            foreach (Restaraunt restaurant in IRestaraunts)
            {
                DataRow row = dtrestaurant.NewRow();
                row["ID"] = restaurant.ID;
                row["Name"] = restaurant.Name;
                row["Location"] = restaurant.Location;
                row["PhoneNumber"] = restaurant.PhoneNumber;
                row["OpenTime"] = restaurant.OpenTime;
                row["CloseTime"] = restaurant.CloseTime;
                row["Description"] = restaurant.Description;
                dtrestaurant.Rows.Add(row);
            }
            dataGridView.DataSource = dtrestaurant;
        }
    }
}
