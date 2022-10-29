using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class IP
    {
        public void CheckingTheIPAddress()
        {
            Console.WriteLine($"Введите IP");
            string enter = Console.ReadLine();
            Regex regex = new Regex(@"^\d{3}.\d{3}.\d{3}.\d{3}$");
            regex.IsMatch(enter);
            if (regex.IsMatch(enter))
            {
                bool a = IPAddress.TryParse(enter, out IPAddress? Ip);
                if (a == true)
                {
                    Console.WriteLine("IP адрес введён правельно");
                }
                else
                {
                    Console.WriteLine($"IP адрес введён не правельно");
                }
                Console.WriteLine(Ip?.ToString());
            }
            else
            {
                Console.WriteLine($"IP адрес введён не правельно");
            }
        }
    }
}
