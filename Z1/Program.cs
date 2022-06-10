int showsecdigit(int a)
{
    if(a>99 && a<1000)
    {
        return (a/10)%10;
    }
    else return -1;
}

Console.Write("Enter your number: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = showsecdigit(a);
if(result==-1)
{
    Console.WriteLine("Error");
}
else{
    Console.WriteLine("Middle digit is: "+result);
}