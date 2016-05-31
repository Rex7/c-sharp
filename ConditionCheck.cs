using System;
namespace css
{
	class Check
	{
		static void Main(string [] ss)
		{
			int no;
			char s;
			Console.WriteLine("Enter your rollno");
			 no=Convert.ToInt32(Console.ReadLine());
			if(no==69)
			{
				for(int i=0;i<10;i++)
				{
					Console.WriteLine("Index:"+i+"Entered Number is {0}",no);
					
				}
				Console.WriteLine("End of for loop");
			}
				
			else
			{
				Console.WriteLine("Wronge choice of numbers!!\nWanna try again type y or n to continue");
				 s=Convert.ToChar(Console.ReadLine());
				while(s!='n')
				{
					Console.WriteLine("Enter the y or n to continue");
					try{
					s=Convert.ToChar(Console.ReadLine());
					}
					catch (FormatException e)
					{
						Console.WriteLine("damyou cant even do one thing properly"+e);
					}
					Console.WriteLine("Press any key to exit ");
				}
				Console.ReadKey();
			}
			
		}
	}
}