using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace TextRedactor
{
    public class Menu
    {
        //Блок для смены пути

        public string ChangePath()
        {
            string newPath;

            Console.WriteLine("Введите новый путь файла");
            newPath = Console.ReadLine();

            return newPath;
        }
        /* Метод который позволяет вручную не вводить путь к файлу через консоль
        public string ChangePath2(string Path)
        {
            string newPath;
            newPath = Path;

            return newPath;
        }
        */
        public void WithdrawMenu()
        {
            string commonPath = @"C:\Hello\World.txt";
            string text;

            string imputIndex = Console.ReadLine();

            Menu program = new Menu();

            StreamMenu streamMenu = new StreamMenu();
            Console.Clear();
            Console.WriteLine("Введите действие с файлом\n " +
                "1)Прочитать файл\n " +
                "2)Записать файл\n " +
                "3)Дозаписать в существующий файл\n " +
                "0)Сменить путь файла введите\n " +
                "00) Перейти в режим Просмотра файлов");

            bool userWantExit = false;
            while (!userWantExit)
            {
                imputIndex = Console.ReadLine();
                switch (imputIndex)
                {
                    //Прочитать файл
                    case "1":
                        {
                            Console.Clear();

                            Console.WriteLine("Текст файла:");
                            streamMenu.Read(commonPath);
                            break;
                        }
                    //ПереЗаписать файл
                    case "2":
                        {
                            Console.Clear();

                            Console.WriteLine("Введите текст который хотите записать");
                            text = Console.ReadLine();
                            streamMenu.ReWrite(text, commonPath);
                        }
                        break;
                    //ДОзаписать файл
                    case "3":
                        {
                            Console.Clear();

                            Console.WriteLine("Введите текст который хотите дозаписать");
                            text = Console.ReadLine();
                            Console.Clear();
                            streamMenu.Write(text, commonPath);

                            Console.WriteLine("Текст файла: ");
                            streamMenu.Read(commonPath);
                            break;
                        }
                    case "0":
                        {
                            commonPath = program.ChangePath();
                            break;
                        }
                    case "00":
                    case "exit":
                        {
                            userWantExit = true;
                            break;
                        }
                }
            }
            MenuConsoleLaunch menuConsoleLaunch = new MenuConsoleLaunch();

            if (imputIndex == "00")
            {
                menuConsoleLaunch.Launch();
            }
        }
    }
}
