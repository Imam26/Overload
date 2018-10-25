using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib.WorldOfTanks;

namespace Day7
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank[] firstTanks = new Tank[5];
            Tank[] secondTanks = new Tank[5];
               
            try
            {
                Battle(firstTanks, secondTanks);
            }
            catch(NullReferenceException exception)
            {
                Console.WriteLine("Exception: {0}", exception.Message);
                Console.WriteLine();

                InitTank(firstTanks, "T-34");
                InitTank(secondTanks, "Panterа");
                Battle(firstTanks, secondTanks);
            }

        }

        static void InitTank(Tank[] tanks, string name)
        {
            for(int i = 0; i<tanks.Length; i++)
            {
                tanks[i] = new Tank(name);
            }
        }

        static void Battle(Tank[] firstTanks, Tank[] secondTanks)
        {
            for (int i = 0; i < firstTanks.Length; i++)
            {
                Console.Write($"({firstTanks[i].Name}) {firstTanks[i].GetParametrs()} " +
                    $"vs ({secondTanks[i].Name}) {secondTanks[i].GetParametrs()} result: ");
                if (firstTanks[i] * secondTanks[i])
                    Console.WriteLine("Winner: {0}", firstTanks[i].Name);
                else
                    Console.WriteLine("Winner: {0}", secondTanks[i].Name);
            }
        }
    }
}
