using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class СписокСтудентов
    {
        public List<Студент> Студенты { get; set; }

        public void СортироватьПоФИО()
        {
            Студенты = Студенты.OrderBy(s => s.ФИО).ToList();
        }

        public List<Студент> НайтиДвоечников(string курс)
        {
            return Студенты.Where(s => s.Курс == курс && s.Оценки.Contains(2)).ToList();
        }
    }
}
