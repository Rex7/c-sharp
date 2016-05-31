using System;
namespace css
{
	class FloatAndDouble
	{
		static void Main(string [] args)
		{
			float a,b,total;
			Console.WriteLine("Enter First Float Number");
			a=Convert.ToSingle(Console.ReadLine());
			//ToSingle is just another name for float in c#
			Console.WriteLine("Enter Second Float Number");
			b=Convert.ToSingle(Console.ReadLine());
			total=a+b;
			Console.WriteLine("Total:{0}",total);
			Console.WriteLine("Type of the addition"+total.GetType());
			Console.WriteLine("End of the program press any key to exit");
			Console.ReadKey();
		}
	}
}