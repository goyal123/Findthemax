namespace Findthemax
{
    public class findmax
    {
        public int find(int num1,int num2,int num3)
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
    }
}