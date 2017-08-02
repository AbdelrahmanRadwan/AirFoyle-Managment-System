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
using Flight_Managment_System.Forms;
namespace Flight_Managment_System
{
    // Main Form 
    public partial class Main : Form
    {
        // Class Attributes 
        FileUploader MainUploader;
        FileStream MainStream;
        StreamReader MainReader;
        // Constructor
        public Main()
        {
            InitializeComponent();
            MainUploader = new FileUploader();
        }

        // A functoion for assigning the tool tips in the main form
        private void AssignToolTips()
        {
            // Create the ToolTip and associate with the Form container.
            ToolTip Tipper = new ToolTip();
            // Set up the delays for the ToolTip.
            Tipper.AutoPopDelay = 10000;
            Tipper.InitialDelay = 5;
            Tipper.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            Tipper.ShowAlways = true;
            // Set up the ToolTip text for the Button and Checkbox.
            Tipper.SetToolTip(this.AddPassengerBTN, "Add a passenger"); // add-passenger-icon
            Tipper.SetToolTip(this.AddFlightBTN, "Add a flight"); // add-passenger-icon
            Tipper.SetToolTip(this.ConfigBTN, "Advanced configurations"); // config-icon
            Tipper.SetToolTip(this.ServerLoggingBTN, "Change server logging data"); // server-icon
            Tipper.SetToolTip(this.DeleteFlightBTN, "Delete a flight"); // delete-flight-icon
            Tipper.SetToolTip(this.RefreshBTN, "Refresh panel's data"); // refresh-icon
            Tipper.SetToolTip(this.SycnBTN, "Manual Sycn"); // sycn-icon
        }

        // A function for assigning the data into the grid view control
        private void ViewFlights(){
            Flight toBeViewed = new Flight();
            // Checks if the file exists or not .. 
            if (File.Exists("Files/FirstFlights" + AdvancedConfigurations.SystemIdText.ToString() + ".txt"))
            {
                MainStream = new FileStream("Files/FirstFlights" + AdvancedConfigurations.SystemIdText.ToString() + ".txt", FileMode.Open);
                MainReader = new StreamReader(MainStream);
                
                char[] Temp = new char[31]; // Flight record length
                string tempRecord; // temp string to hold each record at a time 
                int Index = 0; // a counter for accsessing the rows of the grid
                MainReader.BaseStream.Seek(1, SeekOrigin.Begin);                
                
                while (MainReader.Peek() != -1)
                {
                    toBeViewed = new Flight();
                    // Adding row to the grid
                    // reading 31 char in the buffer
                    MainReader.Read(Temp, 0, 31);
                    tempRecord = new string(Temp);

                    if (tempRecord[0] == '*') continue;

                    int n = RegistredFlights.Rows.Add(); // adds a row

                    // Assigning data to the object ..
                    toBeViewed.SetFlightNumber(tempRecord.Substring(0, 5));
                    toBeViewed.SetDestination(tempRecord.Substring(5, 15));
                    toBeViewed.SetArrivalDate(tempRecord.Substring(20, 10));
                    // Assigining the data to the grid .. getting it from the object 
                    RegistredFlights.Rows[Index].Cells[0].Value = new string (toBeViewed.GetFlightNumber());
                    RegistredFlights.Rows[Index].Cells[1].Value = new string (toBeViewed.GetDestination());
                    RegistredFlights.Rows[Index].Cells[2].Value = new string (toBeViewed.GetArrivalDate());
                    Index++;
                }
                MainReader.Close(); // Closing the Flights File
            }
        }

        // A function for assiging the passengers to the grid-view control
        private void ViewPassengers()
        {
            // Checks if the file exists or not ..
            if (File.Exists("Files/Passengers" + AdvancedConfigurations.SystemIdText.ToString() + ".txt"))
            {
                Passenger toBeViewed = new Passenger();
                MainStream = new FileStream("Files/Passengers" + AdvancedConfigurations.SystemIdText.ToString() + ".txt", FileMode.Open);
                MainReader = new StreamReader(MainStream);
                string[] Tokens; // an array of string to hold the tokens 
                int Index = 0; // a counter for accsessing the grid view
                char[] TempRecord = new char[52];
                string TempRecordString = "";
                MainReader.BaseStream.Seek(1, SeekOrigin.Begin);
                
                while (MainReader.Peek() != -1)
                {
                    toBeViewed = new Passenger();
                    MainReader.Read(TempRecord, 0, 52);
                    TempRecordString = new string(TempRecord);

                    if (TempRecordString[0] == '*') continue;

                    int n = RegistredPassengers.Rows.Add(); // adding a row

                    Tokens = TempRecordString.Split('@'); // splitting the fields
                    // Assiging the data to the object .. 

                    toBeViewed.SetPassengerName(Tokens[0]);
                    toBeViewed.SetPassengerPhone(Tokens[1]);
                    toBeViewed.SetPassengerFlightNo(Tokens[2]);
                    
                    // getting the data from the object ..
                    RegistredPassengers.Rows[Index].Cells[0].Value = toBeViewed.GetPassengerName();
                    RegistredPassengers.Rows[Index].Cells[1].Value = toBeViewed.GetPassengerPhone();
                    RegistredPassengers.Rows[Index].Cells[2].Value = toBeViewed.GetPassengerFlightNo().Replace("\0" , string.Empty);
                    RegistredPassengers.Rows[Index].Cells[2].Value = toBeViewed.GetPassengerFlightNo().Replace(" ", string.Empty);                       
                    Index++;
                }

                MainReader.Close(); // Closing the Passengers File
            }
        }

        // OnLoad 
        private void Main_Load(object sender, EventArgs e)
        {
            // Checks the internet connection
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                SycnBTN.BackgroundImage = (((System.Drawing.Image)(Properties.Resources.Cloud_syncon)));
            }

            // Loading the configurations to get the system ID 
            AdvancedConfigurations Temp = new AdvancedConfigurations();

            Temp.Show();
            Temp.Visible = false;

            // Assigning the passengers to the grid
            ViewPassengers();
            // Assigining the flights to the grid
            ViewFlights();
            // Assigining the tooltips for the icon-buttons
            AssignToolTips();
            // writing the system ID to the caption of the form 
            this.Text += " (System ID : " + AdvancedConfigurations.SystemIdText.ToString() + ")";
        }

        // Adding a passenger
        private void AddPassengerBTN_Click(object sender, EventArgs e)
        {
            AddingPasseenger Temp = new AddingPasseenger();
            Temp.Show();
        }

        // Sycn Button
        private void SycnBTN_Click(object sender, EventArgs e)
        {
            // Checks the internet Connection
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                try
                {
                    // Uploading the Flights file .. 
                    MainUploader.UploadFile("Files/FirstFlights" + AdvancedConfigurations.SystemIdText.ToString() + ".txt", "ftp://abh.site90.com/public_html", "a3147731", "ao.helal");
                    // Uploading the Passengers file ..
                    MainUploader.UploadFile("Files/Passengers" + AdvancedConfigurations.SystemIdText.ToString() + ".txt", "ftp://abh.site90.com/public_html", "a3147731", "ao.helal");
                    MainReader.Close();
                    MessageBox.Show("Files were updated on the server succsesfully");
                }

                catch
                {
                    // Logging errors, Limited internet errors, anything related to the server errors
                    MessageBox.Show("An Error has been just ocurred, validate your log-in data!");
                }
            }

            else
            {
                MessageBox.Show("There is no Internet Connection!");
            }
        }

        // Changing Logging Data
        private void ServerDataBTN_Click(object sender, EventArgs e)
        {
            ChangingServerData Temp = new ChangingServerData();
            Temp.Show();
        }

        // Advanced Configurations Button
        private void SystemConfigBTN_Click(object sender, EventArgs e)
        {
            AdvancedConfigurations Temp = new AdvancedConfigurations();
            Temp.Show();
        }

        // Form Refresh Button
        private void RefreshBTN_Click(object sender, EventArgs e)
        {
            // Clearing the old Passengers grid 
            RegistredPassengers.Rows.Clear();
            // Clearing the old Flights frid
            RegistredFlights.Rows.Clear();
            // Assigning the new Passengers to the grid 
            ViewPassengers();
            // Assigning the new Flights to the grid 
            ViewFlights();
        }

        // Add Flight Button
        private void AddFlightBTN_Click(object sender, EventArgs e)
        {
            AddingFlight Temp = new AddingFlight();
            Temp.Show();
        }

        // Search Button
        private void SearchBTN_Click(object sender, EventArgs e)
        {
            if (SearchByDropDown.Text == "Destination")
            {
                Search_By_Destination Temp = new Search_By_Destination();
                Temp.Show();
            }
            else if (SearchByDropDown.Text == "Flight and Arrival Date")
            {
                FlightSearch Temp = new FlightSearch();
                Temp.Show();
            }
            else
            {
                MessageBox.Show("Choose a search mode!");
            }
        }

        private void DeleteFlightBTN_Click(object sender, EventArgs e)
        {
            DeleteFlightAndPassengers Temp = new DeleteFlightAndPassengers();
            Temp.Show();
        }

        
    } // End of Main Form
}