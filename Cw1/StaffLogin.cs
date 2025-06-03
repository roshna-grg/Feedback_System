using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Cw1
{
    public partial class StaffLogin : Form
    {
        //MessageBox button
        MessageBoxButtons okBtn = MessageBoxButtons.OK;

        //MessageBox icon
        MessageBoxIcon exclamationIcon = MessageBoxIcon.Exclamation;

        public StaffLogin()
        {
            InitializeComponent();

            //Selecting the index of the combobox i.e. General
            userCB.SelectedIndex = 0;

            //Initialize variables for username and password
            string username;
            string password;

            //Initialize variables for combobox index
            int comboBoxIndex;

            try
            {
                IFormatter formatter = new BinaryFormatter();

                //Reading the csv file using serialization
                using (var stream = File.Open("loginData.csv", FileMode.Open, FileAccess.Read))
                {
                    //Creating object of LoginSerializable class
                    LoginSerializable loginSerializable = (LoginSerializable)formatter.Deserialize(stream);

                    if (loginSerializable.User.Equals("General"))
                    {
                        //Declaring the combobox index's variable
                        comboBoxIndex = 0;
                    }
                    else
                    {
                        //Declaring the combobox index's variable
                        comboBoxIndex = 1;
                    }
                    //Declaring the variables
                    username = loginSerializable.Username;
                    password = loginSerializable.Password;
                }
                //When username and password are not empty
                if (username != "" || password != "")
                {
                    if (comboBoxIndex == 0)
                    {
                        //Selecting 0 index i.e. General
                        userCB.SelectedIndex = 0;
                    }
                    else
                    {
                        //Selecting 1 index i.e. Admin
                        userCB.SelectedIndex = 1;
                    }

                    //Setting the text of the textboxes
                    usernameTB.Text = username;
                    passwordTB.Text = password;

                    //Setting the checkbox checked
                    rememberCB.Checked = true;
                }
            }
            catch 
            {

            }
        }

        private void LoginB_Click(object sender, EventArgs e)
        {
            //Username of Admin
            string aUsername = "admin";
            //Password of Admin
            string aPassword = "123";

            //Username of General
            string gUsername = "general";
            //Password of General
            string gPassword = "123";

            //Getting the text from the text fields
            string username = usernameTB.Text;
            string password = passwordTB.Text;

            if (username.Equals("") && password.Equals(""))
            {
                //When the textboxes are empty
                MessageBox.Show("Please fill the fields.", "Invalid", okBtn, exclamationIcon);
            }
            else
            {
                //Selected user is Admin
                if (userCB.SelectedItem.Equals("Admin"))
                {
                    //Checking whether the username and password are correct or not
                    if (username.Equals(aUsername) && password.Equals(aPassword))
                    {
                        //Creating an object of the AdminView form
                        Admin adminView = new Admin();
                        //Displays AdminView Form
                        adminView.Show();
                        //Hides this form
                        Hide();
                    }
                    else if (username == aUsername && password != aPassword)
                    {
                        //When username is correct while password is incorrect
                        MessageBox.Show("Password is incorrect.", "Invalid", okBtn, exclamationIcon);
                    }else
                    {
                        //When username and password is incorrect/invalid
                        MessageBox.Show("Invalid field.", "Invalid", okBtn, exclamationIcon);
                    }
                }
                //Selected user is General
                else if (userCB.SelectedItem.Equals("General"))
                {
                    //Checking whether the username and password are correct or not
                    if (username.Equals(gUsername) && password.Equals(gPassword))
                    {
                        //Creating an object of the General form
                        General general = new General();
                        //Displays General View form
                        general.Show();
                        //Hides this form
                        Hide();
                    }
                    else if (username == gUsername && password != gPassword)
                    {
                        //When username is correct while password is incorrect
                        MessageBox.Show("Password is incorrect.", "Invalid", okBtn, exclamationIcon);
                    }else
                    {
                        //When username and password is incorrect/invalid
                        MessageBox.Show("Invalid field.", "Invalid", okBtn, exclamationIcon);
                    }
                }
            }
        }
        //When back button is clicked
        private void BackB_Click(object sender, EventArgs e)
        {
            //Creating an object of the Login form
            Login login = new Login();
            //Displays the Login form
            login.Show();
            //Hides this form
            Hide();
        }

        private void RememberCB_CheckedChanged(object sender, EventArgs e)
        {
            //For serialization
            RememberMe();
        }
        private void UsernameTB_TextChanged(object sender, EventArgs e)
        {
            //For serialization
            if (usernameTB.Text != "" && passwordTB.Text != "")
            {
                //Calling the method
                RememberMe();
            }
        }
        private void PasswordTB_TextChanged(object sender, EventArgs e)
        {
            //Changing the characters of password to *
            passwordTB.PasswordChar = '*';

            if (usernameTB.Text != "" && passwordTB.Text != "")
            {
                //Calling the method
                RememberMe();
            }
        }

        private void RememberMe()
        {
            //Creating object of LoginSerializable class
            LoginSerializable loginSerializable = new LoginSerializable();

            if (rememberCB.Checked == true)
            {
                loginSerializable.User = userCB.Text;
                loginSerializable.Username = usernameTB.Text;
                loginSerializable.Password = passwordTB.Text;
            }
            else
            {
                loginSerializable.User = "";
                loginSerializable.Username = "";
                loginSerializable.Password = "";
            }

            IFormatter formatter = new BinaryFormatter();

            //Writing the data in the csv file using serialization
            Stream stream = new FileStream("loginData.csv", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, loginSerializable);
            stream.Close();
        }
    }
}
