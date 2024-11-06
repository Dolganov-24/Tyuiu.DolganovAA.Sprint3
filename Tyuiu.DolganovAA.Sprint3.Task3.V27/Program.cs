using Tyuiu.DolganovAA.Sprint3.Task3.V27.Lib;
namespace Tyuiu.DolganovAA.Sprint3.Task3.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Долганов А.А. | СМАРТб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема:  Оператор цикла foreach                                           *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Долганов Александр Анатольевич | СМАРТб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл foreach удалить все буквы и знаки     *");
            Console.WriteLine("* препинания, оставить цифры затем преобразовать в число в строке:        *");
            Console.WriteLine("* !bt, gt567kidf!                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string digits = ds.ExtractDigits(input);
            int number = ds.ConvertToInt(digits);

            Console.WriteLine($"Извлеченные цифры: {digits}");
            Console.WriteLine($"Преобразованное число: {number}");
            Console.ReadKey();
        }
    }
}
