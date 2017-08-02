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
    // Destination search class
    public partial class Search_By_Destination : Form
    {
        bool IsClicked = false; // if the search button clicked or not ..

        // Constructor
        public Search_By_Destination()
        {
            InitializeComponent();
        }

        // A function to search the file for the flight destination 
        private bool SearchInFile(string SearchKey){
            int Index = 0; // An index for accsessing the grid view 
            // checks if the file exists or not ..
            if (File.Exists("Files/FirstFlights" + AdvancedConfigurations.SystemIdText.ToString() + ".txt")){
               FileStream MainStream = new FileStream("Files/FirstFlights" + AdvancedConfigurations.SystemIdText.ToString() + ".txt", FileMode.Open);
               StreamReader MainReader = new StreamReader(MainStream);
               MainReader.BaseStream.Seek(1, SeekOrigin.Begin);               
                while (MainReader.Peek() != -1)
               {
                   char[] tempRecord = new char[31]; // Fixed length record 
                   MainReader.Read(tempRecord, 0, 31); // reading a record int 
                   string temp = new string(tempRecord);

                   if (temp[0] == '*') continue;

                   string tempDestination = temp.Substring(5, 15); // destination to be searched 

                   tempDestination = tempDestination.Replace(" ", string.Empty); // removing any spaces (if any) 
                   tempDestination = tempDestination.Replace("\0", string.Empty); // removing any NULL chars (if any)
                   
                   if (tempDestination == SearchKey)
                   {
                       int n = dataGridView1.Rows.Add(); // adding a row into the datagrid
                       dataGridView1.Rows[Index].Cells[0].Value = temp.Substring(0, 5); // flight number
                       dataGridView1.Rows[Index].Cells[1].Value = temp.Substring(20, 10); // flight arrival date
                       Index++;
                   }
               }
               MainReader.Close(); // Closing the flights file
            }

           if (Index == 0) return false;
           else return true;
        }

        // Search button
        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsClicked)
            {
                if (SearchInFile(Destination.Text))
                {
                    this.Height += 300; // to center the form with its results 
                    this.GRB.Height += 300; // to center the form with its results 
                    this.Top = 200; // to center the form with its results 
                    IsClicked = true; // the search button is clicked 
                }
                else
                {
                    MessageBox.Show("No results.");
                }
            }
        }
    } // Destination Search End
}