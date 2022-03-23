using System;

namespace ProgramTaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek Taxi
            Taxi taxi1 = new Taxi();

            // pengesetan nilai properties
            taxi1.DriverName = "Jono";
            taxi1.OnDuty = true;
            taxi1.NumPassenger = 10;

            // pemanggilan method 
            taxi1.TaxiInfo();
            taxi1.PickUpPassenger();
            taxi1.DropOffPassenger();

            Console.ReadKey();
        }
    }
}