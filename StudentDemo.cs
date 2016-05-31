using System;
namespace css
{
	class Student
	{
		private int  rollno;
		private string name;
		public Student(string name,int rollno)
		{
			this.name=name;
			this.rollno=rollno;
			
		}
		public void display()
		{
			Console.WriteLine("Name of the Student : {0} and rollno:{1}",name,rollno);
		}
		
		
	}
	class StudentDemo
	{
		public static void Main(string [] args)
		{
			
			string name;
			int roll;
			Student [] s1 = new Student[2];
			int len=s1.Length;
			Console.WriteLine(len);
			
			for(int i=0;i<len;i++)
			{
				Console.WriteLine("Enter name and roll");
				name=Console.ReadLine();
				roll=Convert.ToInt32(Console.ReadLine());
				s1[i]= new Student(name,roll);
			}
			for(int i=0;i<len;i++)
			{
				s1[i].display();
			}
			
			
		}
	}
}