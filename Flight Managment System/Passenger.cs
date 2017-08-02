using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Flight_Managment_System
{
    // Passenger Class
    class Passenger
    {
        private string PassengerName; // variable length field
        private string Phone; // variable length record field
        private string FlightNo; // variable length record field
        public int RecordSize = 50; // fixed record of size 50

        // default constructor
        public Passenger(){}

        // Setters
        public void SetPassengerName(string PassengerName){
            this.PassengerName = PassengerName;
        }

        public void SetPassengerPhone(string Phone)
        {
            this.Phone = Phone;
        }

        public void SetPassengerFlightNo(string FlightNumber)
        {
            this.FlightNo = FlightNumber;
        }

        // Getters
        public string GetPassengerName(){
            return PassengerName;
        }

        public string GetPassengerPhone()
        {
            return Phone;
        }

        public string GetPassengerFlightNo()
        {
            return FlightNo;
        }

        public int GetNameSize()
        {
            return PassengerName.Length;
        }

        public int GetPhoneSize()
        {
            return Phone.Length;
        }

        public int GetFlightNumberSize()
        {
            return FlightNo.Length;
        }
    } // End of passenger class
} 