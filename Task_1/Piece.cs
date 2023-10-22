using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 1:
//Створіть клас «П'єса», який має зберігати таку інформацію:
// назва п'єси;
// П.І.Б. автора;
// жанр;
// рік.
//Реалізуйте у класі методи та властивості, необхідні для 
//функціонування класу.
//Додайте до класу деструктор. Напишіть код для тестування 
//функціональності класу.
//Напишіть код для деструктора.
namespace Task_1
{
    internal class Piece: IDisposable
    {
        public string name;
        public string author;
        public string genre;
        public int year;
        public string Name
        {
            get { return name; }
            set
            {
                if (value == "")
                    throw new Exception("Ошибка! Имя пъесы не может быть пустым.");
                else
                    name = value;
            }
        }
        public string Author
        {
            get { return author; }
            set
            {
                if (value == "")
                    throw new Exception("Ошибка! Имя автора не может быть пустым.");
                else
                    author = value;
            }
        }
        public string Genre { get; set; }
        public int Year 
        {
            get { return year; }
            set
            {
                if (value <0)
                    throw new Exception("Ошибка! Год не может быть отрицательным.");
                else
                    year = value;
            }
        }

        public Piece() { }

        public Piece(string name, string author, string genre, int year)
        {
            this.Name = name;
            this.Author = author;
            this.genre = genre;
            this.Year = year;
        }

        public void Dispose()
        {
            Console.WriteLine("Metod Dispose closes all resources.");
        }
        ~Piece()
        {
            Console.WriteLine("Финализатором Закрываем ресурсы!");
        }
        public override string ToString()
        {
            return $"Name: {Name}, Autor: {Author}, Genre: {genre}, Year: {Year}";
        }
    }
}
