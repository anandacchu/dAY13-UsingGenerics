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
             //program.toprint<int>(intArray);
            //program.toprint<double>(doubleArray);
            //program.toprint<char>(charArray);

            //print<int> obj1 = new print<int>(intArray);
            //obj1.toprint();
            //print<double> obj2 = new print<double>(doubleArray);
            //obj2.toprint();
            //print<char> obj3 = new print<char>(charArray);
            //obj3.toprint();

            //int a = 20, b = 30, c =80;

            //print<int> obj1 = new print<int>();
            //int val = obj1.PrintMaximum(a, b, c);

            //Console.WriteLine(val);

            int[] arr = { 112, 334, 456, 598, 623 };
            ExtendTheMax<int> generic = new ExtendTheMax<int>(arr);
            generic.PrintMaxValue();
        }
    }
