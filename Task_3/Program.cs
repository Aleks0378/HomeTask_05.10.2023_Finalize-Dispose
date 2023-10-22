using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Завдання 3:
//Додайте до першого завдання реалізацію інтерфейсу IDisposable.
//Додайте до другого завдання реалізацію деструктора.
//Напишіть код для тестування нових можливостей.

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Shop> shops = new List<Shop>();
                shops.Add(new Shop("Best Store", "Beverly Hils 125", "hardware"));
                shops.Add(new Shop("Nice one", "30, Lenin str., Washington", "clothes"));
                shops.Add(new Shop("Cheap and Deep", "25, Zhykov strasse str., New York", "hardware"));
                shops.Add(new Shop("Eat and Drink", "55, Pisanka str., Houston. USA", "grocery"));
                Console.WriteLine("Shops List:");
                foreach (Shop shop in shops)
                    Console.WriteLine(shop);

                Console.WriteLine("\nDo you want to add a new shop to the list? \"Yes\" or \"No\"");
                string str = Console.ReadLine();
                if (str.ToLower() == "yes")
                {
                    Shop sh = new Shop();
                    sh.Input();
                    shops.Add(sh);
                    Console.WriteLine("Shops List:");
                    foreach (Shop shop in shops)
                        Console.WriteLine(shop);
                }

                foreach (Shop shop in shops)
                    shop.Dispose();
            }
            catch (Exception e) { Console.WriteLine(e); }
        }
    }
}
