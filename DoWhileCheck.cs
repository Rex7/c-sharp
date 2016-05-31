using System;
namespace css
{
	class DoWhileCheck
	{
		public static void Main(string [] args)
		{
		int choice;
		do{
			Console.WriteLine("\n 1:Addition\n2:Multiplication\n3:sub");
			Console.WriteLine("Enter your Choice plz");
			choice=Convert.ToInt32(Console.ReadLine());
			switch(choice)
			{
				case 1:
				{
					Console.WriteLine("Enter first number");
					int n1=Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Enter second number");
					int n2=Convert.ToInt32(Console.ReadLine());
					int total=n1+n2;
					Console.WriteLine("addition :{0}",total);
					break;
					
				}
				case 2:
				{
					Console.WriteLine("Enter first number");
					int n1=Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Enter second number");
					int n2=Convert.ToInt32(Console.ReadLine());
					int total=n1*n2;
						Console.WriteLine("Multiplication :{0}",total);
					break;
				}
				case 3:
				{
					Console.WriteLine("Enter first number");
					int n1=Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Enter second number");
					int n2=Convert.ToInt32(Console.ReadLine());
					int total=n1-n2;
						Console.WriteLine("Substraction :{0}",total);
					break;
				}
				default:
				{
					Console.WriteLine("enter right no plz");
					break;
				}
			}
		}
		while(choice<=3);
		Console.ReadKey();
		}
	}
}