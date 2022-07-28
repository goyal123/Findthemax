namespace Findthemax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Welcome to the Find Max Program ");
            findmax obj = new findmax();
            Console.WriteLine("Max = "+obj.find(num1 = 10, num2 = 10, num3 = 10));

        }
    }
}