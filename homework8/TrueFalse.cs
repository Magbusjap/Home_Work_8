using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace homework8
{
    //Добавлен класс Serialization для XML файлов

    class TrueFalse
    {
        string fileName;
        List<Question> list;
        public string FileName { set { fileName = value; } }

        //Конструктор, отвечающий за инициализацию Имени и путь к файлам
        public TrueFalse(string fileName)
        {
            this.fileName = fileName;
            list = new List<Question>(); //Список вопросов
        }

        //Метод, отвечающий за добавление вопросов
        public void Add(string text, bool trueFalse)
        {
            list.Add(new Question(text, trueFalse));
        }


        //Удалить вопрос
        public void Remove(int index)
        {
            if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
        }


        public Question this[int index]
        {
            get { return list[index]; }
        }

        //Метод сериализации списка вопросов
        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }

        //Десериализует список вопросов
        public void Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = (List<Question>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }

        //Свойство возвращает размер списка вопросов
        public int Count
        {
            get { return list.Count; }
        }
    }

}
