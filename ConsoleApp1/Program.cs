namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10; 
            int b = 38;
            int c = (31 - 5 * a) / b;
            Console.WriteLine(c);
            Console.WriteLine("результат равен 0, поскольку операция между переменными типа int не учитывает числа после десятичной точки.")
        }
    }
}
