using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocean_Navigation.BL;
using Ocean_Navigation.DL;
namespace Ocean_Navigation.UI
{
    class ShipUI
    {
        internal Angle Angle
        {
            get => default;
            set
            {
            }
        }

        internal Ship Ship
        {
            get => default;
            set
            {
            }
        }

        // ------------ Add Ship ------------------
        public static Ship addShip()
        {
            int Lat_Degree;
            char Lat_Direction;
            float Lat_Minutes;
            int Long_Degree;
            char Long_Direction;
            float Long_Minutes;
            string n;
            Console.WriteLine("Enter Ship Number: ");
            n = Console.ReadLine();
            Console.WriteLine("\t\t\tShip Latitude: ");
            Console.Write("Enter Latitude Degree: ");
            Lat_Degree = int.Parse(Console.ReadLine());
            Console.Write("Enter Latitude Minutes: ");
            Lat_Minutes = float.Parse(Console.ReadLine());
            Console.Write("Enter Laitude Direction: ");
            Lat_Direction = char.Parse(Console.ReadLine());
            Console.WriteLine("\t\t\tShip Longitude: ");
            Console.Write("Enter Longitude Degree: ");
            Long_Degree = int.Parse(Console.ReadLine());
            Console.Write("Enter Longitude Minutes: ");
            Long_Minutes = float.Parse(Console.ReadLine());
            Console.Write("Enter Longitude Direction: ");
            Long_Direction = char.Parse(Console.ReadLine());
            Angle Latitude = new Angle("Latitude", Lat_Degree, Lat_Minutes, Lat_Direction);
            Angle Longitude = new Angle("Longitude", Long_Degree, Long_Minutes, Long_Direction);
            Ship s = new Ship(n, Latitude, Longitude);
            return s;
        }
        // --------------- update position -------------
        public static void UpdatePosition(string shipNum)
        {

            bool flag = false;
            foreach (Ship i in ShipDL.ships)
            {
                if (i.getShipNumber() == shipNum)
                {
                    int latitudeDegree, longitudeDegree;
                    float latitudeM, longitudeM;
                    char latitudeD, longitudeD;
                    Console.WriteLine();
                    Console.WriteLine(" ----- Enter Ship Latitude ------- ");
                    Console.Write("Enter Latitude's Degree: ");
                    latitudeDegree = int.Parse(Console.ReadLine());
                    Console.Write("Enter Latitude's Minute: ");
                    latitudeM = float.Parse(Console.ReadLine());
                    Console.Write("Enter Latitude's Direction: ");
                    latitudeD = char.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine(" ----- Enter Ship Longitude -----");
                    Console.Write("Enter Longitude's Degree: ");
                    longitudeDegree = int.Parse(Console.ReadLine());
                    Console.Write("Enter Longitude's Minute: ");
                    longitudeM = float.Parse(Console.ReadLine());
                    Console.Write("Enter Longitude's Direction: ");
                    longitudeD = char.Parse(Console.ReadLine());
                    i.getLatitude().UpdateAngle("Latitude", latitudeDegree, latitudeM, latitudeD);
                    i.getLongitude().UpdateAngle("Longitude", longitudeDegree, longitudeM, longitudeD);
                    Console.WriteLine();
                    Console.WriteLine("Ship's Position has been Changed.");
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                Console.WriteLine(" No ship with this Serial Number.");

            }
        }
        // ------------ view ship number -----------------
        public static string ViewShipNumber()
        {
            int Lat_Degree;
            char Lat_Direction;
            float Lat_Minutes;
            int Long_Degree;
            char Long_Direction;
            float Long_Minutes;
            Console.WriteLine("\t\t\tShip Latitude: ");
            Console.Write("Enter Latitude Degree: ");
            Lat_Degree = int.Parse(Console.ReadLine());
            Console.Write("Enter Latitude Minutes: ");
            Lat_Minutes = float.Parse(Console.ReadLine());
            Console.Write("Enter Laitude Direction: ");
            Lat_Direction = char.Parse(Console.ReadLine());
            Console.WriteLine("\t\t\tShip Longitude: ");
            Console.Write("Enter Longitude Degree: ");
            Long_Degree = int.Parse(Console.ReadLine());
            Console.Write("Enter Longitude Minutes: ");
            Long_Minutes = float.Parse(Console.ReadLine());
            Console.Write("Enter Longitude Direction: ");
            Long_Direction = char.Parse(Console.ReadLine());
            foreach (Ship i in ShipDL.ships)
            {
                if (i.getLatitude().getDegree() == Lat_Degree && i.getLongitude().getDegree() == Long_Degree)
                {
                    if (i.getLatitude().getMinutes() == Lat_Minutes && i.getLongitude().getMinutes() == Long_Minutes)
                    {
                        if (i.getLatitude().getDirection() == Lat_Direction && i.getLongitude().getDirection() == Long_Direction)
                        {
                            string number = i.getShipNumber();
                            return number;
                        }
                    }
                }
            }
            return null;
        }
        // ---------------- view ship position -------------
        public static void ViewShipPostion(string num)
        {
            bool flag = false;
            foreach (Ship i in ShipDL.ships)
            {
                if (i.getShipNumber() == num)
                {
                    i.printShipAngle();
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                Console.WriteLine(" No ship with this Serial Number.");
            }
        }
    }
}
