using System.Text;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DolganovAA.Sprint3.Task3.V27.Lib
{
    public class DataService : ISprint3Task3V27
    {
        public int ConvertStringToInt(string input)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    result.Append(c);
                }
            }

            return int.TryParse(result.ToString(), out int number) ? number : 0;
        }
    }
}
