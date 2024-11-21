namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }
        
        public static decimal Add(decimal numOne, decimal numTwo)
        {
            return numOne + numTwo;
        }
        
        public static string Add(int numOne, int numTwo, bool isCurrency)
        {
            var sum = numOne + numTwo;

            if (isCurrency && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isCurrency && sum == 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return sum.ToString();
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1,0, true));
            var x = 1;
            var y = 2;
            var answer = Add(x, y);

            var a = 5.2m;
            var b = 2.0m;
            var decimalAnswer = Add(a, b);

            Console.WriteLine($"int addition: {answer}, decimal addition: {decimalAnswer}");
        }
    }
}
