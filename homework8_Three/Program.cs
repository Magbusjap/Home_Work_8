using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace homework8_Three
{
    //Михаил Анкудинов  3..

    //*Написать программу-преобразователь из CSV в XML-файл с информацией о студентах (6 урок).

    class Program
    {

        static void Converter(string fileNameOpen, string fileNameSave)
        {
            string[] lines = File.ReadAllLines(fileNameOpen);
            string[] headers = { "Имя", "Фамилия", "Уч.Заведение", "Факультет",
                "Отделение", "Возвраст", "Курс", "Группа", "Город" };

            var xml = new XElement("Students",
               lines.Where((line, index) => index > 0).Select(line => new XElement("StudentIndo",
                  line.Split(';').Select((column, index) => new XElement(headers[index], column)))));

            xml.Save(fileNameSave);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует конвертер расширений из CSV в XML-файл." +
                "\nКонвертируем информацию о студентах...");

            Converter("..\\..\\students.csv", "..\\..\\students.xml");

            Console.WriteLine("Работа программы завершена!");
            Console.ReadLine();
        }
    }
}
