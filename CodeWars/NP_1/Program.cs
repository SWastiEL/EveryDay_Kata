using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP_1
{
    //Write an algorithm that will identify valid IPv4 addresses in dot-decimal format. 
    //IPs should be considered valid if they consist of four octets, with values between 0 and 255, inclusive.

    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine($"{i++} {Is_valid_IP("0.0.0.0")}");           //1
            Console.WriteLine($"{i++} {Is_valid_IP("12.255.56.1")}");       //2
            Console.WriteLine($"{i++} {Is_valid_IP("137.255.156.100")}");   //3
            Console.WriteLine();
            Console.WriteLine($"{i++} {Is_valid_IP("")}");                  //4
            Console.WriteLine($"{i++} {Is_valid_IP("abc.def.ghi.jkl")}");   //5
            Console.WriteLine($"{i++} {Is_valid_IP("123.456.789.0")}");     //6
            Console.WriteLine($"{i++} {Is_valid_IP("12.34.56")}");          //7
            Console.WriteLine($"{i++} {Is_valid_IP("12.34.56.00")}");       //8
            Console.WriteLine($"{i++} {Is_valid_IP("12.34.56.7.8")}");      //9
            Console.WriteLine($"{i++} {Is_valid_IP("12.34.256.78")}");      //10
            Console.WriteLine($"{i++} {Is_valid_IP("1234.34.56")}");        //11
            Console.WriteLine($"{i++} {Is_valid_IP("pr12.34.56.78")}");     //12
            Console.WriteLine($"{i++} {Is_valid_IP("12.34.56.78sf")}");     //13
            Console.WriteLine($"{i++} {Is_valid_IP("12.34.56 .1")}");       //14
            Console.WriteLine($"{i++} {Is_valid_IP("12.34.56.-1")}");       //15
            Console.WriteLine($"{i++} {Is_valid_IP("123.045.067.089")}");   //16

            Console.ReadKey();
        }

        public static bool Is_valid_IP(string ip)
        {
            bool resoult;
            if (ip.Split('.').Length == 4)
            {
                resoult = ip.Split('.').All(g =>
                g.Length >= 1 &&
                Int32.TryParse(g, out int res) &&
                (!g.StartsWith("0") || (res == 0 && g.Length == 1)) &&
                !g.Contains(" ") &&
                res >= 0 &&
                res <= 255);
            }
            else resoult = false;
            return resoult;
        }
    }
}
