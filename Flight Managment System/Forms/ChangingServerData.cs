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
    // Changing Server data class 
    public partial class ChangingServerData : Form
    {
        // Attributes 
        FileStream MainStream;
        StreamWriter MainWriter;
        // Constructor 
        public ChangingServerData() 
        {
            InitializeComponent();
        }

        // Save button
        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Simple validation
            if (FTPAddress.Text == "ftp://example.com" || UserName.Text == "Username" || Password.Text == "Password" || FTPAddress.Text.Substring(0, 6) != "ftp://")
            {
                MessageBox.Show("Please Validate Your Data!");
            }

            else
            {
                MainStream = new FileStream("Files/LoggingData.txt", FileMode.Create);
                MainWriter = new StreamWriter(MainStream);
                MainWriter.WriteLine(FTPAddress.Text);
                MainWriter.WriteLine(UserName.Text);
                MainWriter.WriteLine(Password.Text);
                MainWriter.Close();
                MessageBox.Show("Changes Saved !");
                this.Close();
            }
        }
    } // End of Changing server data class
}
