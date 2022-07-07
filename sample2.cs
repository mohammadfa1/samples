int temp=0;
for (var i = 0; i < 5; i++)
{
    System.Console.WriteLine("enter number: ");
    int num1=int.Parse(Console.ReadLine());

    System.Console.WriteLine("enter number: ");
    int num2=int.Parse(Console.ReadLine());
    temp=Math.Max(num1,num2);
}System.Console.WriteLine(temp);
