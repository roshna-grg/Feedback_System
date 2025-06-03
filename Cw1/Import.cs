using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Cw1
{
    public partial class Import : Form
    {
        //MessageBox button
        MessageBoxButtons okBtn = MessageBoxButtons.OK;

        //MessageBox icons
        MessageBoxIcon exclamationIcon = MessageBoxIcon.Exclamation;
        MessageBoxIcon infoIcon = MessageBoxIcon.Information;

        public Import()
        {
            InitializeComponent();
        }
        private void UploadBtn_Click(object sender, EventArgs e)
        {
            //Displays dialog box
            openFileDialog.ShowDialog();

            //Path of the file
            string pathName = openFileDialog.FileName;

            //Getting the name of the file
            string filename = Path.GetFileName(pathName);

            //Getting the extension of the file
            string fileExtension = Path.GetExtension(pathName);

            if (filename.Equals("customerdetails1.csv"))
            {
                MessageBox.Show("Please select other file.", "Invalid", okBtn, exclamationIcon);
            }
            else if (filename.Equals("customerdetails2.csv"))
            {
                MessageBox.Show("Please select other file.", "Invalid", okBtn, exclamationIcon);
            }
            else if(fileExtension.Equals(".csv"))
            {
                //Calling the method
                UploadBulk(pathName);
            }
            else
            {
                MessageBox.Show("Please select other file.", "Invalid", okBtn, exclamationIcon);
            }
        }
        public void UploadBulk(string bulkFilePath)
        {
            try
            {
                //Reading all the lines of the bulk data file
                string[] bulkLines = File.ReadAllLines(bulkFilePath);

                //Splitting the array and storing the splitted data in the new array
                string[] serviceLine = bulkLines[1].Split(',');

                if (serviceLine[0].Equals("Service 1") || serviceLine[0].Equals("Service 2"))
                {
                    if (bulkLines.Length > 0)
                    {
                        for (int i = 0; i < bulkLines.Length - 1; i++)
                        {
                            //Initializing the list for service 1 and service 2 respectively
                            //to store the data from bulk csv file
                            List<string> dataS1 = new List<string>();
                            List<string> dataS2 = new List<string>();

                            //Splitting the array and storing the splitted data in the new array
                            string[] bulkData = bulkLines[i + 1].Split(',');

                            //Length of the array
                            int bulkDataCount = bulkData.Length;

                            if (bulkData[0].Equals("Service 1"))
                            {
                                for (int a = 0; a < bulkDataCount; a++)
                                {
                                    //Adding the bulk data to the list of service 1
                                    dataS1.Add(bulkData[a]);
                                }
                                
                                string[] finalDataS1 = new String[bulkDataCount];

                                for (int s = 0; s < bulkDataCount; s++)
                                {
                                    //Adding data from list to the array
                                    finalDataS1[s] = dataS1[s];
                                }
                                //Joining all the data of the array
                                string result = string.Join(",", finalDataS1);

                                try
                                {
                                    string pathName = "customerdetails1.csv";

                                    //Writing the data to the csv file(customerdetails1.csv)
                                    StreamWriter streamWriter = new StreamWriter(pathName, true);

                                    using (streamWriter)
                                    {
                                        streamWriter.WriteLine(result);
                                    }
                                    streamWriter.Close();
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Error while writing the data.", "Invalid", okBtn, exclamationIcon);
                                }
                            }
                            else
                            {
                                for (int a = 0; a < bulkDataCount; a++)
                                {
                                    //Adding the bulk data to the list of service 2
                                    dataS2.Add(bulkData[a]);
                                }
                                string[] finalDataS2 = new String[bulkDataCount];

                                for (int s = 0; s < bulkDataCount; s++)
                                {
                                    //Adding data from list to the array
                                    finalDataS2[s] = dataS2[s];
                                }
                                //Joining all the data of the array
                                string result = string.Join(",", finalDataS2);

                                try
                                {
                                    string pathName = "customerdetails2.csv";

                                    //Writing the data to the csv file(customerdetails2.csv)
                                    StreamWriter streamWriter = new StreamWriter(pathName, true);

                                    using (streamWriter)
                                    {
                                        streamWriter.WriteLine(result);
                                    }
                                    streamWriter.Close();
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Error while writing the data.", "Invalid", okBtn, exclamationIcon);
                                }
                            }
                        }
                        uploadTB.Text = bulkFilePath;
                        MessageBox.Show("Successfully imported", "Message", okBtn, infoIcon);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid file. Please check the file again.", "Invalid", okBtn, exclamationIcon);
                }
            }
            catch
            {
                MessageBox.Show("Error while importing.", "Invalid", okBtn, exclamationIcon);
            }
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            //Clears the text box
            uploadTB.Text = "";
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
                //Creating an object of the General form
                General general = new General();
                //Displays General View Form
                general.Show();
                //Hides this form
                Hide();
            }
        }
    }
}
