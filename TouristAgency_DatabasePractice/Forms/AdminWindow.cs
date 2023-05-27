using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TouristAgency_DatabasePractice.Forms.AdminPanelWindows;

namespace TouristAgency_DatabasePractice.Forms
{
    public partial class AdminWindow : Form
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddShopButton_Click(object sender, EventArgs e)
        {
            NewShopWindow newShop = new NewShopWindow();
            newShop.ShowDialog();
        }

        private void AddRestarauntButton_Click(object sender, EventArgs e)
        {
            NewRestarauntWindow newRestaraunt = new NewRestarauntWindow();
            newRestaraunt.ShowDialog();
        }

        private void AddLangToActButton_Click(object sender, EventArgs e)
        {
            AddLanguageToActivityWindow addLanguageToActivityWindow = new AddLanguageToActivityWindow();
            addLanguageToActivityWindow.ShowDialog();
        }

        private void AddLanguageButton_Click(object sender, EventArgs e)
        {
            NewLanguageWindow newLang = new NewLanguageWindow();
            newLang.ShowDialog();
        }

        private void AddActivityButton_Click(object sender, EventArgs e)
        {
            NewActivityWindow newActivityWindow = new NewActivityWindow();
            newActivityWindow.ShowDialog();
        }

        private void AddMuseumButton_Click(object sender, EventArgs e)
        {
            NewMuseumWindow newMuseumWindow = new NewMuseumWindow();
            newMuseumWindow.ShowDialog();
        }

        private void AddDateTimeButton_Click(object sender, EventArgs e)
        {
            NewDateTimeWindow newDateTimeWindow = new NewDateTimeWindow();
            newDateTimeWindow.ShowDialog();
        }

        private void DeleteShopButton_Click(object sender, EventArgs e)
        {
            DeleteShopWindow deleteShopWindow = new DeleteShopWindow();
            deleteShopWindow.ShowDialog();
        }

        private void DeleteRestaurantButton_Click(object sender, EventArgs e)
        {
            DeleteRestaurantWindow deleteRestaurantWindow = new DeleteRestaurantWindow();
            deleteRestaurantWindow.ShowDialog();
        }

        private void DeleteMuseumButton_Click(object sender, EventArgs e)
        {
            DeleteMuseumWindow deleteMuseumWindow = new DeleteMuseumWindow();
            deleteMuseumWindow.ShowDialog();
        }

        private void DeleteActivityButton_Click(object sender, EventArgs e)
        {
            DeleteActivityWindow deleteActivityWindow = new DeleteActivityWindow();
            deleteActivityWindow.ShowDialog();
        }
    }
}
