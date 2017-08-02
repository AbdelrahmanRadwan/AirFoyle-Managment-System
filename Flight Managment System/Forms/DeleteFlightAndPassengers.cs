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

namespace Flight_Managment_System.Forms
{
    public partial class DeleteFlightAndPassengers : Form
    {
        FileStream MainStream;
        StreamReader MainReader;
        StreamWriter MainWriter;
        public DeleteFlightAndPassengers()
        {
            InitializeComponent();
        }

        private void DeleteFlightAndPassengers_Load(object sender, EventArgs e){}

        private void button1_Click(object sender, EventArgs e)
        {
            // Deleting Passengers
            List<int> Targets = new List<int>();
            MainStream = new FileStream("Files/Passengers" + AdvancedConfigurations.SystemIdText + ".txt", FileMode.Open, FileAccess.ReadWrite);
            MainReader = new StreamReader(MainStream);
            MainWriter = new StreamWriter(MainStream);
            string Key = textBox1.Text;
            
            char[] PTemp = new char[52];
            string Ptemp;

            int PTarget = 1;
            string[] Tokens;
            
            MainReader.BaseStream.Seek(1, SeekOrigin.Begin);
            while (MainReader.Peek() != -1)
            {
                MainReader.Read(PTemp, 0, 52);
                Ptemp = new string(PTemp);
                Tokens = Ptemp.Split('@');

                Tokens[2] = Tokens[2].Replace("\0", string.Empty);
                Tokens[2] = Tokens[2].Replace(" ", string.Empty);
                
                if (textBox1.Text == Tokens[2])
                {
                    Targets.Add(PTarget);
                }
                PTarget++;
            }

            int Phead;
            int Poffset;

            MainReader.BaseStream.Seek(0, SeekOrigin.Begin);
            Phead = MainReader.BaseStream.ReadByte();

            for (int i = 0; i < Targets.Count; i++)
            {
                
                MainReader.BaseStream.Seek(0, SeekOrigin.Begin);
                Phead = MainReader.BaseStream.ReadByte();
                
                Poffset = ((Targets[i]-1) * 52) + 1;

                MainWriter.BaseStream.Seek(Poffset, SeekOrigin.Begin);
                MainWriter.Write("*" + Phead.ToString() + "|");
                MainWriter.Flush();

                MainWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                MainWriter.BaseStream.WriteByte((byte)Targets[i]);
            }

            MainWriter.Close();
            MainReader.Close();

            // Deleting a flight ...
            MainStream = new FileStream("Files/FirstFlights" + AdvancedConfigurations.SystemIdText + ".txt", FileMode.Open, FileAccess.ReadWrite);
            MainReader = new StreamReader(MainStream);
            MainWriter = new StreamWriter(MainStream);

            int Fhead;
            int Foffset;

            char[] Temp = new char[31];
            string temp;
            int Target = 0;

            MainReader.BaseStream.Seek(1, SeekOrigin.Begin);

            while (MainReader.Peek() != -1)
            {
                MainReader.Read(Temp, 0, 31);
                temp = new string(Temp);
                if (temp.Substring(0, 5) == textBox1.Text)
                {
                    break;
                }
                Target++;
            }

            Target += 1;

            MainReader.BaseStream.Seek(0, SeekOrigin.Begin);

            Fhead = MainReader.BaseStream.ReadByte(); // hena
            
            Foffset = ((Target - 1) * 31) + 1;

            MainWriter.BaseStream.Seek(Foffset, SeekOrigin.Begin);

            MainWriter.Write('*' + (Fhead).ToString() + '|');
            MainWriter.Flush();
            MainWriter.BaseStream.Seek(0, SeekOrigin.Begin);
            MainWriter.BaseStream.WriteByte((byte)(Target));
            MainWriter.Close();
            MainReader.Close();
            
            MessageBox.Show("Deleted!");
            this.Close();
        }
    }
}