int isoffday(int a)
{
    if(a<=5 && a>0)
    {
       return 0;
    }
    else if(a==6 || a==7)
    {
        return 1;
    }
    else return -1;
}



Console.Write("Enter your number: ");
int a = Convert.ToInt32(Console.ReadLine());
int day = isoffday(a);
Console.Write("This day is");
if(day == 0)
{
    Console.Write(" weekday. ");
}
else if(day == 1)
{
    Console.Write(" off day! :)");
}
else
{
    Console.Write("... Something went wrong. Enter number again.");
}