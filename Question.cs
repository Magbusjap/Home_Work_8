using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework8
{

    //Сериализация XML файлов
    [Serializable]
    public class Question
    {
        string text;    //Вопрос   
        bool trueFalse; //Правда 

        //Отвечает за вопросы
        public string Text 
        { 
            get { return text; } 
            set 
            { 
                if (value.GetType() == typeof(string)) text = value; 
            } 
        }

        //Отвечает за вывод правды
        public bool TrueFalse 
        { 
            get { return trueFalse; } 
            set 
            { 
                if (value.GetType() == typeof(bool)) trueFalse = value; 
            } 
        }


        //Конструктор для Сериализации System.Xml.Serialization => TrueFalse
        public Question()
        {
        }


        public Question(string text, bool trueFalse)
        {
            this.text = text;
            this.trueFalse = trueFalse;
        }
    }

}
