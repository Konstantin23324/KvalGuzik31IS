using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Kval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            College college = new College("1 МОК" , "староватутинский 6");
            college.Teachers.Add(new Teachers("Вейнгерова Екатерина Дмитриевна", "Управление проектом"));
            college.Teachers.Add(new Teachers("Тузовский Анатолий Фёдорович", "ТРПО"));
            college.Teachers.Add(new Teachers("Журавлев Даниил Никитич", "ТИС"));
            college.Teachers.Add(new Teachers("Завьялова Елена Владимировна", "УиАБД"));
            college.Teachers.Add(new Teachers("Тиханова Ангелина Владимировна", "УиАБД"));
            college.ShowAll();
            Console.ReadLine();
        }
    }
}
