using ConsoleApp2;
using System.Net;
using System.Text.RegularExpressions;

IP ip=new IP();
Repeat repeat=new Repeat();
//for (int i = 1007; ;)
//{
//    i -= 7;
//    Console.WriteLine(i);
//    System.Threading.Thread.Sleep(10000);
//    if (i < 0) { break; }
//}
void GetMenu()
{
    Console.WriteLine();
    Console.WriteLine($"1) Проверка IP");
    Console.WriteLine($"2) Повтор строки");
    Console.WriteLine();
}
void Menu()
{
    while (true)
    {
        GetMenu();
        string choice = Console.ReadLine();
        bool choic = int.TryParse(choice, out int a);
        if (a == 1)
        {
            ip.CheckingTheIPAddress();
        }
        if (a == 2)
        {
           repeat.RepeatingALine();
        }
        else { Console.WriteLine($"Выберите пункт меню"); Console.WriteLine(); }
    }
}
Menu();
