using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Ocean_Navigation.BL;
namespace Ocean_Navigation.DL
{
    class ShipDL
    {
       public static List<Ship> ships = new List<Ship>();

        internal Ship Ship
        {
            get => default;
            set
            {
            }
        }

        public static void AddShipIntoList(Ship s)
        {
            ships.Add(s);
        }
        // ------- Saving ship Data into File -------
        public static void StoreShipDataIntoFile(string path, Ship item)
        {
            StreamWriter f1 = new StreamWriter(path, true);
            f1.WriteLine(item.getShipNumber() + "," + item.getLatitude().getDegree() + "," + item.getLatitude().getMinutes() + "," + item.getLatitude().getDirection() + "," + item.getLongitude().getDegree() + "," + item.getLongitude().getMinutes() + "," + item.getLongitude().getDirection());
            f1.Flush();
            f1.Close();
        }
        // ----------- reading from file -----------
        static public bool ReadData(string path)
        {
            StreamReader f1 = new StreamReader(path);
            string record = " ";
            if (File.Exists(path))
            {
                while ((record = f1.ReadLine()) != null)
                {
                    string[] splittedData = record.Split(',');
                    string num = splittedData[0];
                    int Lattitudedegree = int.Parse(splittedData[1]);
                    float LatitudeMinutes = float.Parse(splittedData[2]);
                    char LatitudeDirection = char.Parse(splittedData[3]);
                    int LongitudeDegree = int.Parse(splittedData[4]);
                    float LongitudeMinutes = float.Parse(splittedData[5]);
                    char LongitudeDirection = char.Parse(splittedData[6]);
                    Angle Latitude = new Angle("Latitude", Lattitudedegree, LatitudeMinutes, LatitudeDirection);
                    Angle Longitude = new Angle("Longitude", LongitudeDegree, LongitudeMinutes, LongitudeDirection);
                    Ship s = new Ship(num, Latitude, Longitude);
                    AddShipIntoList(s);
                }
                f1.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
