﻿using DataAcessUtils;
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
    public partial class DeleteMuseumWindow : Form
    {
        public DeleteMuseumWindow()
        {
            InitializeComponent();
            LoadData();
        }
        private async void LoadData()
        {
            DataAccess da = new DataAccess();
            Task<IEnumerable<Museum>> TaskMuseums = da.LoadData<Museum, dynamic>("dbo.GetMuseumsProc", new { });
            IEnumerable<Museum> IMuseums = await TaskMuseums;
            DataTable dtmuseum = new DataTable();
            dtmuseum.Columns.Add("ID", typeof(int));
            dtmuseum.Columns.Add("Name", typeof(string));
            dtmuseum.Columns.Add("Location", typeof(string));
            dtmuseum.Columns.Add("PhoneNumber", typeof(string));
            dtmuseum.Columns.Add("OpenTime", typeof(TimeSpan));
            dtmuseum.Columns.Add("CloseTime", typeof(TimeSpan));
            dtmuseum.Columns.Add("Price", typeof(int));
            foreach (Museum museum in IMuseums)
            {
                DataRow row = dtmuseum.NewRow();
                row["ID"] = museum.ID;
                row["Name"] = museum.Name;
                row["Location"] = museum.Location;
                row["PhoneNumber"] = museum.PhoneNumber;
                row["OpenTime"] = museum.OpenTime;
                row["CloseTime"] = museum.CloseTime;
                row["Price"] = museum.Price;
                dtmuseum.Rows.Add(row);
            }
            dataGridView.DataSource = dtmuseum;
        }
    }
}
