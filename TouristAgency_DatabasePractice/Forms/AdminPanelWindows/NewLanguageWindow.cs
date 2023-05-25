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
    public partial class NewLanguageWindow : Form
    {
        public NewLanguageWindow()
        {
            InitializeComponent();
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Language lang = new Language();
                DataAccess da = new DataAccess();
                lang.Name = NameTextBox.Text;
                await da.SaveData("dbo.InsertNewLanguageProc", new { lang.Name });
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return;
            }
            MessageBox.Show("Success!");
            NameTextBox.Text = "";
        }
    }
}
