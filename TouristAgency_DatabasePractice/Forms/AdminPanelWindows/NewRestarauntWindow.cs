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
    public partial class NewRestarauntWindow : Form
    {
        public NewRestarauntWindow()
        {
            InitializeComponent();
            OpenTimeComboBox.DataSource = StandartValues.timeOptions;
            OpenTimeComboBox.DisplayMember = "ToShortTimeString";

            CloseTimeComboBox.BindingContext = new BindingContext();
            CloseTimeComboBox.DataSource = StandartValues.timeOptions;
            CloseTimeComboBox.DisplayMember = "ToShortTimeString";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }
    }
}
