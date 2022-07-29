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
            Console.WriteLine("-----------------------------------------");

            Findmax<int> obj1 = new Findmax<int>(num1 = 30, num2 = 10, num3 = 20);
            obj1.TestMaximum();
            Findmax<double> obj2 = new Findmax<double>(num4 = 10.5, num5 = 10.6, num6 = 10.7);
            obj2.TestMaximum();
            Findmax<string> obj3 = new Findmax<string>(num8 = "Apple", num9 = "Peach", num10 = "Banana");
            obj3.TestMaximum();


            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Max = " + Findmax<int>.Findingmax(30,10,20));
            Console.WriteLine("Max = " + Findmax<double>.Findingmax(10.5, 10.6, 10.7));
            Console.WriteLine("Max = " + Findmax<string>.Findingmax("Apple","Banana","Peach"));
        }
    }
}