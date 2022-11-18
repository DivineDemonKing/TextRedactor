using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextRedactor
{
    class MenuConsole
    {
        //Метод для изменения пути (относительного/абсолютного)
        public string cd(string path)
        {
            string tempPath = Console.ReadLine();
            if (tempPath.Contains(":"))
            {
                path = tempPath;
            }
            else
            {
                path = path + "\\" + tempPath;
            }
            return path;
        }
        //Подняться на 1 уровень выше
        public string oneLvLUp(string path)
        {
            path = $"{Directory.GetParent(path)}";
            return path;
        }
        //Получает имена Папок (директорий)
        public void GetNameDirectories(string path)
        {
            string[] dirs = Directory.GetDirectories(path);
            foreach (string d in dirs)
            {
                Console.WriteLine(d);
            }
        }
        //Получает имена файлов
        public void GetNameFiles(string path)
        {
            string[] files = Directory.GetFiles(path);
            foreach (string f in files)
            {
                Console.WriteLine(f);
            }
        }
        //Получает расширенную информацию о файлах
        public void GetFullInfoFiles(string path)
        {
            FileInfo fileInfo;
            string[] dirs = Directory.GetDirectories(path);
            foreach (string d in dirs)
            {
                fileInfo = new FileInfo(d);
                Console.WriteLine($"Название {d}");
                Console.WriteLine($"Дата создания каталога {fileInfo.CreationTime}");
                Console.WriteLine($"Дата последнего изменения {fileInfo.LastWriteTime}");
            }

        }
        //Получает расширенную информацию о директориях
        public void GetFullInfoDirectories(string path)
        {
            FileInfo fileInfo;
            string[] files = Directory.GetFiles(path);
            foreach (string f in files)
            {
                fileInfo = new FileInfo(f);
                Console.WriteLine($"Название {f}");
                Console.WriteLine($"Размер в кб {fileInfo.Length}");
                Console.WriteLine($"Дата создания файла {fileInfo.CreationTime}");
                Console.WriteLine($"Дата последнего изменения{fileInfo.LastWriteTime}");
            }
        }
    }
}
