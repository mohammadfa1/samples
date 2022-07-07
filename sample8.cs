int num,di,sum=0;
System.Console.WriteLine("enter numer: ");
num=int.Parse(Console.ReadLine());
for(var i = num; num!=0; i++){
    di=num%10;
    sum=sum+di;
    num=num/10;
}System.Console.WriteLine(sum);
