using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouristAgency_DatabasePractice.Forms
{
    public partial class ToTourWindow : Form
    {
        public ToTourWindow()
        {
            InitializeComponent();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Hide();
            mainWindow.ShowDialog();

        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you!");
        }
    }
}
