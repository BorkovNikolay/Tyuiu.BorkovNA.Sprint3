using System;
using Tyuiu.BorkovNA.Sprint3.Task7.V11.Lib;




namespace Tyuiu.BorkovNA.Sprint3.Task7.V11
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
            Console.WriteLine("* Задание #7                                                               *");
            Console.WriteLine("* Вариант #11                                                              *");
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
            double[] res = ds.GetMassFunction(x, y);
            for (int i=0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();

        }
    }

}