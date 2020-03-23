using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_13_Pin_Kodu_App
{
    class Program
    {
        static void Main(string[] args)
        {
            string pin = "12345";
            string UPin;

            int hak = 3;
            int i = 0;

            while (hak>i)
            {
                Console.Write("Pin Değerini Giriniz:");
                UPin = Console.ReadLine();

                if (UPin==pin)
                {
                    Console.WriteLine("Başarılı Bir Şekilde Giriş Yapıldı");
                    break;
                }

                else
                {
                    hak--;
                    Console.WriteLine("Yanlış Giriş Yaptınız Kalan Hakkınız:{0}",hak);
                }
            }

            if (hak==0)
            {
                Console.WriteLine("Sim Kartınız Bloke Edildi");
            }


            Console.ReadKey();
        }
    }
}
