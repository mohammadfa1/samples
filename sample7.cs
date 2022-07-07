int num,di,counter=0;
System.Console.WriteLine("enter number: ");
num=int.Parse(Console.ReadLine());
for (int i=num; num>=1;i++)
{
    counter++;
  num=num/10;
    
}System.Console.WriteLine(counter);
