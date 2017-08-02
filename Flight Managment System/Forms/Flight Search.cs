using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Flight_Managment_System
{
    public partial class FlightSearch : Form
    {
        // Is the Search button has been clicked or not
        bool IsClicked = false;
        // Constructor
        public FlightSearch()
        {
            InitializeComponent();
        }

        // A function to search the file for the Flight number and the Arrival Date
        private bool SearchInFile(string FlightNo, string ArrivalDate)
        {
            int Index = 0; // an index to the data grid view control 
            bool Pass1 = false;
            bool Pass2 = false;
            FileStream MainStream;
            StreamReader MainReader;
            // Checking if the flights file exists or not ..
            if (File.Exists("Files/FirstFlights" + AdvancedConfigurations.SystemIdText.ToString() + ".txt"))
            {
                Flight tobeVerified = new Flight();
                MainStream = new FileStream("Files/FirstFlights" + AdvancedConfigurations.SystemIdText.ToString() + ".txt", FileMode.Open);
                MainReader = new StreamReader(MainStream);
                MainReader.BaseStream.Seek(1, SeekOrigin.Begin);
                while (MainReader.Peek() != -1)
                {
                    tobeVerified = new Flight();
                    char[] temp = new char[31]; // temp flight record 
                    MainReader.Read(temp, 0, 31); // reading the record from the file
                    string tempText = new string(temp);

                    string tempFlight = tempText.Substring(0, 5);
                    tempFlight = tempFlight.Replace(" ", string.Empty); // removing any spaces (if any)
                    tempFlight = tempFlight.Replace("\0", string.Empty); // removing any NULL chars (if any)

                    string tempDate = tempText.Substring(20, 10);
                    tempDate = tempDate.Replace(" ", string.Empty); // removing any spaces (if any)
                    tempDate = tempDate.Replace("\0", string.Empty); // removing any NULL chars (if any)

                    tobeVerified.SetFlightNumber(tempFlight); // Assigning the data to the object 
                    tobeVerified.SetArrivalDate(tempDate); // Assiging the data to the object 

                    if (FlightNo == new string(tobeVerified.GetFlightNumber()) && ArrivalDate == new string(tobeVerified.GetArrivalDate()))
                    {
                        Pass1 = true;
                    }
                }
                MainReader.Close();
            }

            if (Pass1 == false) return false; // if the flight number and the date didn't match.

            else
            {
                // Checks if the file exists or not ..
                Passenger tobeViewed = new Passenger();
                if (File.Exists("Files/FirstFlights" + AdvancedConfigurations.SystemIdText.ToString() + ".txt"))
                {
                    MainStream = new FileStream("Files/Passengers" + AdvancedConfigurations.SystemIdText.ToString() + ".txt", FileMode.Open);
                    MainReader = new StreamReader(MainStream);
                    MainReader.BaseStream.Seek(1, SeekOrigin.Begin);                    
                    char[] tempRecord = new char[52]; // +2 for the delimeters
                    string TempStringRecord = "";
                    while (MainReader.Peek() != -1)
                    {
                        MainReader.Read(tempRecord , 0 , 52);
                        TempStringRecord = new string(tempRecord);

                        if (TempStringRecord[0] == '*') continue;

                        string[] tokens = TempStringRecord.Split('@'); // splitting the record

                        tokens[2] = tokens[2].Replace(" ", string.Empty); // removing any spaces (if any)
                        tokens[2] = tokens[2].Replace("\0", string.Empty); // removing any NULL chars (if any)

                        tobeViewed.SetPassengerName(tokens[0]); // assigning the data to the object
                        tobeViewed.SetPassengerPhone(tokens[1]); // assigning the data to the object
                        tobeViewed.SetPassengerFlightNo(tokens[2]); // assigning the data to the object
                        
                        if (FlightNo == tobeViewed.GetPassengerFlightNo())
                        {
                            int n = dataGridView1.Rows.Add(); // adding a row
                            dataGridView1.Rows[Index].Cells[0].Value = tobeViewed.GetPassengerName();
                            dataGridView1.Rows[Index].Cells[1].Value = tobeViewed.GetPassengerPhone();
                            Index++;
                            Pass2 = true;
                        }
                    }
                    MainReader.Close(); // Closing the Passengers File
                }
            }

            if (Pass1 && Pass2) return true;
            else return false;
        }

        // The Search Button
        private void SearchBTN_Click(object sender, EventArgs e)
        {
            if (!IsClicked)
            {
                if (SearchInFile(SearchKey.Text, Date.Value.ToString("yyyy-MM-dd")))
                {
                    this.Height += 300; // increasing the height to get the grid
                    this.Options.Height += 300; // increasing the height to get the grid
                    this.Top = 200; // increasing the Padding to get the grid
                    IsClicked = true;
                }

                else
                {
                    MessageBox.Show("No results.");
                }
            }
        }
    } // End of Flights Search
}