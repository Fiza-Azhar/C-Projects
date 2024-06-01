using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean_Navigation.BL
{
    class Ship
    {
        private string ShipNumber;
        private Angle Latitude;
        private Angle Longitude;
        public Ship()
        {

        }
        public string getShipNumber()
        {
            return ShipNumber;
        }
        public Angle getLatitude()
        {
            return Latitude;
        }
        public Angle getLongitude()
        {
            return Longitude;
        }
        public void setLongitude(Angle Longitude)
        {
            Longitude = Longitude;
        }
        public void setLatitude(Angle Latitude)
        {
            Latitude = Latitude;
        }

        public Ship(string ShipNumber, Angle Latitude, Angle Longitude)
        {
            this.ShipNumber = ShipNumber;
            this.Latitude = Latitude;
            this.Longitude = Longitude;
        }

        public void printShipAngle()
        {
            Console.WriteLine("Ship is at: ");
            Console.WriteLine("Longitude: " + getLongitude().getDegree() + "\u00b0" + getLongitude().getMinutes() + "'" + getLongitude().getDirection());
            Console.WriteLine("Latitude: " + getLatitude().getDegree() + "\u00b0" + getLatitude().getMinutes() + "'" + getLatitude().getDirection());
        }

        public void printShipNumber()
        {
            Console.Write("Ship Number is: ");
            Console.Write(ShipNumber);
        }

        internal Angle Angle
        {
            get => default;
            set
            {
            }
        }
    }
}
