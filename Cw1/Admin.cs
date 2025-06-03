using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Cw1
{
    public partial class Admin : Form
    {
        //MessageBox button
        MessageBoxButtons okBtn = MessageBoxButtons.OK;

        //MessageBox icons
        MessageBoxIcon exclamationIcon = MessageBoxIcon.Exclamation;
        MessageBoxIcon infoIcon = MessageBoxIcon.Information;

        public Admin()
        {
            InitializeComponent();
        }
        //To add new criteria
        private void AddB_Click(object sender, EventArgs e)
        {
            //Getting the text values from the textbox and combobox
            string serviceName = serviceNameCB.Text;
            string criteria = criteriaNameTB.Text;

            //Check whether the text field is empty or not and combo box is selected or not
            bool check = AddCheck(serviceName, criteria);

            if (check.Equals(true))
            {
                if (serviceName.Equals("Service 1"))
                {
                    //Pathname of the criteria list csv file
                    string pathname = "criteriaservice1.csv";

                    //Creating an array to store criteria
                    string[] criteriaArray = null;

                    try
                    {
                        //Reading csv file
                        StreamReader streamReader = new StreamReader(pathname);
                        string read = null;

                        while ((read = streamReader.ReadLine()) != null)
                        {
                            //Splitting the data from the csv file and storing it in array
                            criteriaArray = read.Split(',');
                        }
                        streamReader.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Error while reading the data.","Invalid", okBtn, exclamationIcon);
                    }
                    //Creating a list to store criteria in lowercase
                    List <string> criteriaList = new List<string>();

                    for (int i = 0; i < criteriaArray.Length; i++)
                    {
                        //Lower casing the data of array and adding it to the list
                        criteriaList.Add(criteriaArray[i].ToLower());
                    }
                    //Checking whether list contains the input criteria name or not
                    if (criteriaList.Contains(criteria.ToLower()))
                    {
                        MessageBox.Show("Criteria already exists.", "Invalid", okBtn, exclamationIcon);
                    }
                    else
                    {
                        //Joining all the values of the array(criteriaArray)
                        string result = string.Join(",", criteriaArray);

                        try
                        {
                            //Writing the data to the csv file
                            StreamWriter streamWriter = new StreamWriter(pathname);
                            using (streamWriter)
                            {
                                streamWriter.WriteLine(result + "," + criteria);

                                MessageBox.Show("Criteria added.", "Message", okBtn, infoIcon);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Error while writing the data.", "Invalid", okBtn, exclamationIcon);
                        }
                    }
                }
                else if (serviceName.Equals("Service 2"))
                {
                    //Pathname of the criteria list csv file
                    string pathname = "criteriaservice2.csv";

                    //Creating an array to store criteria
                    string[] criteriaArray = null;

                    try
                    {
                        //Reading csv file
                        StreamReader streamReader = new StreamReader(pathname);
                        string read = null;

                        while ((read = streamReader.ReadLine()) != null)
                        {
                            //Splitting the data from the csv file and storing it in array
                            criteriaArray = read.Split(',');
                        }
                        streamReader.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Error while reading the data.", "Invalid", okBtn, exclamationIcon);
                    }
                    //Creating a list to store criteria in lowercase
                    List<string> criteriaList = new List<string>();

                    for (int i = 0; i < criteriaArray.Length; i++)
                    {
                        //Lower casing the data of array and adding it to the list
                        criteriaList.Add(criteriaArray[i].ToLower());
                    }
                    //Checking whether list contains the input criteria name or not
                    if (criteriaList.Contains(criteria.ToLower()))
                    {
                        MessageBox.Show("Criteria already exists.", "Invalid", okBtn, exclamationIcon);
                    }
                    else
                    {
                        //Joining all the values of the array(criteriaArray)
                        string result = string.Join(",", criteriaArray);

                        try
                        {
                            //Writing the data to the csv file
                            StreamWriter streamWriter = new StreamWriter(pathname);
                            using (streamWriter)
                            {
                                streamWriter.WriteLine(result + "," + criteria);

                                MessageBox.Show("Criteria added.", "Message", okBtn, infoIcon);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Error while writing the data.", "Invalid", okBtn, exclamationIcon);
                        }
                    }
                }
            }
        }
        //Check whether the text field is empty or not and combo box is selected or not
        public bool AddCheck(string serviceName, string criteria)
        {
            //When the textfield is empty and combobox is not selected
            if (serviceName.Equals("") && criteria.Equals(""))
            {
                MessageBox.Show("Please fill all the fields.", "Invalid");
            }
            else if (serviceName.Equals(""))
            {
                MessageBox.Show("Please select the service name.", "Invalid");
            }
            else if (criteria.Equals(""))
            {
                MessageBox.Show("Please enter the criteria.", "Invalid");
            }
            else
            {
                return true;
            }
            return false;
        }

        //To update criteria
        private void UpdateB_Click(object sender, EventArgs e)
        {
            //Getting the text values from the textboxes and combo box
            string serviceId = idTB.Text;
            string criteriaName = criteriaUTB.Text;
            string serviceName = serviceUCB.Text;

            //Check whether the text field is empty or not and combo box is selected or not
            bool check = UpdateCheck(serviceId, criteriaName, serviceName);
            if (check.Equals(true))
            {
                //Converting string to integer
                int id = int.Parse(serviceId);

                if (serviceName.Equals("Service 1"))
                {
                    //Pathname of the criteria list csv file
                    string path = "criteriaservice1.csv";

                    //Creating an array to store criteria
                    string[] criteriaArray = null;

                    try
                    {
                        //Reading csv file
                        StreamReader streamReader = new StreamReader(path);
                        string read = null;

                        while ((read = streamReader.ReadLine()) != null)
                        {
                            //Splitting the data from the csv file and storing it in array
                            criteriaArray = read.Split(',');
                        }
                        streamReader.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Error while reading the data.", "Invalid", okBtn, exclamationIcon);
                    }

                    //Length of the criteriaA array
                    int count = criteriaArray.Length;

                    if (count >= id)
                    {
                        //Creating a list to store criteria in lowercase
                        List<string> criteriaList = new List<string>();

                        for (int i = 0; i < count; i++)
                        {
                            //Lower casing the data of array and adding it to the list
                            criteriaList.Add(criteriaArray[i].ToLower());
                        }

                        //Checking whether the criteria alreadys exists or not
                        if (criteriaList.Contains(criteriaName.ToLower()))
                        {
                            MessageBox.Show("Criteria already exists.", "Invalid", okBtn, exclamationIcon);
                        }
                        else
                        {
                            //Updating the value of the criteria list
                            criteriaArray[id - 1] = criteriaName;

                            //Joining all the values of the array(criteriaArray)
                            string result = string.Join(",", criteriaArray);

                            try
                            {
                                //Writing the data to the csv file(Criteria list)
                                StreamWriter streamWriter = new StreamWriter(path);

                                using (streamWriter)
                                {
                                    streamWriter.WriteLine(result);
                                    MessageBox.Show("Criteria updated.", "Message");
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Error while writing the data.", "Invalid");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid Id number.", "Invalid");
                    }
                }
                else if (serviceName.Equals("Service 2"))
                {
                    //Pathname of the criteria list csv file
                    string path = "criteriaservice2.csv";

                    //Creating an array to store criteria
                    string[] criteriaArray = null;

                    try
                    {
                        //Reading csv file
                        StreamReader streamReader = new StreamReader(path);
                        string read = null;

                        while ((read = streamReader.ReadLine()) != null)
                        {
                            //Splitting the data from the csv file and storing it in array
                            criteriaArray = read.Split(',');
                        }
                        streamReader.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Error while reading the data.", "Invalid", okBtn, exclamationIcon);
                    }

                    //Length of the criteriaA array
                    int count = criteriaArray.Length;

                    if (count >= id)
                    {
                        //Creating a list to store criteria in lowercase
                        List<string> criteriaList = new List<string>();

                        for (int i = 0; i < count; i++)
                        {
                            //Lower casing the data of array and adding it to the list
                            criteriaList.Add(criteriaArray[i].ToLower());
                        }

                        //Checking whether the criteria alreadys exists or not
                        if (criteriaList.Contains(criteriaName.ToLower()))
                        {
                            MessageBox.Show("Criteria already exists.", "Invalid", okBtn, exclamationIcon);
                        }
                        else
                        {
                            //Updating the value of the criteria list
                            criteriaArray[id - 1] = criteriaName;

                            //Joining all the values of the array(criteriaArray)
                            string result = string.Join(",", criteriaArray);

                            try
                            {
                                //Writing the data to the csv file(Criteria list)
                                StreamWriter streamWriter = new StreamWriter(path);

                                using (streamWriter)
                                {
                                    streamWriter.WriteLine(result);
                                    MessageBox.Show("Criteria updated.", "Message");
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Error while writing the data.", "Invalid");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid Id number.", "Invalid");
                    }
                }
            }
        }
        //Check whether the text field is empty or not and combo box is selected or not
        public bool UpdateCheck(String SId, String criteriaName, String serviceName)
        {
            if (SId.Equals("") && serviceName.Equals("") && criteriaName.Equals(""))
            {
                MessageBox.Show("Please fill all the fields.", "Invalid");
            }
            else if (SId.Equals(""))
            {
                MessageBox.Show("Please enter the id number.", "Invalid");
            }
            else if (serviceName.Equals(""))
            {
                MessageBox.Show("Please select the service name.", "Invalid");
            }
            else if (criteriaName.Equals(""))
            {
                MessageBox.Show("Please enter the criteria.", "Invalid");
            }
            else
            {
                return true;
            }
            return false;
        }
        //To delete criteria
        private void DeleteB_Click(object sender, EventArgs e)
        {
            //Getting the text values from the textbox and combo box
            string criteriaName = criteriaNameTB.Text;
            string serviceName = serviceNameCB.Text;

            //Check whether the text field is empty or not and combo box is selected or not
            bool check = DeleteCheck(criteriaName, serviceName);

            if (check.Equals(true))
            {
                if (serviceName.Equals("Service 1"))
                {
                    //Creating list
                    List<string> newCriteria = new List<string>();

                    //Path name of csv file
                    string path = "criteriaservice1.csv";

                    try
                    {
                        //Reading csv file
                        StreamReader streamReader = new StreamReader(path);

                        string read = null;

                        while ((read = streamReader.ReadLine()) != null)
                        {
                            //Splitting the data from the csv file and storing it in array
                            string[] criteriaArray = read.Split(',');

                            //Length of the array
                            int count = criteriaArray.Length;

                            //Creating a list to store criteria in lowercase
                            List<string> criteriaList = new List<string>();

                            for (int i = 0; i < count; i++)
                            {
                                //Lower casing the data of array and adding it to the list
                                criteriaList.Add(criteriaArray[i].ToLower());
                            }
                            //Checking whether the criteria exists or not
                            if (criteriaList.Contains(criteriaName.ToLower()))
                            {
                                for (int i = 0; i < count; i++)
                                {
                                    if (criteriaArray[i] != criteriaName)
                                    {
                                        //Adding the values from array to the list
                                        newCriteria.Add(criteriaArray[i]);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Criteria not found. Please check the spelling.", "Invalid", okBtn, exclamationIcon);
                            }
                        }
                        streamReader.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Error while reading the data.", "Invalid", okBtn, exclamationIcon);
                    }
                    //Length of the list(newCriteria)
                    int newCriteriaCount = newCriteria.Count;

                    if (newCriteriaCount != 0)
                    {
                        //Creating new array to store the final criteria
                        string[] finalCriteria = new string[newCriteriaCount];

                        for (int i = 0; i < newCriteriaCount; i++)
                        {
                            //Adding values from list to the array
                            finalCriteria[i] = newCriteria[i];
                        }
                        //Joining all the values of the array(nCriteria)
                        string result = string.Join(",", finalCriteria);

                        try
                        {
                            //Writing value to the csv file
                            StreamWriter streamWriter = new StreamWriter(path);

                            using (streamWriter)
                            {
                                streamWriter.WriteLine(result);
                                MessageBox.Show("Criteria deleted.", "Message", okBtn, infoIcon);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Error while reading the data.", "Invalid", okBtn, exclamationIcon);
                        }
                    }
                }
                else if (serviceName.Equals("Service 2"))
                {
                    //Creating list
                    List<string> newCriteria = new List<string>();

                    //Path name of csv file
                    string path = "criteriaservice2.csv";

                    try
                    {
                        //Reading csv file
                        StreamReader streamReader = new StreamReader(path);

                        string read = null;

                        while ((read = streamReader.ReadLine()) != null)
                        {
                            //Splitting the data from the csv file and storing it in array
                            string[] criteriaArray = read.Split(',');

                            //Length of the array
                            int count = criteriaArray.Length;

                            //Creating a list to store criteria in lowercase
                            List<string> criteriaList = new List<string>();

                            for (int i = 0; i < count; i++)
                            {
                                //Lower casing the data of array and adding it to the list
                                criteriaList.Add(criteriaArray[i].ToLower());
                            }
                            //Checking whether the criteria exists or not
                            if (criteriaList.Contains(criteriaName.ToLower()))
                            {
                                for (int i = 0; i < count; i++)
                                {
                                    if (criteriaArray[i] != criteriaName)
                                    {
                                        //Adding the values from array to the list
                                        newCriteria.Add(criteriaArray[i]);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Criteria not found. Please check the spelling.", "Invalid", okBtn, exclamationIcon);
                            }
                        }
                        streamReader.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Error while reading the data.", "Invalid", okBtn, exclamationIcon);
                    }
                    //Length of the list(newCriteria)
                    int newCriteriaCount = newCriteria.Count;

                    if (newCriteriaCount != 0)
                    {
                        //Creating new array to store the final criteria
                        string[] finalCriteria = new string[newCriteriaCount];

                        for (int i = 0; i < newCriteriaCount; i++)
                        {
                            //Adding values from list to the array
                            finalCriteria[i] = newCriteria[i];
                        }
                        //Joining all the values of the array(nCriteria)
                        string result = string.Join(",", finalCriteria);

                        try
                        {
                            //Writing value to the csv file
                            StreamWriter streamWriter = new StreamWriter(path);

                            using (streamWriter)
                            {
                                streamWriter.WriteLine(result);
                                MessageBox.Show("Criteria deleted.", "Message", okBtn, infoIcon);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Error while reading the data.", "Invalid", okBtn, exclamationIcon);
                        }
                    }
                }
            }
        }
        //Check whether the text field is empty or not and combo box is selected or not
        public bool DeleteCheck(String criteriaName, String serviceName)
        {
            if (serviceName.Equals("") && criteriaName.Equals(""))
            {
                MessageBox.Show("Please fill all the fields.", "Invalid");
            }
            else if (serviceName.Equals(""))
            {
                MessageBox.Show("Please select the service name.", "Invalid");
            }
            else if (criteriaName.Equals(""))
            {
                MessageBox.Show("Please enter the criteria.", "Invalid");
            }
            else
            {
                return true;
            }
            return false;
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            //Title, message and button of the Messagebox
            string title = "Close Window";
            string message = "Do you want to close this window?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            //Displaying the message box
            DialogResult result = MessageBox.Show(message, title, buttons);

            //Open login form when 'Yes' button is clicked
            if (result == DialogResult.Yes)
            {
                //Creating an object of the LoginAg form
                StaffLogin loginAG = new StaffLogin();
                //Displays LoginAG form
                loginAG.Show();
                //Hides this form
                Hide();
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            //Setting the combo box's item to null
            serviceNameCB.SelectedItem = null;
            serviceUCB.SelectedItem = null;

            //Clears the text of the textboxes
            criteriaNameTB.Clear();
            idTB.Clear();
            criteriaUTB.Clear();
        }
    }
}
