using System;
using System.Windows.Forms;

namespace Cw1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //When Staff button is clicked
        private void StaffB_Click(object sender, EventArgs e)
        {
            //Creating an object of the CustomerFeedback form
            StaffLogin loginAG = new StaffLogin();
            //Displays LoginAG Form
            loginAG.Show();
            //Hides this form
            Hide();
        }
        //When Customer button is clicked
        private void CustomerB_Click(object sender, EventArgs e)
        {
            //Creating an object of the CustomerFeedback form
            Feedback customerFeedback = new Feedback();
            //Displays CustomerFeedback Form
            customerFeedback.Show();
            //Hides this form
            Hide();
        }
    }
}
