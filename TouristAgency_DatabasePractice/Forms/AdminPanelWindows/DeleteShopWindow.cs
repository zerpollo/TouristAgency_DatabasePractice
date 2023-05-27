using DataAcessUtils;
using ModelClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouristAgency_DatabasePractice.Forms.AdminPanelWindows
{
    public partial class DeleteShopWindow : Form
    {
        private int SelectedID { get; set; }
        private List<Shop> shops;
        public  DeleteShopWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Shop shop;
                SelectedID = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                shop = shops.Where(x => x.ID == SelectedID).FirstOrDefault();
                DataAccess da = new DataAccess();
                await da.SaveData("dbo.DeleteShopProc", new { shop.ID });
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
            Task<IEnumerable<Shop>> TaskShops = da.LoadData<Shop, dynamic>("dbo.GetShopsProc", new { });
            IEnumerable<Shop> IShop = await TaskShops;
            shops = IShop.ToList();
            DataTable dtshop = new DataTable();
            dtshop.Columns.Add("ID", typeof(int));
            dtshop.Columns.Add("Name", typeof(string));
            dtshop.Columns.Add("Location", typeof(string));
            dtshop.Columns.Add("OpenTime", typeof(TimeSpan));
            dtshop.Columns.Add("CloseTime", typeof(TimeSpan));
            dtshop.Columns.Add("Description", typeof(string));
            foreach (Shop shop in IShop)
            {
                DataRow row = dtshop.NewRow();
                row["ID"] = shop.ID;
                row["Name"] = shop.Name;
                row["Location"] = shop.Location;
                row["OpenTime"] = shop.OpenTime;
                row["CloseTime"] = shop.CloseTime;
                row["Description"] = shop.Description;
                dtshop.Rows.Add(row);
            }
            dataGridView.DataSource = dtshop;
        }
    }
}
