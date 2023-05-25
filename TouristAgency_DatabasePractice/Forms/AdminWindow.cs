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
    }
}
