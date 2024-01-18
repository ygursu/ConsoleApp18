using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Sayısal Loto Programı
namespace ornek_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] rastgelesayi = new int[6];
            for (int i = 0; i < 6; i++)
            {
                rastgelesayi[i] = rnd.Next(1, 50);
            }
            //www.bilisimkonulari.com
            Array.Sort(rastgelesayi);
            Console.WriteLine("Sayısal Loto Rakamları");
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < 6; i++)
            {
                Console.Write(rastgelesayi[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
