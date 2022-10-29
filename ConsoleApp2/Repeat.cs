using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Repeat
    {
        public void RepeatingALine()
        {
            while (true)
            {


                Console.WriteLine($"Введите число");
                Console.WriteLine();
                string number = Console.ReadLine();
                bool numbe = int.TryParse(number, out int n);
                Console.WriteLine();
                if (numbe == true)
                {
                    Console.WriteLine($"Введите строку");
                    Console.WriteLine();
                    string s = Console.ReadLine();
                    Console.WriteLine();
                    if (s == "" || s == " ")
                    {
                        Console.WriteLine($"Строка пуста");
                    }
                    else
                    {
                        for (int i = 1; i <= n; i++)
                        {
                            Console.Write(s);
                            
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели не число");
                    Console.WriteLine();
                }
            }
        }
    }
}
