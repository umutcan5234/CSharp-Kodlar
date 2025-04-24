using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int teksayilar(int[] numbers) 
            {
                int sayac = 0;  

                foreach (int sayi in numbers)  
                {
                    if (sayi % 2 == 1)  
                    {
                        sayac++;  
                        Console.WriteLine(sayi);  
                    }
                }
                return sayac;  
            }
            int[] sayilar = { 12, 85, 50, 37, 99, 48, 60, 21, 23, 55 }; 
            int tane = teksayilar(sayilar);  
            Console.WriteLine(tane + " tane tek sayı vardır"); 
            Console.ReadKey();  
        }
    }
}
