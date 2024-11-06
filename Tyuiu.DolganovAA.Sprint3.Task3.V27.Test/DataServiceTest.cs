using Tyuiu.DolganovAA.Sprint3.Task3.V27.Lib;
namespace Tyuiu.DolganovAA.Sprint3.Task3.V27.Test
{
    public class StringProcessorTests
    {
        
        [Fact]
        public void ExtractDigits_ShouldReturnOnlyDigits()
        {
            var processor = new DataService();
            string input = "!bt, g567kid f!";

            string result = processor.ExtractDigits(input);

            Assert.Equal(567, result);
        }

        [Fact]
        public void ConvertToInt_ShouldReturnCorrectInteger()
        {
            var processor = new DataService();
            string digits = 567;

            int result = processor.ConvertToInt(digits);

            Assert.Equal(567, result);
        }

        [Fact]
        public void ConvertToInt_ShouldReturnZeroForEmptyString()
        {
            var processor = new DataService();
            string digits = 0;

            int result = processor.ConvertToInt(digits);

            Assert.Equal(0, result);
        }
    }
}