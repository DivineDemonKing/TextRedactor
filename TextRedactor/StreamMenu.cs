using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextRedactor
{
    class StreamMenu
    {
        //Выводит текст
        public void Read(string commonPath)
        {          
            FileStream sr = File.OpenRead(commonPath);

            byte[] array = new byte[sr.Length];
            sr.Read(array, 0, array.Length);

            string textFromFile = Encoding.Default.GetString(array);

            Console.WriteLine(textFromFile);

            sr.Close();
        }
        //Возвращает текст
        public string WriteToVeriable(string commonPath)
        {
            FileStream sr = File.OpenRead(commonPath);

            byte[] array = new byte[sr.Length];
            sr.Read(array, 0, array.Length);

            string textFromFile = Encoding.Default.GetString(array);

            sr.Close();

            return textFromFile;          
        }
        //ДОзаписывает текст
        public void Write(string inputText, string commonPath)
        {
            string temp = WriteToVeriable(commonPath);

            inputText = temp + inputText;

            ReWrite(inputText, commonPath);
        }

        //ПЕРЕзаписывает текст
        public void ReWrite(string inputText, string commonPath)
        {
            FileStream srew = new FileStream(commonPath, FileMode.Create);
            byte[] textInBytes = Encoding.Default.GetBytes(inputText);

            srew.Write(textInBytes, 0, textInBytes.Length);

            srew.Close();
        }
    }
}
