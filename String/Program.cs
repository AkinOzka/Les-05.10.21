using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {

            //int i = 10;
            //string school = "intec brussel class 2";
            //Console.WriteLine(school);
            //school = school + " intec brussel";  // 
            //Console.WriteLine(school);

            //school = school + " rouppeplein";
            //Console.WriteLine(school);

            //school = "";
            //Console.WriteLine(school);

            string movieName = "The Lords Of The Rings";
            Console.WriteLine("position 16 is letter " + movieName[16]);
            Console.WriteLine("my variable string has " +  movieName.Length + " characters");
            Console.WriteLine(movieName.ToUpper());
            Console.WriteLine(movieName.ToLower());
            Console.WriteLine(movieName.Replace("R", "T"));
            Console.WriteLine(movieName.Contains('o'));





            Console.ReadLine();



        }
    }
}
