using System;
class Fibo{
static void Main(string[] args){
int n1=0,n2=1,n3;
for(int i=1;i<100;i++){
n3=n1+n2;
n1=n2;
n2=n3;
Console.WriteLine("{0} ",n3);
}
}
}