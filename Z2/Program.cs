int showthrddigit(int x)
{
    if(x<100 ^ x<-100)
    {
        return -1;
    }
    else 
    {
        if(x>=0) 
        {
            while(x>999)
            {
                x = x/10;
            }
                return x%10;
        }
        else 
        {
            while(x<-999)
            {
                x = x/10;
            }
            return -1*(x%10);
        }
    }
}

Console.Write("Enter your number: ");
int a = Convert.ToInt32(Console.ReadLine()); 
int result = showthrddigit(a);
if(result==-1)
{
    Console.WriteLine("Error");
}
else{
    Console.WriteLine("Third digit is: "+result);
}