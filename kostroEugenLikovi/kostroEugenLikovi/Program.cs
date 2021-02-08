using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kostroEugenLikovi
{
    class Program
    {
        static void Main(string[] args)
        {
            Cetverokut cetverokut = new Cetverokut();
            cetverokut.UcitajStranice();
            double OCetverokut = cetverokut.Opseg();
            Console.WriteLine("Opseg zadanog cetverokuta je: " + OCetverokut);
            Trokut trokut = new Trokut();
            trokut.UcitajStranice();
            double OTrokut = trokut.Opseg();
            Console.WriteLine("Opseg zadanog trokuta je: " + OTrokut);


            Console.ReadKey();
            
        }
    }
}
