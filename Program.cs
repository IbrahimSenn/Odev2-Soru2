using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2_Soru2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArrayList arr = new ArrayList();
            ArrayList arr1 = new ArrayList();
            ArrayList arr4 = new ArrayList();


            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($" {i}. Sayıyı giriniz ");
                int sayi = int.Parse(Console.ReadLine());
                arr.Add(sayi);
            }
            arr.Sort();
            double kTop = 0;
            double bTop = 0;
            double dTop = 0;
            for (int i = 0; i < 3; i++)
            {
                kTop += Convert.ToDouble(arr[i]); 
                bTop += Convert.ToDouble(arr[i+17]); 
            }
            Console.WriteLine($"En küçük üç sayının ortalaması : {kTop/3}" );
            Console.WriteLine($"En büyük üç sayının ortalaması  : {bTop/3}" );
            Console.WriteLine($"Ve bu sayıların ortalaması : {(kTop+bTop)/6}" );

            
            Console.ReadLine();
        }
    }
}
