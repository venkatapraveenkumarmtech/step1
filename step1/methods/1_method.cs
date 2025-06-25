using System;
using System.Data;





class _1_method
{
    static void Main(string[] args)
    {
       
       int sum= add(6,7);
        Console.WriteLine(sum);

        evennumber();

    }
    static int add(int a, int b)
    {
       
        
        return a+b;
    }
    static void evennumber()

    {
        int mynumber = 1;
        while(mynumber<=20)
        {
            if(mynumber%2==1)
            {
                Console.WriteLine("my odd numbers is  : "+mynumber);
            }

            mynumber ++;
        }
    }
}

