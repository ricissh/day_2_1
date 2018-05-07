using System;

namespace day_2_1
{
    class Program
    {
        static void Main(string[] args)
        
        {

            String diena;
                String gads;
            String menesis;

            Console.WriteLine("ievadi savu dzimsanas dienu");
            diena = Console.ReadLine();
            Console.WriteLine("ievadi savu dzimsanas menesi");
            menesis = Console.ReadLine();
            Console.WriteLine("ievadi savu dzimsanas gadu");
            gads = Console.ReadLine();
            Console.WriteLine("sveiki tava dzimsanas diena ir "+ diena + menesis + gads);
            Console.ReadLine();
        }
    }
}         
