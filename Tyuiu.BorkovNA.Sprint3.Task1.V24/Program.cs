using System;
using Tyuiu.BorkovNA.Sprint3.Task1.V24.Lib;




namespace Tyuiu.BorkovNA.Sprint3.Task1.V24
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
            Console.WriteLine("* Задание #1                                                               *");
            Console.WriteLine("* Вариант #24                                                              *");
            Console.WriteLine("* Выполнил: Борков Н. А. | пктб-24-1                                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Введите x =                                                              *");
            int x = Convert.ToInt32(Console.ReadLine());
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