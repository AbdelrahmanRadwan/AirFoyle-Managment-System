using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Managment_System
{
    // Flight Class
    class Flight
    {
        private char[] FlightNumber;  // fixed field
        private char[] Destination;  // fixed field
        private char[] ArrivalDate; // fixed field

        private const int RecordLength = 30; // Fixed record length of 30
        private const int FlightNumberSize = 5; 
        private const int DestinationSize = 15;
        private const int ArrivalDateSize = 10;

        // constructor without parameters .. initializaing arrays with the default values
        public Flight()
        {
            FlightNumber = new char[FlightNumberSize]; // 5 chars
            Destination = new char[DestinationSize]; // 15 chars
            ArrivalDate = new char[ArrivalDateSize]; // 10 chars
        }

        // Setters
        public void SetFlightNumber(string FlightNumber)
        {
            FlightNumber.CopyTo(0 , this.FlightNumber , 0 , FlightNumber.Length);
        }

        public void SetDestination(string Destination)
        {
             Destination.CopyTo(0 , this.Destination , 0 , Destination.Length);
        }

        public void SetArrivalDate(string ArrivalDate)
        {
            ArrivalDate.CopyTo(0 , this.ArrivalDate  , 0 , ArrivalDate.Length);
        }

        // Getters
        public char[] GetFlightNumber()
        {
            return FlightNumber;
        }

        public char[] GetDestination()
        {
            return Destination;
        }

        public char[] GetArrivalDate()
        {
            return ArrivalDate;
        }

        public int GetRecordLength()
        {
            return RecordLength;
        }

        public int GetFlightNumberSize()
        {
            return FlightNumberSize;
        }

        public int GetDestinationSize()
        {
            return DestinationSize;
        }

        public int GetArrivalDateSize()
        {
            return ArrivalDateSize;
        }
    } // End of Flight Class
}
