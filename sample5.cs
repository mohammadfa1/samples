int num,counter=0;
int sum=0;
for(int i=0 ; i<10 ; i++){
System.Console.WriteLine("enter num: ");
num=int.Parse(Console.ReadLine());
if(num>=15){
sum=sum+num;
counter++;
}
}System.Console.WriteLine(sum/counter);
