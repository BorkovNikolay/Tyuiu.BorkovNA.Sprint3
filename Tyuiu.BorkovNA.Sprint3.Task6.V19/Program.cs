using System;
using Tyuiu.BorkovNA.Sprint3.Task6.V19.Lib;




namespace Tyuiu.BorkovNA.Sprint3.Task6.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Cпринт #2 | Выполнил: Борков Н. А. | пктб-24-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #3                                                                *");
            Console.WriteLine("* Тема: Операции сравнения                                                 *");
            Console.WriteLine("* Задание #5                                                               *");
            Console.WriteLine("* Вариант #15                                                              *");
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
            Console.WriteLine("* Введите y =                                                              *");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            double res = ds.GetSumTheDivisors(x, y);
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }

}