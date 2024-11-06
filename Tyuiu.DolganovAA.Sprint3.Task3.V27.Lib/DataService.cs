using System.Text;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DolganovAA.Sprint3.Task3.V27.Lib
{
    public class DataService : ISprint3Task3V27
    {
        public string ExtractDigits(string input)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }

        public int ConvertToInt(string digits)
        {
            return int.TryParse(digits, out int number) ? number : 0;
        }
    }
}
