using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.WorldOfTanks
{
    public class Tank
    {
        private static Random rand = new Random();
        private string name;
        private int ammunition;
        private int armor;
        private int mobility;

        public Tank() { }

        public Tank(string name)
        {
            Name = name;
            Ammunition = rand.Next(0, 100);
            Armor = rand.Next(0, 100);
            Mobility = rand.Next(0, 100);
        }

        public string Name { get => name; set => name = value; }
        public int Ammunition { get => ammunition; set => ammunition = value; }
        public int Armor { get => armor; set => armor = value; }
        public int Mobility { get => mobility; set => mobility = value; }

        public static bool operator*(Tank fTank, Tank sTank)
        {
            if (fTank.Armor > sTank.Armor && fTank.Mobility > sTank.Mobility)
            {
                return true;
            }
            else if (fTank.Ammunition > sTank.Ammunition && fTank.Mobility > sTank.Mobility)
            {
                return true;
            }
            else if (fTank.Armor > sTank.Armor && fTank.Ammunition > sTank.Ammunition)
            {
                return true;
            }

            return false;
        }

        public string GetParametrs()
        {
            return string.Format($"{Ammunition}-{Armor}-{Mobility}");
        }
    }
}
