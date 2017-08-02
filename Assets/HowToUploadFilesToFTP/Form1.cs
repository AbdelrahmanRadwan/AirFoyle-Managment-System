using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace HowToUploadFilesToFTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            //Get a FileInfo object for the file that will
            // be uploaded.
            FileInfo toUpload = new FileInfo(this.txtFile.Text);

            //Get a new FtpWebRequest object.
            FtpWebRequest request = 
                (FtpWebRequest)WebRequest.Create(
                this.txtAddress.Text + "/" + toUpload.Name
                );

            //Method will be UploadFile.
            request.Method = WebRequestMethods.Ftp.UploadFile;

            //Set our credentials.
            request.Credentials =
                new NetworkCredential(this.txtUserName.Text,
                                        this.txtPassword.Text);

            //Setup a stream for the request and a stream for
            // the file we'll be uploading.
            Stream ftpStream = request.GetRequestStream();
            FileStream file = File.OpenRead(this.txtFile.Text);

            //Setup variables we'll use to read the file.
            int length = 1024;
            byte[] buffer = new byte[length];
            int bytesRead = 0;

            //Write the file to the request stream.
            do
            {
                bytesRead = file.Read(buffer, 0, length);
                ftpStream.Write(buffer, 0, bytesRead);
            }
            while (bytesRead != 0);

            //Close the streams.
            file.Close();
            ftpStream.Close();

            MessageBox.Show("Upload complete");
        }

        private void btnPickFile_Click(object sender, EventArgs e)
        {
            DialogResult result = fileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.txtFile.Text = fileDialog.FileName;
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            //Create a WebClient.
            WebClient request = new WebClient();

            //Setup our credentials
            request.Credentials =
                new NetworkCredential(this.txtUserName.Text,
                                        this.txtPassword.Text);

            //Download the data into a Byte array
            byte[] fileData = 
                request.DownloadData(this.txtAddress.Text + "/" +
                                     this.txtFileToDownload.Text);

            //Create a FileStream that we'll write the
            // byte array to.
            FileStream file = 
                File.Create(this.txtDownloadPath.Text + "\\" +
                this.txtFileToDownload.Text);

            //Write the full byte array to the file.
            file.Write(fileData, 0, fileData.Length);

            //Close the file so other processes can access it.
            file.Close();

            MessageBox.Show("Download complete");
        }
    }
}