/* using System;
namespace helloworld
{
	class Program
	{
		static void Main(string[] args)
        {
			Console.WriteLine("what is your name?");
			var name = Console.ReadLine();
			var currentDate = DateTime.Now;
			Console.WriteLine($"{Environment.NewLine}Hello, {name},on {currentDate:d} at {currentDate:t}");
			Console.Write($"{Environment.NewLine} Press any key to exit...");
			Console.ReadKey(true);
        }
	}
} */

//to print table of any number

/*using System;
namespace helloworld
{
	class Program
    {
		static void Main()
        {
			Console.WriteLine("enter a number");
			var number = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i<=10; i++)
            {
				Console.WriteLine($"{ Environment.NewLine} {number} X {i} = {number*i}");
            }
        }
    }
}
*/

//to print table of numbers between a range of numbers

/*using System;
namespace helloworld
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("enter initial number");
			var number1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("enter end number");
			var number2 = Convert.ToInt32(Console.ReadLine());
			for (int j = number1; j <= number2; j++)
            {
				for (int i = 0; i <= 10; i++)
				{
					Console.WriteLine($"{ Environment.NewLine} {j} X {i} = {j * i}");
				}
				Console.WriteLine("\n \n");
			}

		}
	}
} */

//multiplication label with limitations

/*using System;
namespace helloworld
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("enter initial number");
			var number1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("enter end number");
			var number2 = Convert.ToInt32(Console.ReadLine());
			if (number1 > number2) 
			{
				Console.WriteLine("error!! initial number should be less than end number ");
				
			}
			else if( number1 <=1 || number1 >=10 || number2 <= 1 || number2 >= 10)
			{
				
					Console.WriteLine("number must be in range 1 to 10 only ");
			}
			else
            {
				for (int j = number1; j <= number2; j++)
				{
					for (int i = 0; i <= 10; i++)
					{
						Console.WriteLine($"{ Environment.NewLine} {j} X {i} = {j * i}");
					}
					Console.WriteLine("\n \n");
				}
			}

		}
	}
} */



//factorial
/*using System;
namespace helloworld
{
	class Program
    {
		static void Main()
        {
			Console.WriteLine("enter a number");
			var n = Convert.ToInt32(Console.ReadLine());
			var factorial = n;

			if (n == 0 || n == 1)
			{
				Console.WriteLine("1");
			}
			for (int i = 1; i<=(n-1);i++)
            {
				factorial *= i;
            }
			Console.WriteLine($"factorial is {factorial}");

		}
	}
}*/


using System;
namespace helloworld
{
	class Program
	{
		static int Sum (int p , int q)
        {
			return p + q;
        }
		static int Diff(int p, int q)
		{
			return p - q;
		}
		static int Mul(int p, int q)
		{
			return p * q;
		}
		static int Divide(int p, int q)
		{
			return p / q;
		}
		static int Modulo(int p, int q)
		{
			return p % q;
		}
		static void Main()
		{
			Console.WriteLine("enter first number");
			var num1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("enter second number");
			var num2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine($"sum is:{Sum(num1, num2)} ");
			Console.WriteLine($"diff is:{Diff(num1, num2)} ");
			Console.WriteLine($"product is:{Mul(num1, num2)} ");
			Console.WriteLine($"quotient is:{Divide(num1, num2)} ");
			Console.WriteLine($"modulo is:{Modulo(num1, num2)} ");

		}
	}
}


