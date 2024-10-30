using System;
using Tyuiu.BorkovNA.Sprint3.Task3.V24.Lib;




namespace Tyuiu.BorkovNA.Sprint3.Task3.V24
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
            Console.WriteLine("* Задание #3                                                               *");
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
            string x = Console.ReadLine();
            Console.WriteLine("* Введите replaceable =                                                     *");
            char y = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("* Введите replacement =                                                      *");
            char i = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            string res = ds.ReplaceCharInString(x, y, i);
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }

}