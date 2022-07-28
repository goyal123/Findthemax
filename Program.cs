namespace Findthemax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            double num4, num5, num6;
            string num8, num9, num10;
            Console.WriteLine("Welcome to the Find Max Program ");
            findmax obj = new findmax();

            Console.WriteLine("Max = "+obj.findint(num1 = 30, num2 = 10, num3 = 20));
            
            Console.WriteLine("Max float = "+obj.findfloat(num4 = 10.5, num5 = 10.6, num6 = 10.7));

            Console.WriteLine("Max string = " + obj.findstr(num8 = "Apple", num9 = "Peach", num10 = "Banana"));
        }
    }
}