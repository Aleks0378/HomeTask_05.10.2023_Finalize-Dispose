// See https://aka.ms/new-console-template for more information
using Task_2;

//Завдання 2:
//Створіть клас «Магазин», який має зберігати таку інформацію:
// назва магазину;
// адреса магазину;
// тип магазину:
//o продовольчий,
//o господарський,
//o одяг,
//o взуття.
//Реалізуйте у класі методи та властивості, необхідні для функціонування класу.
//Клас має реалізовувати інтерфейс IDisposable.
//Напишіть код для тестування функціональності класу.
//Напишіть код для виклику методу Dispose.

//Завдання 3:
//Додайте до першого завдання реалізацію інтерфейсу IDisposable.
//Додайте до другого завдання реалізацію деструктора. Напишіть код для тестування нових можливостей.
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
    for (int i = 0; i < shops.Count; i++)
    {
        shops[i] = null;
    }
    GC.Collect();
    GC.WaitForPendingFinalizers();
}
catch (Exception e) { Console.WriteLine(e); }
