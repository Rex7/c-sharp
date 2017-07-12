using System;
public class StudentDemo{

static void Main(string [] args){
	Students[] s = new Students[2];
	for(int i=0;i<2;i++){
		s[i]=new Students();
	}
	for(int i=0;i<2;i++){
		s[i].read();
		s[i].display();
	}
}
struct Students{
	int student_id;
	string student_name,cource_name,dateofbirth;
	public void read(){
		Console.WriteLine("Enter user  id");
		student_id=Convert.ToInt32((Console.ReadLine()));
		Console.WriteLine("Enter Student Name ");
		student_name=Console.ReadLine();
		Console.WriteLine("Enter Cource ");
		cource_name=Console.ReadLine();
		Console.WriteLine("Enter dateofbirth");
		dateofbirth=Console.ReadLine();
	}
	public void display(){
		Console.WriteLine("student_id {0} \n Student Name {1} \n Cource {2} \n DateofBirth {3}",student_id,student_name,
		cource_name,dateofbirth);
	
	}
}
}