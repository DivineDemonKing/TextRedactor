using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRedactor
{
    class MenuConsoleLaunch
    {
        public void MenuText()
        {
            Console.WriteLine($"cd Переместиться к папке по полному пути " +
               $"\ncd.. Переместиться на 1 уровень вверх \ndir Показать содержимое папки " +
               $"\nfdir Показать полную информацию о содержимом папки" +
               $"\nexit Выйти из кносоли");
        }

        public void Launch()
        {
            Menu menu = new Menu();
            MenuText();

            string path = @"C:\";
            bool userWantExit = false;
            string inputIndex;

            MenuConsole menuConsole = new MenuConsole();

            while (!userWantExit)
            {
                Console.WriteLine(path);
                inputIndex = Console.ReadLine();
                switch (inputIndex)
                {
                    //Перемещается к папке по относительному/полному пути
                    case "cd":
                        {
                            path = menuConsole.cd(path);
                            break;
                        }

                    //Перемещается на 1 уровень вверх
                    case "cd..":
                        {
                            path = menuConsole.oneLvLUp(path);
                            break;
                        }

                    //Показывает содержание папок
                    case "dir":
                        {
                            menuConsole.GetNameDirectories(path);
                            menuConsole.GetNameFiles(path);
                            break;
                        }
                    //Показывает полную информацию о папках и файлах (Название, Дата создания, Дата последнего изменения для папок;
                    //Название, Размер в кб, Дата создания, Дата последнего изменения для файлов)
                    case "fdir":
                        {
                            menuConsole.GetFullInfoDirectories(path);
                            menuConsole.GetFullInfoFiles(path);
                            break;
                        }
                    //Выход
                    case "exit":
                        {
                            userWantExit = true;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                Console.WriteLine("Нажмите Enter для продолжения");
                Console.ReadLine();
                Console.Clear();
                MenuText();
            }
        }
    }
}
