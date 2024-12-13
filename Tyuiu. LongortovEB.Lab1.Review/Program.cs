
using Tyuiu._LongortovEB.Lab1.Review.V4.Lib;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Лонгортов Е. Б. | НТм-23-1";
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("* Спринт #1                                                                  *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                    *");
        Console.WriteLine("* Задание #1                                                                 *");
        Console.WriteLine("* Вариант #4                                                                *");
        Console.WriteLine("* Выполнил: Лонгортов Егор Борисович | НТм-23-1                           *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                   *");
        Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по          *");
        Console.WriteLine("* исходным значениям данных, вводимых пользователем. Ответ округлите до      *");
        Console.WriteLine("* знаков после запятой.                                                      *");
        Console.WriteLine("*                                                                            *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                          *");
        Console.WriteLine("******************************************************************************");
        double x = Convert.ToDouble(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine(ds.Calc(x, y));
        Console.ReadKey();
    }

}