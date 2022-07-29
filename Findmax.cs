namespace Findthemax
{
    public class Findmax<T> where T:IComparable
    {   public T num1, num2, num3;
        public static T temp;
        public Findmax(T num1,T num2, T num3)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
        }

        public void TestMaximum()
        {
            var maxvalue = Findingmax(num1, num2, num3);
            printmaximum(maxvalue);
        }

        public int findint(int num1,int num2,int num3)
        {
            if ((num1.CompareTo(num2) >= 0) && (num1.CompareTo(num3) >= 0))
                return num1;
            else if ((num2.CompareTo(num1) >= 0) && (num2.CompareTo(num3) >= 0))
                return num2;
            else if ((num3.CompareTo(num2) >= 0) && (num3.CompareTo(num1) >= 0))
                return num3;
            else
                return default; 

                
        }
        public double findfloat(double num4, double num5, double num6)
        {
            if ((num4.CompareTo(num5) >= 0) && (num4.CompareTo(num6) >= 0))
                return num4;
            else if ((num5.CompareTo(num4) >= 0) && (num5.CompareTo(num6) >= 0))
                return num5;
            else if ((num6.CompareTo(num4) >= 0) && (num6.CompareTo(num5) >= 0))
                return num6;
            else
                return default;


        }

        public string findstr(string num8,string num9,string num10)
        {
            if ((num8.CompareTo(num9) >= 0) && (num8.CompareTo(num10) >= 0))
                return num8;
            else if ((num9.CompareTo(num8) >= 0) && (num9.CompareTo(num10) >= 0))
                return num9;
            else if ((num10.CompareTo(num8) >= 0) && (num10.CompareTo(num9) >= 0))
                return num10;
            else
                return default;
        }

        public static T Findingmax(params T[] ListNumbers) 
        {  

            for (int i=0;i<ListNumbers.Length-1;i++)
            {
                
                if (ListNumbers[i].CompareTo(ListNumbers[i+1])>=0)
                {
                    temp = ListNumbers[i];
                }
                else
                {
                    temp = ListNumbers[i+1];
                }
            }
            
            return temp;

        }

        public static void printmaximum(T max)
        {
            Console.WriteLine("Max = " + max);
        }
    }
}