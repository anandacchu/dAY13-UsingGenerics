// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
namespace GenericDemo
{
    class Program
    {
        public static void toPrint(int[] inputArray)
        {
            foreach (int element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("----------------");
        }
        public static void toPrint(double[] inputArray)
        {
            foreach (double element in inputArray)
            {
                Console.Write(element);
            }
            Console.WriteLine("---------------");
        }
        public static void toPrint(char[] inputArray)
        {
            foreach (char element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("------------");
        }
        public static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            char[] charArray = { 'a', 'b', 'c', 'd' };

        }
    }