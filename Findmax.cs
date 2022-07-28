namespace Findthemax
{
    public class findmax
    {
       
        public int findint(int num1,int num2,int num3)
        {
            if ((num1.CompareTo(num2) >= 0) && (num1.CompareTo(num3) >= 0))
                return num1;
            else if ((num2.CompareTo(num1) >= 0) && (num2.CompareTo(num3) >= 0))
                return num2;
            else if ((num3.CompareTo(num2) >= 0) && (num3.CompareTo(num1) >= 0))
                return num3;
            else
                return 0; 

                
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
                return 0;


        }
    }
}