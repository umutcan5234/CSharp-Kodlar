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
            int faktoriyel(int sayi)  
            {
                int x = 1;  
                for (int i = 1; i <= sayi; i++)  
                {
                    x = x * i; 
                }
                return x;  
            }
            {
                Console.Write("Bir sayı giriniz: ");  
                int sayi = Convert.ToInt32(Console.ReadLine());  
                int sonuc = faktoriyel(sayi); 
                Console.WriteLine(sayi + "! = " + sonuc); 
            }
            Console.ReadKey();  
        }
    }
}
