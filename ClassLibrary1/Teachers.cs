using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Гузик Константин 31ИС

namespace ClassLibrary1
{
    // Класс предподователи
    public class Teachers: IComparable<Teachers>
    {  
        public string Name { get; set; }
        public string Cours { get; set; }
        //Конструктор
        public Teachers(string name, string cours)
        {
            Name = name;
            Cours = cours;
        }

        public void show () 
        {
            Console.WriteLine($"Имя предподователя: {Name}\n Курс: {Cours}\n");
        }
        public int CompareTo(Teachers other) 
        {
            return Name.CompareTo(other.Name);
        }
    }
}
