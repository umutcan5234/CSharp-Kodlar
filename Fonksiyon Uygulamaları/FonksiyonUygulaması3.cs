using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplama(int sayi)  
            {
                int a = 1;  
                int toplam = 0;  
                do  
                {
                    toplam = toplam + a;  
                    a++;  
                } while (a <= sayi); 
                return toplam;  
            }
            int sonuc = toplama(100);  
            Console.WriteLine("1'den 100'e kadar olan sayıların toplamı: " + sonuc);  
            Console.ReadKey();  
        }
    }
}
