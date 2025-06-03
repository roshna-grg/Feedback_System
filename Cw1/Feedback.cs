using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Cw1
{
    public partial class Feedback : Form
    {
        string cDate, cTime;

        //Messagebox's title
        string title = "Invalid";

        //MessageBox button
        MessageBoxButtons okBtn = MessageBoxButtons.OK;

        //MessageBox icons
        MessageBoxIcon exclamationIcon = MessageBoxIcon.Exclamation;
        MessageBoxIcon infoIcon = MessageBoxIcon.Information;

        CheckBox[] boxes;

        private void MainPage_Load(object sender, EventArgs e)
        {

        }
        public Feedback()
        {
            InitializeComponent();

            //Current date
            currentD.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //Current time
            currentT.Text = DateTime.Now.ToString("hh/mm/ss tt");

            //Set current date and time
            cDate = currentD.Text;
            cTime = currentT.Text;

            //Selecting the index of the combo box
            sNameCB.SelectedIndex = 0;
        }
        private void SNameCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clearing the table layout panel
            criteriaS1.Controls.Clear();

            //Initializing a variable to store criteria csv file's path name
            string criteriaPath;

            if (sNameCB.SelectedItem.Equals("Service 1"))
            {
                //Declaring the variable
                criteriaPath = "criteriaservice1.csv";
                //Calling the method with criteriaPath as the parameter
                AddCriteria(criteriaPath);
            }
            else if (sNameCB.SelectedItem.Equals("Service 2"))
            {
                //Declaring the variable
                criteriaPath = "criteriaservice2.csv";
                //Calling the method with criteriaPath as the parameter
                AddCriteria(criteriaPath);
            }
        }
        public void AddCriteria(string path)
        {
            //Read text from the file
            StreamReader streamReader = new StreamReader(path);

            string read = streamReader.ReadLine();

            if (read != null)
            {
                //Adding the text from the csv file to the array
                String[] criteria = read.Split(',');

                //Counting the length of the array
                int criteriaCount = criteria.Length;

                //Calculating the total checkboxes that is needed
                int totalCheckBox = criteriaCount * 4;

                //Creating an array of acount elements
                boxes = new CheckBox[totalCheckBox];

                int row = 0;

                for (int i = 0; i < criteriaCount; i++)
                {
                    //Setting the style of the row
                    criteriaS1.RowStyles.Add(new RowStyle(SizeType.Percent, Height = 100 ));

                    //Creating label
                    Label label = new Label()
                    {
                        //Setting label's name, anchor, font and text alignment
                        AutoSize = false,
                        Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                        Font = new Font("Microsoft Sans Serif", 12),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Text = criteria[i]
                    };

                    //Adding the label in the table layout panel
                    criteriaS1.Controls.Add(label, 0, row);

                    row++;
                }
                for (int a = 0; a < totalCheckBox; a++)
                {
                    //Creating checkbox
                    CheckBox checkBox = new CheckBox();

                    //Setting checkbox's name, anchor and alignment
                    checkBox.Name = "checkbox" + a.ToString();
                    checkBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                    checkBox.CheckAlign = ContentAlignment.MiddleCenter;

                    //Passes the checked checkbox
                    checkBox.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);

                    //Adding checkbox in the array
                    boxes[a] = checkBox;

                    //Adding array of checkbox in the table layout panel
                    criteriaS1.Controls.Add(boxes[a]);
                }
                //Enabling submit and clear button
                submitB.Enabled = true;
                clearB.Enabled = true;
            }
            else
            {
                MessageBox.Show("No criteria found.", title, okBtn, exclamationIcon);
            }
        }
        public void CheckBox_CheckedChanged(Object sender, EventArgs e)
        {
            //Counting the length of checkbox array
            int boxesCount = boxes.Length;

            //getting the checked checkbox
            CheckBox selectedCheckBox = (CheckBox)sender;

            //When one checkbox is checked, the other checkboxes of the same row is unchecked
            for (int i = 0; i < boxesCount; i += 4)
            {
                if (selectedCheckBox.Equals(boxes[i]))
                {
                    boxes[i + 1].Checked = false;
                    boxes[i + 2].Checked = false;
                    boxes[i + 3].Checked = false;
                }
                else if (selectedCheckBox.Equals(boxes[i + 1]))
                {
                    boxes[i].Checked = false;
                    boxes[i + 2].Checked = false;
                    boxes[i + 3].Checked = false;
                }
                else if (selectedCheckBox.Equals(boxes[i + 2]))
                {
                    boxes[i].Checked = false;
                    boxes[i + 1].Checked = false;
                    boxes[i + 3].Checked = false;
                }
                else if (selectedCheckBox.Equals(boxes[i + 3]))
                {
                    boxes[i].Checked = false;
                    boxes[i + 1].Checked = false;
                    boxes[i + 2].Checked = false;
                }
            }
            //For serialization
            bool check = CheckBoxCheck();
            if (nameTB.Text != "" && contactTB.Text != "" && emailTB.Text != "" && overallTB.Text != "" && check.Equals(true))
            {
                SerializeCheck();
            }
        }
        private bool CheckBoxCheck()
        {
            //Declaring the boolean varaible
            bool check = false;
            //Length of the array of check boxes
            int boxesCount = boxes.Length;

            //When any checkboxes are not checked from the same row, false value is returned
            for (int i = 0; i < boxesCount; i += 4)
            {
                if (boxes[i].Checked == false && boxes[i + 1].Checked == false && boxes[i + 2].Checked == false && boxes[i + 3].Checked == false)
                {
                    check = false;
                    break;
                }
                else
                {
                    check = true;
                }
            }
            return check;
        }
        private void ContactTB_TextChanged(object sender, EventArgs e)
        {
            //To check whether the typed value is numeric or not
            if (Regex.IsMatch(contactTB.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.", title, okBtn, exclamationIcon);
                contactTB.Clear();
            }
            //For serialization
            bool check = CheckBoxCheck();
            if (nameTB.Text != "" && contactTB.Text != "" && emailTB.Text != "" && overallTB.Text != "" && check.Equals(true))
            {
                SerializeCheck();
            }
        }
        private void SubmitB_Click(object sender, EventArgs e)
        {
            //Getting the text values from the text boxes
            string custName = nameTB.Text;
            string contact = contactTB.Text;
            string email = emailTB.Text;
            string overall = overallTB.Text;

            //Checking whether the typed value of email is valid or not
            bool emailCheck = IsEmailValid(email);

            if (custName.Equals(""))
            {
                custName = "Anonymous";
            }
            if (contact.Equals(""))
            {
                contact = "Anonymous";
            }
            if (email.Equals(""))
            {
                email = "Anonymous";
            }
            if (overall.Equals(""))
            {
                overall = "Nothing";
            }
            if (emailCheck.Equals(true))
            {
                //Checking whether the checkboxes are checked or not
                bool check = CheckBoxCheck();

                if (check.Equals(true))
                {
                    //Array list to store the value of the checked checkboxes
                    List<string> rating = new List<string>();

                    //Length of the checkbox array
                    int boxCount = boxes.Length;

                    //Adding the rating in the list
                    for (int i = 0; i < boxCount; i += 4)
                    {
                        if (boxes[i].Checked == true)
                        {
                            //5: Excellent
                            rating.Add("5");
                        }
                        else if (boxes[i + 1].Checked == true)
                        {
                            //3: Good
                            rating.Add("3");
                        }
                        else if (boxes[i + 2].Checked == true)
                        {
                            //2: Average
                            rating.Add("2");
                        }
                        else if (boxes[i + 3].Checked == true)
                        {
                            //1: Dissatified
                            rating.Add("1");
                        }
                    }
                    //Counting the length of the star array
                    int ratingCount = rating.Count;

                    //Creating an array
                    string[] finalRating = new string[ratingCount];

                    for (int i = 0; i < ratingCount; i++)
                    {
                        //Adding the data from list to the array
                        finalRating[i] = rating[i];
                    }
                    //Joining all the values stored in the finalStar array
                    string result = string.Join(",", finalRating);

                    if (sNameCB.Text.Equals("Service 1"))
                    {
                        string serviceName = sNameCB.Text;
                        //Path name of the csv file
                        string path = "customerdetails1.csv";
                        try
                        {
                            //Writing the data to the csv file(customerdetails1.csv)
                            StreamWriter streamWriter = new StreamWriter(path, true);

                            using (streamWriter)
                            {
                                streamWriter.WriteLine(serviceName + "," + custName + "," + contact + "," + email + "," + overall + "," + cDate + "," + cTime + "," + result);
                                MessageBox.Show("Thank you for the feedback.", "Message", okBtn, infoIcon);
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error while writing the data.", title, okBtn, exclamationIcon);
                        }
                    }
                    else
                    {
                        String serviceName = sNameCB.Text;
                        //Path name of the csv file
                        String path = "customerdetails2.csv";
                        try
                        {
                            //Writing the data to the csv file(customerdetails2.csv)
                            StreamWriter streamWriter = new StreamWriter(path, true);

                            using (streamWriter)
                            {
                                streamWriter.WriteLine(serviceName + "," + custName + "," + contact + "," + email + "," + overall + "," + cDate + "," + cTime + "," + result);
                                MessageBox.Show("Thank you for the feedback.", "Message", okBtn, infoIcon);
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error while writing the data.", title, okBtn, exclamationIcon);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please check the check boxes.", title, okBtn, exclamationIcon);
                }
            }
            else
            {
                MessageBox.Show("Please enter valid email address.", title, okBtn, exclamationIcon);
            }
            
        }
        //Checking whether the email address is valid or not
        private bool IsEmailValid(string email)
        {
            //If the email is valid, the method returns true
            //else false
            try
            {
                if (email.Equals(""))
                {
                    return true;
                }
                else
                {
                    var eAddress = new MailAddress(email);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Title, message and button of the Messagebox
            string exitTitle = "Close Window";
            string message = "Do you want to close this window?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            //Displaying the message box
            DialogResult result = MessageBox.Show(message, exitTitle, buttons);

            //Open login form when 'Yes' button is clicked
            if (result == DialogResult.Yes)
            {
                //Creating an object of the Login form
                Login login = new Login();
                //Displays Login form
                login.Show();
                //Hides this form
                Hide();
            }
        }
        private void ClearB_Click(object sender, EventArgs e)
        {
            try
            {
                //Clearing all the text from the textboxes
                nameTB.Clear();
                contactTB.Clear();
                emailTB.Clear();
                overallTB.Clear();

                //Setting the current date and time
                currentD.Text = DateTime.Now.ToString("dd/MM/yyyy");
                currentT.Text = DateTime.Now.ToString("hh/mm/ss tt");

                cDate = currentD.Text;
                cTime = currentT.Text;

                //Unchecking all the checkboxes
                int bCount = boxes.Length;
                for (int i = 0; i < bCount; i++)
                {
                    boxes[i].Checked = false;
                }
            }
            catch 
            {
                MessageBox.Show("Fields are already empty.", "Message", okBtn, infoIcon);
            }
        }

        private void NameTB_TextChanged(object sender, EventArgs e)
        {
            //For serialization
            bool check = CheckBoxCheck();
            if (nameTB.Text != "" && contactTB.Text != "" && emailTB.Text != "" && overallTB.Text != "" && check.Equals(true))
            {
                SerializeCheck();
            }
        }

        private void EmailTB_TextChanged(object sender, EventArgs e)
        {
            //For serialization
            bool check = CheckBoxCheck();
            if (nameTB.Text != "" && contactTB.Text != "" && emailTB.Text != "" && overallTB.Text != "" && check.Equals(true))
            {
                SerializeCheck();
            }
        }

        private void OverallTB_TextChanged(object sender, EventArgs e)
        {
            //For serialization
            bool check = CheckBoxCheck();
            if (nameTB.Text != "" && contactTB.Text != "" && emailTB.Text != "" && overallTB.Text != "" && check.Equals(true))
            {
                SerializeCheck();
            }
        }

        private void RetrieveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();

                //Reading the serialized data from the csv file
                using (var stream = File.Open("serializedCustData.csv", FileMode.Open, FileAccess.Read))
                {
                    CustomerSerializable customer = (CustomerSerializable)formatter.Deserialize(stream);

                    //Setting the text of the textboxes
                    nameTB.Text = customer.CustName;
                    contactTB.Text = customer.CustContact;
                    emailTB.Text = customer.CustEmail;
                    overallTB.Text = customer.CustOverall;

                    //Splitting the values and storing it in the array
                    string[] rating = customer.CustResult.Split(',');

                    //Length of the array
                    int ratingCount = rating.Length;

                    int a = 0;
                    //Checking the checkboxes
                    for (int i = 0; i < ratingCount; i++)
                    {
                        if (rating[i].Equals("5"))
                        {
                            boxes[a].Checked = true;
                        }
                        else if (rating[i].Equals("3"))
                        {
                            boxes[a + 1].Checked = true;
                        }
                        else if (rating[i].Equals("2"))
                        {
                            boxes[a + 2].Checked = true;
                        }
                        else if (rating[i].Equals("1"))
                        {
                            boxes[a + 3].Checked = true;
                        }
                        a += 4;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Data was not saved", "Invalid", okBtn, exclamationIcon);
            }
        }

        private void SerializeCheck()
        {
            try
            {
                //Creating an object of the CustomerSerializable class
                CustomerSerializable customer = new CustomerSerializable();

                //Initializing a list to add rating
                List<string> rating = new List<string>();
                //Length of the boxes array
                int boxesCount = boxes.Length;

                for (int i = 0; i < boxesCount; i += 4)
                {
                    if (boxes[i].Checked == true)
                    {
                        //5: Excellent
                        rating.Add("5");
                    }
                    else if (boxes[i + 1].Checked == true)
                    {
                        //3: Good
                        rating.Add("3");
                    }
                    else if (boxes[i + 2].Checked == true)
                    {
                        //2: Average
                        rating.Add("2");
                    }
                    else if (boxes[i + 3].Checked == true)
                    {
                        //1: Dissatified
                        rating.Add("1");
                    }
                    else 
                    {
                        rating.Add("0");
                    }
                }
                //Length of rating list
                int ratingCount = rating.Count;

                //Creating an array
                string[] finalRating = new string[ratingCount];

                for (int i = 0; i < ratingCount; i++)
                {
                    //Adding all the values from the list to the array
                    finalRating[i] = rating[i];
                }
                //Joining all the values stored in the array
                string result = string.Join(",", finalRating);
                
                //Setting the text
                customer.CustName = nameTB.Text;
                customer.CustContact = contactTB.Text;
                customer.CustEmail = emailTB.Text;
                customer.CustOverall = overallTB.Text;
                customer.CustResult = result;

                IFormatter formatter = new BinaryFormatter();

                //Writing the data in the csv file
                Stream stream = new FileStream("serializedCustData.csv", FileMode.Create, FileAccess.Write);

                formatter.Serialize(stream, customer);
                stream.Close();
            }
            catch
            {
            }
        }
    }
}
