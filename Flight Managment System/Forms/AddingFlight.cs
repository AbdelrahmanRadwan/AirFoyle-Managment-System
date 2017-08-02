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
    // Adding Flight Class
    public partial class AddingFlight : Form
    {
        // Attributes ..
        private Flight TobeAddedFlight;
        private FileStream MainStream;
        private StreamWriter MainWriter;
        // Constructor 
        public AddingFlight()
        {
            TobeAddedFlight = new Flight();
            InitializeComponent();
        }

        // On load
        private void Addingflight_Load(object sender, EventArgs e)
        {
            FlightNoLeftCharsLabel.Text = TobeAddedFlight.GetFlightNumberSize().ToString();
            DestinationLeftCharsLabel.Text = TobeAddedFlight.GetDestinationSize().ToString();
        }

        // Clear all fields 
        private void ClearFields_Click(object sender, EventArgs e)
        {
            // Assigning empty spaces to the fields 
            FlightNumber.Text = "";
            Destination.Text = "";
        }

        // Submit button
        private void AddingDataSubmit_Click(object sender, EventArgs e)
        {
            TobeAddedFlight.SetFlightNumber(FlightNumber.Text);
            TobeAddedFlight.SetDestination(Destination.Text);
            TobeAddedFlight.SetArrivalDate(MainTimePicker.Value.ToString("yyyy-MM-dd")); // date format 

            if (File.Exists("Files/FirstFlights" + AdvancedConfigurations.SystemIdText.ToString() + ".txt"))
            {
                MainStream = new FileStream("Files/FirstFlights" + AdvancedConfigurations.SystemIdText.ToString() + ".txt", FileMode.Open, FileAccess.ReadWrite);
                MainWriter = new StreamWriter(MainStream);
                StreamReader MainReader = new StreamReader(MainStream);

                int offset;
                int head;

                MainWriter.BaseStream.Seek(0, SeekOrigin.Begin);

                head = MainReader.BaseStream.ReadByte();

                if (head == 0)
                {
                    offset = (int)MainWriter.BaseStream.Length;
                    MainWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
                    MainWriter.Write(new string(TobeAddedFlight.GetFlightNumber()) + new string(TobeAddedFlight.GetDestination()) + new string(TobeAddedFlight.GetArrivalDate()) + "#");
                }
                
                else
                {
                    offset = (head-1) * (31) + 1;
                    MainWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
                    char[] c = new char[5];
                    MainReader.Read(c, 0, 5);

                    string lo = new string(c);
                    string[] lp = lo.Split(new char[] { '*', '|' });
                    MainWriter.Flush();

                    MainReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    int newhead = int.Parse(lp[1]);

                    MainWriter.BaseStream.WriteByte((byte)newhead);
                    MainWriter.Flush();

                    MainWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
                    MainWriter.Write(new string(TobeAddedFlight.GetFlightNumber()) + new string(TobeAddedFlight.GetDestination()) + new string(TobeAddedFlight.GetArrivalDate()) + "#");
                }

                MainWriter.Close(); // Closing the flights file 
            }

            else
            {
                MainStream = new FileStream("Files/FirstFlights" + AdvancedConfigurations.SystemIdText.ToString() + ".txt", FileMode.Create);
                MainWriter = new StreamWriter(MainStream);
                MainWriter.BaseStream.WriteByte((byte)0);                
                MainWriter.Write(new string(TobeAddedFlight.GetFlightNumber()) + new string(TobeAddedFlight.GetDestination()) + new string(TobeAddedFlight.GetArrivalDate()) + "#");
                MainStream.Close();
            }

            this.Close(); // closing the form
        }
            
        // On Change (Flight Number) .. this is made to hinder the user to not to add more than the flightno size 
        private void FlightNumber_TextChanged(object sender, EventArgs e)
        {
            FlightNoLeftCharsLabel.Text = (TobeAddedFlight.GetFlightNumberSize() - FlightNumber.Text.Length).ToString();

            if (FlightNumber.Text.Length > TobeAddedFlight.GetFlightNumberSize())
            {
                MessageBox.Show("This is NOT allowed, flight number can't exeed " + TobeAddedFlight.GetFlightNumberSize().ToString() + " characters!");
                FlightNumber.Text = "";
            }
        }

        // On Change (Destination) .. this is made to hinder the user to not to add more than the Destination size
        private void Destination_TextChanged(object sender, EventArgs e)
        {
            DestinationLeftCharsLabel.Text = (TobeAddedFlight.GetDestinationSize() - Destination.Text.Length).ToString();

            if (Destination.Text.Length > TobeAddedFlight.GetDestinationSize())
            {
                MessageBox.Show("This is NOT allowed, destination number can't exeed " + TobeAddedFlight.GetDestinationSize().ToString() + " characters!");
                Destination.Text = "";
            }
        }
    } // End of Adding Flights Class
}