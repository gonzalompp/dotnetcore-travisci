
namespace Calculator
{
    public class Calculator
    {
		public static int Add(int num1, int num2 )
		{
		return num1 + num2;
		}

		public static int Subtract(int num1, int num2 )
		{
			if ( num1 > num2 )
			{
				return num1 - num2;
			}
			return num2 - num1;
		}
    }
}
