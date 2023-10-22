using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Task_2
{
   public class Shop: IDisposable
    {
        public string? name;
        public string? adress;
        public string? type;

        public string Name 
        {
            get {return name;}
            set 
            {
                if (value == null || value == "")
                {
                    throw new Exception("Error! Shop name can't be empty.");
                }
                else
                    name = value;
            }
        }
        public string Adress
        {
            get { return adress;}
            set
            {
                if (value == null || value == "")
                {
                    throw new Exception("Error! Shop adress can't be empty.");
                }
                else
                    adress = value;
            }
        }
        public string Type
        {
            get { return type;}
            set
            {
                if (value == null || value == "")
                {
                    throw new Exception("Error! Shop type can't be empty. Please choose one from the list.");
                }
                else
                    type = value;
            }
        }

        public Shop() { }
        public Shop(string name, string adress, string type)
        {
            Name = name;
            Adress = adress;
            Type = type;
        }
        public void Input()
        {
            Console.Write("\nEnter the shop name: ");
            Name = Console.ReadLine();
            Console.Write("\nEnter the shop adress: ");
            Adress = Console.ReadLine();
            Console.WriteLine("\nChoose the shop type from the list:\n\tgrocery\n\thardware\n\tclothes");
            string typ = Console.ReadLine().ToLower();
            while (typ != "grocery" && typ != "hardware" && typ != "clothes")
            {
                Console.WriteLine("Entered type is not correct! Please choose from the list:\n\tgrocery\n\thardware\n\tclothes");
                typ = Console.ReadLine().ToLower();
            }
            Type = typ;
        }
        public void Dispose()
        {
            Console.WriteLine("Method Dispose closes all uncontrolled by GC resourses.");
        }
        ~Shop() 
        {
            Console.WriteLine("Финализатором Закрываем ресурсы!");
        }
        public override string ToString()
        {
            return $"Name: {Name}, Adress: {Adress}, Type: {Type}";
        }
    }
}
