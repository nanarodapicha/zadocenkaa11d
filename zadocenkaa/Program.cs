using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace zadocenkaa
{
    internal class Program
    {      
        static void Main(string[] args)
        {
            Thread A = new Thread(PrintFromA);
            Thread Z = new Thread(PrintFromZ);

            A.Start();
            A.Join();

            Z.Start();
            Z.Join(); 

            Thread dushterna = new Thread(PrintDigits);
            dushterna.Start();
            dushterna.Join(); 
        }
        static void PrintFromA()
        {
            for (char i = 'A'; i <= 'Z'; i++)
            {
                Console.WriteLine("A-Z: " + i);
                Thread.Sleep(1000);
            }
        }
        static void PrintFromZ()
        {
            for (char i = 'Z'; i >= 'A'; i--)
            {
                Console.WriteLine("Z-A: " + i);
                Thread.Sleep(1500);
            }
        }
        static void PrintDigits()
        {
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Dushterna: " + i);
                Thread.Sleep(20);
            }
        }
    } 
}
