using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi;
            //Console.WriteLine("Lütfen sayiyi giriniz : ");
            //sayi = Convert.ToInt16(Console.ReadLine());

            //if (sayi==30)
            //{
            //    Console.WriteLine("Sayi dogru girildi");
            //}
            //else
            //{
            //    Console.WriteLine("sayi yanlis girildi");
            //}

            int s1, s2, ort;
            Console.WriteLine("Sayi 1 : ");
            s1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Sayi 2 : ");
            s2 = Convert.ToInt16(Console.ReadLine());
            ort = (s1 + s2) / 2;
            Console.WriteLine("Ortalamanız : " + ort);

            if (ort>=50)
            {
                Console.WriteLine("Gecti");
            }
            else
            {
                Console.WriteLine("Kaldı");
            }

            Console.Read();
        }
    }
}
