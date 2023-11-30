using System;
using System.Security.Cryptography;

namespace Inlämningsuppgift5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frågor = {"Vad är Tysklands huvudstad?","Vad är Sveriges huvudstad", "Vad är Spaniens nationaldjur", "Vad heter jag?"};
            string[] svar = {"Berlin", "Stockholm", "Osbornetjuren", "Kevin"};
            Console.WriteLine("Välj ett tal mellan 1 och 4");
            int tal=int.Parse(Console.ReadLine());
            switch(tal)
            {
                case 1:
                    Console.WriteLine(frågor[1]);
                    string c1=Console.ReadLine();
                    if (c1 == svar[1])
                    {
                        Console.WriteLine("Rätt svar!");
                    }
                    else
                    {
                        Console.WriteLine("Fel svar!");
                    }
                    break;
                case 2:
                    Console.WriteLine(frågor[2]);
                    string c2 = Console.ReadLine();
                    if (c2 == svar[2])
                    {
                        Console.WriteLine("Rätt svar!");
                    }
                    else
                    {
                        Console.WriteLine("Fel svar!");
                    }
                    break;
                case 3:
                    Console.WriteLine(frågor[3]);
                    string c3 = Console.ReadLine();
                    if (c3 == svar[3])
                    {
                        Console.WriteLine("Rätt svar!");
                    }
                    else
                    {
                        Console.WriteLine("Fel svar!");
                    }
                    break;
                case 4:
                    Console.WriteLine(frågor[4]);
                    string c4 = Console.ReadLine();
                    if (c4 == svar[4])
                    {
                        Console.WriteLine("Rätt svar!");
                    }
                    else
                    {
                        Console.WriteLine("Fel svar!");
                    }
                    break;
                default:
                    Console.WriteLine("Ogiltigt val, välj ett tal mellan 1 och 4");
                    break;
            }

        }
    }
}
