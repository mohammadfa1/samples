int num1,num2,max,max2;
System.Console.WriteLine("enter number: ");
num1=int.Parse(Console.ReadLine());
num2=int.Parse(Console.ReadLine());
if(num1>num2){
    max=num1;
    max2=num2;
}else{
    max=num2;
    max2=num1;
}
for (var i = 0; i < 8; i++)
{
    System.Console.WriteLine("enter number: ");
num1=int.Parse(Console.ReadLine());
if(num1>max){
  max2= max; 
max=num1;
}else if(num1>max2)
{
    max2=num1;
}
}System.Console.WriteLine(max+" "+max2);
