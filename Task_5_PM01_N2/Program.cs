using System;
using System.Net.Http.Headers;

namespace Variant10
{
	class Program
	{
		static double f(double x)
		{
			try
			{
				if (x == 2) throw new Exception();
				else return Math.Log(Math.Abs(x - 2));
			}
			catch
			{
				throw;
			}
		}

		static void Main()
		{
			try
			{
				Console.Write("Введите a: ");
				double a = Convert.ToDouble(Console.ReadLine());
				Console.Write("Введите b: ");
				double b = Convert.ToDouble(Console.ReadLine());
				Console.Write("Введите h: ");
				double h = Convert.ToDouble(Console.ReadLine());

				for(double i = a; i <= b; i += h)
				{
					try
					{
						Console.WriteLine("y({0}) = {1:f4}", i, f(i));
					}
					catch
					{
						Console.WriteLine("y({0}) = error", i);
					}
				}
			}
			catch(FormatException)
			{
				Console.WriteLine("Введены неверные данные!");
			}
			catch
			{
				Console.WriteLine("Ошибка");
			}
		}
	}
}