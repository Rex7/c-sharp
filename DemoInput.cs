using System;
namespace css
{
class DemoInput
{
	static void Main(string [] args)
	{
		Console.WriteLine("Enter value of first number");
		int number=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter Value of Second Number");
		int number2 = Convert.ToInt32(Console.ReadLine());
		int total=number+number2;
		Console.WriteLine("addition of: {0} , number2{1} is {2}",number,number2,total);
		Console.WriteLine(number.GetType());
		Console.ReadKey();
	}
}
}