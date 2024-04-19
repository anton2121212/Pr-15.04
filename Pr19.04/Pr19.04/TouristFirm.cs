using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr19._04
{
    class TouristFirm
    {
        /// <summary>
        /// создаем поле имени
        /// </summary>
        string name;
        /// <summary>
        /// создаем поле год создания
        /// </summary>
        int year;
        /// <summary>
        /// создаем поле ИНН
        /// </summary>
        string inn;
        /// <summary>
        /// создаем поле прибыли за год
        /// </summary>
        double profit;


        /// <summary>
        /// свойства для поля имени
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// свойства для поля год создания
        /// </summary>
        public int Year { get; set; }
        /// <summary>
        /// свойства для поля ИНН
        /// </summary>
        public string INN { get; set; }
        /// <summary>
        /// свойства для поля прибыли
        /// </summary>
        public double Profit { get; set; }


        /// <summary>
        /// конструктор без параметров 
        /// </summary>
        public TouristFirm() { }


        /// <summary>
        /// конструктор с параметрами 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="year"></param>
        /// <param name="inn"></param>
        /// <param name="profit"></param>
        public TouristFirm(string name, int year, string inn, double profit)
        {
            Name = this.name;
            Year = this.year;
            INN = this.inn;
            Profit = this.profit;

        }
        
        /// <summary>
        /// метод для вывода информации
        /// </summary>
        public void Info()
        {
            Console.WriteLine($"Название {Name}\n год создания {Year}\n ИНН {INN}\n  прибыль за текущий год {Profit}");
        }
    }
}
