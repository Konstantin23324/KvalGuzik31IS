using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Гузик Константин 31ИС

namespace ClassLibrary1
{
    // Классс Колледж
    public class College
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Teachers> Teachers = new List<Teachers> ();

        //Конструктор
        public College(string name, string address)
        {
            Name = name;
            Address = address;
        }
        //Метод, позволяющий вывести информацию
        public void ShowAll()
        {
            Console.WriteLine($"Информация о колледже:\n" +
                $"Название: {Name}\n" +
                $"Адрес: {Address}\n\n");
            Teachers.Sort();
            foreach (Teachers t in Teachers)
            {
                t.show();
            }
        }
    }
}
