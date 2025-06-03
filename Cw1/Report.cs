using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace Cw1
{
    public partial class Report : Form
    {
        //MessageBox button
        MessageBoxButtons okBtn = MessageBoxButtons.OK;

        //MessageBox icon
        MessageBoxIcon exclamationIcon = MessageBoxIcon.Exclamation;

        //Creating object of DataTable class
        
        public Report()
        {
            InitializeComponent();

            //Disabling the chart button
            chartB.Enabled = false;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display dialog box
            openFileDialog.ShowDialog();

            //Path of the customer details file
            string pathName = openFileDialog.FileName;

            //Getting the name of the file
            string filename = Path.GetFileName(pathName);

            //Initializing the variable for criteria path
            string criteriaPath= null;

            if (pathName != "")
            {
                if (filename.Equals("customerdetails1.csv"))
                {
                    //Declaring the criteria path
                    criteriaPath = "criteriaservice1.csv";
                }
                else if (filename.Equals("customerdetails2.csv"))
                {
                    //Declaring the criteria path
                    criteriaPath = "criteriaservice2.csv";
                }

                //Clearing the chart
                chart1.Series.Clear();
                chart1.Titles[0].Text = "";

                DataTableGV(pathName, criteriaPath);
            }
        }
        private void DataTableGV(string detailsPath, string criteria_Path)
        {
            try 
            {
                DataTable data = new DataTable();

                //Reading all the lines from customer details csv file and storing the data in array
                string[] custDetails = File.ReadAllLines(detailsPath);

                //Reading all the lines from crtieria csv file and storing the data in array
                string[] criteriaArray = File.ReadAllLines(criteria_Path);

                string criteria = criteriaArray[0];

                //Splitting the data and storing it in the array
                string[] criteriaSplit = criteria.Split(',');

                List<string> allCriteria = new List<string>();
                allCriteria.Add("Date");
                allCriteria.Add("Time");

                for(int i =0; i<criteriaSplit.Length; i++)
                {
                    allCriteria.Add(criteriaSplit[i]);
                }

                //Initializing the list
                List<string> newCustData = new List<string>();

                if (custDetails.Length > 0)
                {
                    //Table header
                    foreach (string header in allCriteria)
                    {
                        //Adding the criteria as the header of the grid table
                        data.Columns.Add(new DataColumn(header));
                    }

                    //Table data
                    for (int i = 0; i < custDetails.Length; i++)
                    {
                        //Splitting the data and storing it in the array
                        string[] customerData = custDetails[i].Split(',');

                        //Length of the customerData array
                        int custDataCount = customerData.Length;

                        for (int j = 0; j < custDataCount; j++)
                        {
                            //Adding data from array to list
                            newCustData.Add(customerData[j]);
                        }
                        //Initializing the table's row
                        DataRow dataRow = data.NewRow();

                        //Adding the data in the table from 7 index of the array
                        int columnIndex = 5;

                        foreach (string criteriaData in allCriteria)
                        {
                            try
                            {
                                dataRow[criteriaData] = customerData[columnIndex++];
                            }
                            catch
                            {
                                dataRow[criteriaData] = 0;
                                columnIndex++;
                            }
                        }
                        //Adding the rows in the table
                        data.Rows.Add(dataRow);
                    }
                }
                if (data.Rows.Count > 0)
                {
                    //Giving the source of the grid table
                    tableGV.DataSource = data;
                }
                else
                {
                    MessageBox.Show("The csv file is empty", "Invalid", okBtn, exclamationIcon);
                }
                //Declaring the variables
                string service = newCustData[0];

                //Setting the variables to the text fields
                serviceNameTB.Text = service;

                //Enabling the chart button
                chartB.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("File cannot be opened. Please choose csv file.", "Invalid", okBtn, exclamationIcon);
            }
        }
        private void ChartB_Click(object sender, EventArgs e)
        {
            try
            {
                //Clearing the series
                chart1.Series.Clear();

                //Chart series name
                string seriesname = "Series1";

                //Length of the row and column of the table
                int colCount = tableGV.Columns.Count;
                int rowCount = tableGV.Rows.Count;

                //Initializing list to store header names from the table
                List<string> headerNames = new List<string>();

                //Initializing list to store total values of the criteria ratings
                List<int> totalValues = new List<int>();

                for (int i = 2; i < colCount; i++)
                {
                    //Adding the header text of the table in the array(columnNames)
                    headerNames.Add(tableGV.Columns[i].HeaderText);

                    //Declaring the variable to store the total value of individual criteria
                    int individualTotal = 0;

                    for (int j = 0; j < rowCount; j++)
                    {
                        try
                        {
                            //Adding the rating of individual rows
                            individualTotal += Convert.ToInt16(tableGV.Rows[j].Cells[i].Value);
                        }
                        catch
                        {
                            //If the cell is empty, adding 0
                            individualTotal += 0;
                        }
                    }
                    //adding the result (individualTotal) to the list
                    totalValues.Add(individualTotal);
                }
                //Declaring the variable
                decimal totalsum = 0;

                //Adding all the ratings of all criteria
                for (int i = 0; i < colCount - 2; i++)
                {
                    totalsum += totalValues[i];
                }

                //Setting the series name, chart type and points
                chart1.Series.Add(seriesname);
                chart1.Series[seriesname].ChartType = SeriesChartType.Pie;
                chart1.Series[seriesname].Points.DataBindY(totalValues);

                //Initializing the list to store the percentage of individual criteria
                List<decimal> percentList = new List<decimal>();

                for (int i = 0; i < headerNames.Count; i++)
                {
                    //Calculating the percentage
                    decimal percent = (totalValues[i] / totalsum) * 100;

                    //Round off the decimal
                    decimal finalPercent = decimal.Round(percent, 2, MidpointRounding.AwayFromZero);
                    //Adding the result (finalPercent) to the list
                    percentList.Add(finalPercent);
                }
                //Length of the list
                int count = percentList.Count;

                //declaring the variables for bubble sorting
                decimal temp;
                string criteriaTemp;

                //Sorting the percentage in decreasing order with its respective crtieria name
                for (int i = 0; i < count; i++)
                {
                    for (int j = 0; j < count - 1; j++)
                    {
                        if (percentList[j] < percentList[j + 1])
                        {
                            //Storing the data of the array in the declared variable for a while
                            temp = percentList[j];
                            //Swapping the data
                            percentList[j] = percentList[j + 1];
                            percentList[j + 1] = temp;

                            //Storing the data of the array in the declared variable for a while
                            criteriaTemp = headerNames[j];
                            //Swapping the data
                            headerNames[j] = headerNames[j + 1];
                            headerNames[j + 1] = criteriaTemp;
                        }
                    }
                }

                for (int i = 0; i < headerNames.Count; i++)
                {
                    //Setting the label name
                    chart1.Series[seriesname].Points[i].Label = percentList[i] + @"%";
                    //Adding legend items
                    chart1.Series[seriesname].Points[i].LegendText = headerNames[i];
                }

                //Setting the chart title
                chart1.Titles[0].Text = serviceNameTB.Text;
                chart1.Titles[0].Alignment = ContentAlignment.TopLeft;
            }
            catch
            {
                MessageBox.Show("No data in the table", "Invalid", okBtn, exclamationIcon);
            }
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Title, message and button of the Messagebox
            string title = "Close Window";
            string message = "Do you want to close this window?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            //Displaying the message box
            DialogResult result = MessageBox.Show(message, title, buttons);

            //When 'Yes' button is clicked
            if (result == DialogResult.Yes)
            {
                //Creating an object of the General from
                General general = new General();
                //Displays LoginAG form
                general.Show();
                //Hides this form
                Hide();
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DateTime.Compare(dateFromP.Value.Date, dateToP.Value.Date) > 0)
                {
                    MessageBox.Show("Please select valid date");

                    dateFromP.Focus();
                    return;
                }
                DataTable dataTable = (DataTable)tableGV.DataSource;
                DataView dataView = new DataView();
                dataView = dataTable.DefaultView;

                //filtering the table according to date
                dataView.RowFilter = String.Format("Date >= '{0:dd / MM / yyyy}' AND Date <= '{1:dd / MM / yyyy}'", dateFromP.Value, dateToP.Value);
            }
            catch
            {
                MessageBox.Show("Please open file first.", "Invalid", okBtn, exclamationIcon);
            }
        }
    }
}
