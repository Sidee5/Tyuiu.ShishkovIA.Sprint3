using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShishkovIA.Sprint3.Task5.V20.Lib;

namespace Tyuiu.ShishkovIA.Sprint3.Task5.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService DataService = new DataService();

            Console.Title = "Спринт 3. Выполнил: Шишков И.А. | АСОиУб-23-2";
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* Спринт #3                                                     ");
            Console.WriteLine("* Тема: Вложенные циклы                                         ");
            Console.WriteLine("* Задание #5                                                    ");
            Console.WriteLine("* Вариант #20                                                   ");
            Console.WriteLine("* Выполнил: Шишков Илья Александрович | АСОиУб-23-2             ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("На отрезке, где x = 5, вычислить значение функции"               );
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("*X = 5                                                          ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");

            double res = DataService.GetSumSumSeries(5, 1, 1, 3, 6);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
