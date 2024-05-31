using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
    {
        var списокСтудентов = new СписокСтудентов
        {
            Студенты = new List<Студент>
            {
                new Студент { ФИО = "Иванов Иван Иванович", Курс = "1", Оценки = new List<byte> { 5, 4, 3, 2, 1 } },
                new Студент { ФИО = "Петров Петр Петрович", Курс = "2", Оценки = new List<byte> { 5, 5, 5, 5, 5 } },
                new Студент { ФИО = "Сидоров Сидор Сидорович", Курс = "1", Оценки = new List<byte> { 4, 4, 4, 4, 4 } }
            }
        };

        foreach (var студент in списокСтудентов.Студенты)
        {
            студент.РасчетСтипендии();
            Console.WriteLine($"Студент: {студент.ФИО}, Курс: {студент.Курс}, Стипендия: {студент.Стипендия}");
        }

        списокСтудентов.СортироватьПоФИО();
        Console.WriteLine("Список студентов после сортировки по ФИО:");
        foreach (var студент in списокСтудентов.Студенты)
        {
            Console.WriteLine(студент.ФИО);
        }

        var двоечники = списокСтудентов.НайтиДвоечников("1");
        Console.WriteLine("Двоечники на 1 курсе:");
        foreach (var студент in двоечники)
        {
            Console.WriteLine(студент.ФИО);
        }
    }
     
    }
}
