using System;
using System.Windows.Forms;

namespace Cw1
{
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            //Creating an object of the Report form
            Report report = new Report();
            //Displays Report form
            report.Show();
            //Hides this form
            Hide();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            //Creating an object of the LoginAG form
            StaffLogin loginAG = new StaffLogin();
            //Displays LoginAG form
            loginAG.Show();
            //Hides this form
            Hide();
        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            //Creating an object of the ImportBulkData form
            Import importBulkData = new Import();
            //Displays Report form
            importBulkData.Show();
            //Hides this form
            Hide();
        }
    }
}
