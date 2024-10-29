using Tyuiu.DolganovAA.Sprint3.Task1.V29.Lib;

public class Program
{
    public static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Долагнов А. А. | СМАРТб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла for                                                *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #29                                                             *");
        Console.WriteLine("* Выполнил: Долагнов А. А. | СМАРТб-24-1                                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу используя цикл while, которая вычисляет произведение *");
        Console.WriteLine("* ряда по формуле, при х=0,25                                             *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");


        int x, y;
        Console.WriteLine("* Введите значние х:                                                      *");
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("* Введите значние y:                                                      *");
        y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("* Введите значение z:                                                     *");
        double z = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.GetMultiplySeries(z, x, y));
        Console.ReadKey();
    }
}