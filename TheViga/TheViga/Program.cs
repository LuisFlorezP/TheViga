using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheViga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Viga viga = new Viga();

                Console.Write("Enter the beam: ");
                viga.Weight = Console.ReadLine();

                viga.Endurance = viga.AnalizeBase();
                viga.VerifyWeight();

                if (viga.TotalWeight <= viga.Endurance)
                {
                    Console.WriteLine("The beam supports the weight!");
                }
                else
                {
                    Console.WriteLine("The beam NOT supports the weight!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Write("Press a key to end... ");
            Console.ReadKey();
        }
    }
}
