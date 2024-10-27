using Tyuiu.DolganovAA.Sprint3.Task0.V2.Lib;

public class Program
{
    public static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Долганов А. А. | СМАРТб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                                ");
        Console.WriteLine("* Тема: Оператор цикла for                                                 ");
        Console.WriteLine("* Задание #0                                                               ");
        Console.WriteLine("* Вариант #2                                                               ");
        Console.WriteLine("* Выполнил: Долганов А. А. | СМАРТб-24-1                                   ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 ");
        Console.WriteLine("* Написать программу используя цикл for, которая вычисляет произведение    ");
        Console.WriteLine("* ряда по формуле                                                          ");
        Console.WriteLine("*                                                                          ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        Console.WriteLine("***************************************************************************");

        int x, y;

        Console.WriteLine("* Введите значние х:                                                       ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("* Введите значние y:                                                       ");
        y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("*                                                                          ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.GetMultiplySeries(x, y));
        Console.ReadKey();
    }
}