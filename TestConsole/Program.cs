using System;
using System.Diagnostics;
using System.Threading;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int duree = 20;
            Console.Write("Temps restant: ");
            while (duree!=0)
            {
               
                Console.Write(duree--);
                Thread.Sleep(1000);
            }
            Console.Read();
            
          

        }
    }
}
