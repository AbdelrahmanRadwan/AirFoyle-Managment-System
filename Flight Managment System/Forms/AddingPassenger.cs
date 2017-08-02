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
    // Adding passengers class
    public partial class AddingPasseenger : Form
    {
        // Attributes 
        private Passenger TobeAddedPassenger;
        private FileStream MainStream;
        private StreamWriter MainWriter;
        private StreamReader MainReader;

        // Constructor 
        public AddingPasseenger()
        {
            InitializeComponent();
            TobeAddedPassenger = new Passenger();
        }

        // Clearing all fields ..
        private void ClearFields_Click(object sender, EventArgs e)
        {
            PassengerName.Text = "";
            Phone.Text = "";
        }

        // Submit Button
        private void AddingDataSubmit_Click(object sender, EventArgs e)
        {
            int head;
            // Setting the passenger's data
            TobeAddedPassenger.SetPassengerName(PassengerName.Text);
            TobeAddedPassenger.SetPassengerPhone(Phone.Text);
            TobeAddedPassenger.SetPassengerFlightNo(AvailableFlights.Text);

            if (File.Exists("Files/Passengers" + AdvancedConfigurations.SystemIdText.ToString() + ".txt"))
            {
                MainStream = new FileStream("Files/Passengers" + AdvancedConfigurations.SystemIdText.ToString() + ".txt", FileMode.Open, FileAccess.ReadWrite);
                MainWriter = new StreamWriter(MainStream);
                MainReader = new StreamReader(MainStream);

                string Temprecord = TobeAddedPassenger.GetPassengerName() + "@" + TobeAddedPassenger.GetPassengerPhone() + "@" + TobeAddedPassenger.GetPassengerFlightNo();
                char[] Tobewritten = new char[52];
                
                Temprecord.ToCharArray().CopyTo(Tobewritten, 0);
                
                int offset = 0;

                head = MainReader.BaseStream.ReadByte();

                if (head == 0)
                {
                    offset = (int)MainWriter.BaseStream.Length;
                    MainWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
                    MainWriter.Write(Tobewritten);
                }

                else
                {
                    offset = ((head - 1) * 52) + 1;
                    MainWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
                    char[] t = new char[5];
                    MainReader.Read(t, 0, 5);
                    string l = new string(t);
                    string[] lp = l.Split(new char[] { '*', '|' });
                    MainWriter.Flush();

                    MainWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                    int newhead = int.Parse(lp[1]);
                    MainWriter.BaseStream.WriteByte((byte)newhead);

                    MainWriter.Flush();
                    MainWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
                    MainWriter.Write(Tobewritten);
                }
                MainWriter.Close();

            }
            else
            {
                MainStream = new FileStream("Files/Passengers" + AdvancedConfigurations.SystemIdText + ".txt" , FileMode.Append);
                MainStream.WriteByte((byte)0);
                MainStream.Close();
            }

            this.Close();
        }

        // OnLoad 
        private void AddingData_Load(object sender, EventArgs e)
        {
            // Setting the drop-down menu style 
            AvailableFlights.DropDownStyle = ComboBoxStyle.DropDown; 
            // checks if the file exists or not ..
            if (File.Exists("Files/FirstFlights" + AdvancedConfigurations.SystemIdText.ToString() + ".txt"))
            {
                MainStream = new FileStream("Files/FirstFlights" + AdvancedConfigurations.SystemIdText.ToString() + ".txt", FileMode.Open);
                MainReader = new StreamReader(MainStream);

                char[] TempFlightRecord = new char[31]; // fixed length record 
                string TempRecord;
                int i = 0;
                MainReader.BaseStream.Seek(1, SeekOrigin.Begin);
                while (MainReader.Peek() != -1)
                {
                    MainReader.Read(TempFlightRecord, 0 , 31); // reading a record 

                    if (TempFlightRecord[0] == '*') continue; // Skipping a record with an astrisk
                    
                    TempRecord = new string(TempFlightRecord);
                    AvailableFlights.Items.Add(TempRecord.Substring(0, 5)); // adding a flight no each time 
                    i++;
                }
                MainReader.Close(); // closing the flights file
                AvailableFlights.Sorted = true; // sorting the flights numbers 
            }
            
            if (AvailableFlights.Items.Count == 0)
            {
                MessageBox.Show("There is NO Registred Flights!");
            }   
        }

        // OnChange (if passenger name + Passenger phone exeed 50 -> object him )
        private void PassengerName_TextChanged(object sender, EventArgs e)
        {
            if (PassengerName.Text.Length + Phone.Text.Length > 50)
            {
                MessageBox.Show("Passenger Name and Phone can't exeed 50 character!");
                PassengerName.Text = "";
            }
        }

        // OnChange (if passenger name + Passenger phone exeed 50 -> object him )        
        private void Phone_TextChanged(object sender, EventArgs e)
        {
            if (PassengerName.Text.Length + Phone.Text.Length > 50)
            {
                MessageBox.Show("Passenger Name and Phone can't exeed 50 character!");
                Phone.Text = "";
            }
        }
    } // End of Adding Passenger Class
}