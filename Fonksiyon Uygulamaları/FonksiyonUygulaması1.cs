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
            int karealma(int k) 
            {
                return k * k;  
            }
            {
                Console.Write("Bir sayı giriniz: ");  
                int sayi = Convert.ToInt32(Console.ReadLine());  
                int tamkare = karealma(sayi);  
                if (tamkare < 50)   
                {
                    Console.WriteLine("Sayı 50'den küçüktür");   
                }
                else  
                {
                    Console.WriteLine("Sayı 50'den büyüktür");  
                }
                Console.ReadKey();  



            }
        }
    }
}
