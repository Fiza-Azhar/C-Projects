using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocean_Navigation.UI;
using Ocean_Navigation.DL;
using Ocean_Navigation.BL;
namespace Ocean_Navigation
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "SHIPS.txt";
            if(ShipDL.ReadData(path))
            {
                Console.WriteLine("Successfully read data ");
            }
            char op;
            do
            {
                op = MenuUI.MainMenu();
                // -------------- Adiing Ship ------------
                if (op == '1')
                {
                    MenuUI.Header();
                    Ship s = new Ship();
                    s = ShipUI.addShip();
                    ShipDL.AddShipIntoList(s);
                    ShipDL.StoreShipDataIntoFile(path, s);
                }
                // ----------------- view ship position ---------------
                else if (op == '2')
                {
                  //  ShipDL.ReadData(path);
                    Console.Write("Enter Ship Number: ");
                    string num = Console.ReadLine();
                    ShipUI.ViewShipPostion(num);
                }
                // ----------------------- View ship serial number ----------------
                else if (op == '3')
                {
                    string serial = ShipUI.ViewShipNumber();
                    Console.WriteLine("Ship Found");
                    Console.Write("Ship Serial Number IS: " + serial);
                }
                // ---------------------- change ship position -----------------
                else if (op == '4')
                {
                    string shipNum;
                    Console.Write("Enter Ship number whose position you want to change: ");
                    shipNum = Console.ReadLine();
                    ShipUI.UpdatePosition(shipNum);
                }
                MenuUI.clearScreen();
            } while (op != '5');
        }
    }
}
