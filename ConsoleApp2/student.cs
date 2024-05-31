using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Студент
    {
        public string ФИО { get; set; }
        public string Курс { get; set; }
        public double Стипендия { get; set; }
        public List<byte> Оценки { get; set; }

        public void РасчетСтипендии()
        {
            if (Оценки.Contains(2))
            {
                Стипендия = 0;
            }
            else if (Оценки.Contains(3) && !Оценки.Contains(2))
            {
                Стипендия = 1000;
            }
            else if (Оценки.Min() == 4)
            {
                Стипендия = 1500;
            }
            else if (Оценки.All(o => o == 5))
            {
                Стипендия = 2500;
            }
        }
    }
}
