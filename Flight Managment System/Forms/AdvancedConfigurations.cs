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
    // Advanced Configurations Class
    public partial class AdvancedConfigurations : Form
    {
        // Attributes 
        private FileStream MainStream;
        private StreamReader MainReader;
        private StreamWriter MainWriter;
        static public int SystemIdText;
        static public string SycnState;

        // Constructor 
        public AdvancedConfigurations()
        {
            InitializeComponent();
        }

        // Form OnLoad
        private void AdvancedConfigurations_Load(object sender, EventArgs e){

            // Checks if the file exists or not ..
            if (File.Exists("Files/SystemConfigurations.txt"))
            {
                // writing the data to the form (if exists). 
                MainStream = new FileStream("Files/SystemConfigurations.txt", FileMode.Open);
                MainReader = new StreamReader(MainStream);
                SystemIdText = int.Parse(MainReader.ReadLine());
                SycnState = MainReader.ReadLine();
                
                if (SycnState == "AS") AutoSycn.Checked = true;
                else if (SycnState == "MS") ManSycn.Checked = true;

                SystemID.Value = decimal.Parse(SystemIdText.ToString());
                MainReader.Close();
            }

            else
            {
                // Assigning default values to the file ..
                MainStream = new FileStream("Files/SystemConfigurations.txt", FileMode.Create);
                MainWriter = new StreamWriter(MainStream);
                MainWriter.WriteLine("0");
                MainWriter.WriteLine("AS");
                SystemID.Value = 0;
                MainWriter.Close();
            }
        }

        // Save button ..
        private void SaveBTN_Click(object sender, EventArgs e)
        {
            MainStream = new FileStream("Files/SystemConfigurations.txt", FileMode.Create);
            MainWriter = new StreamWriter(MainStream);

            MainWriter.WriteLine(SystemID.Value.ToString());
            if (AutoSycn.Checked)
                MainWriter.WriteLine("AS");
            else if (ManSycn.Checked)
                MainWriter.WriteLine("MS");

            MainWriter.Close();

            if (SystemID.Value.ToString() == "0")
            {
                MessageBox.Show("System ID Can't be ZERO !");
            }

            MessageBox.Show("Data has been just submited!");
            this.Close();
        }
    } // End of Advanced Configurations Class 
}