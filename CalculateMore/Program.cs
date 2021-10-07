using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateMore
{
    class Program
    {
        static void Main(string[] args)
        {


            //double varDouble = 10.10;
            //float varFloat = 10.10F;
            //decimal varDecimal = 10.10m;

            //int getal = 5;
            //Console.WriteLine(++getal); // burada 2 islem var // SONUC 6
            //Console.WriteLine(getal++); // burada ilk once getal i gosterir ++ yi sonra isler; gosterecek yer olmadigindan sonraki satirda yer bulur. SONUC 6
            //Console.WriteLine(getal);  // burada sonuc 7 dir

            //Console.ReadLine();


            int getal = 7;
            bool trueOrFalse = (getal > 2) && (getal < 10) || getal % 3 == 0;
            Console.WriteLine(trueOrFalse);

            Console.ReadLine();


        }
    }
}
