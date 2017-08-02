// Abdelrahman Othman Helal
// Text File Uploader 
// 25/4/2015
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace Flight_Managment_System
{
    public class FileUploader
    {
        private FileInfo ToBeUploaded; // An object that represent the file that will be uploaded
        private FtpWebRequest FTPUploadRequest; // A request to upload the file to the server 
        private bool IsUploaded; // Detects that the file was uploaded or not 
        private Stream ftpStream; //Setup a stream for the request 
        private FileStream file; //Setup a stream for the file we'll be uploading.

        public FileUploader() { }

        /* FilePath : the file which you will upload
         * Server FTP Address : the address that you will upload to 
         * ServerUserName : the user name used to login to the server  
         * ServerPassword : the password that used to enter the server
        */
        public bool UploadFile(string FilePath, string FTPAddress, string ServerUserName, string ServerPassword)
        {
            IsUploaded = false; // Setting the upload operation wasn't completed
            
            ToBeUploaded = new FileInfo(FilePath); // Assigning the file path to the fileinfo
            
            FTPUploadRequest = (FtpWebRequest)WebRequest.Create(FTPAddress + "/" + ToBeUploaded.Name);
            
            FTPUploadRequest.Method = WebRequestMethods.Ftp.UploadFile;
            
            FTPUploadRequest.Credentials = new NetworkCredential(ServerUserName, ServerPassword);
            
            ftpStream = FTPUploadRequest.GetRequestStream();
            
            file = File.OpenRead(FilePath);

            int length = 2048;
            byte[] buffer = new byte[length];
            int bytesRead = 0;

            do
            {
                bytesRead = file.Read(buffer, 0, length);
                ftpStream.Write(buffer, 0, bytesRead);
            }
            while (bytesRead != 0);
            
            file.Close();
            ftpStream.Close();

            IsUploaded = true;
            return IsUploaded;
        }
    } // End of FileUploader Class
}