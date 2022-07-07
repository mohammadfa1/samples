int num,temp,di,larg=0;
System.Console.WriteLine("enter number: ");
num=int.Parse(Console.ReadLine());
for (var i = 0; i %10==0; i++)
{
  di=num%10;
larg=Math.Max(di,larg);
num=num/10;

}System.Console.WriteLine(larg);
