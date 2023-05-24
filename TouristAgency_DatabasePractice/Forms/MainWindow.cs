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

namespace TouristAgency_DatabasePractice.Forms
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            if(GlobalVariables.CurrentClient.FirstName == "admin")
            {

            }
            else
            {
                MessageBox.Show("You don't have rights.");
            }
        }
    }
}
