using System;
using Tyuiu.BorkovNA.Sprint3.Task2.V13.Lib;




namespace Tyuiu.BorkovNA.Sprint3.Task2.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Cпринт #2 | Выполнил: Борков Н. А. | пктб-24-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #3                                                                *");
            Console.WriteLine("* Тема:                                                                    *");
            Console.WriteLine("* Задание #2                                                               *");
            Console.WriteLine("* Вариант #13                                                              *");
            Console.WriteLine("* Выполнил: Борков Н. А. | пктб-24-1                                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Введите x =                                                              *");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("* Введите startValue =                                                     *");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Введите stopValue =                                                      *");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            double res = ds.GetSumSeries(x, y, i);
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }

}