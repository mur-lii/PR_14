//**********************************************************
//* Практичсекая работа № 14                               *
//* Выполнила: Трухина Е.Д., группа 2ИСП                   *
//* Задание: Разработка программ с использованием структур.*
//**********************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_14
{
    internal class Program
    {
        struct Catalog
        {
            string name;
            int article;
            int price;
            string size;
            int amount;
            public Catalog(string name, int article, int price, string size, int amount)
            {
                this.name = name;
                this.article = article;
                this.price = price;
                this.size = size;
                this.amount = amount;
            }
            public void PrintInfoObjStruct() //вывод информации о структуре
            {
                Console.Write($"---Каталог женской одежды---\n{name}\nАртикул: {article}\nЦена: {price}\nРазмер: {size}\nКоличество {amount}");
            }
        }
        static void CatalogInfo()
        {
            Console.Write("Введите наименование товара: ");
            string name = Console.ReadLine();
            while (string.IsNullOrEmpty(name))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректное значение");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Попробуйте еще раз.");
                name = Console.ReadLine();
            }
            bool articleValid = false;
            while (!articleValid)
            {
                Console.Write("Введите артикул товара: ");
                string inputArticle = Console.ReadLine();
                try
                {
                    int article = Int32.Parse(inputArticle);
                    articleValid = true; // Если ошибки нет, выходим из цикла
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка: Вы ввели не число! Введите цифры.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка: Число слишком большое или маленькое.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            bool priceValid = false;
            while (!priceValid)
            {
                Console.Write("Введите цену товара: ");
                string inputPrice = Console.ReadLine();
                try
                {
                    int price = Int32.Parse(inputPrice);
                    priceValid = true; // Если ошибки нет, выходим из цикла
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка: Вы ввели не число! Введите цифры.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка: Число слишком большое или маленькое.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            Console.Write("Введите размер товара: ");
            string size = Console.ReadLine();
            while (string.IsNullOrEmpty(size))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректное значение");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Попробуйте еще раз.");
                size = Console.ReadLine();
            }
            bool amountValid = false;
            while (!amountValid)
            {
                Console.Write("Введите количество товара: ");
                string inputAmount = Console.ReadLine();
                try
                {
                    int amount = Int32.Parse(inputAmount);
                    amountValid = true; // Если ошибки нет, выходим из цикла
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка: Вы ввели не число! Введите цифры.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка: Число слишком большое или маленькое.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Практическая работа 14";

            Console.WriteLine("Здравствуй!");

            bool continueProgram = true;

            try
            {
                while (continueProgram)
                {


                    bool answerA = false;

                    while (!answerA)
                    {
                        Console.Write("\nПродолжить выполнение программы? (да/нет): ");
                        string answer = Console.ReadLine();

                        if (answer == null) answer = "";

                        if (answer.ToLower() == "да")
                        {
                            answerA = true;
                            Console.Clear();
                        }
                        else if (answer.ToLower() == "нет")
                        {
                            answerA = true;
                            continueProgram = false;
                            Console.WriteLine("Выход из программы. До свидания!");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ошибка: введите \"да\" или \"нет\".");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
            }
            catch
            {

            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
