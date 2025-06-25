using System;



class converstions
{
    static void Main(string[] args)
    {
        //int to byte
        int emp = 400;
        byte noofemp=(byte)emp;
        Console.WriteLine(noofemp);

        //double to int
        double price = 80.45;
        int value=(int)price;
        Console.WriteLine(value);

        //int to double
        int number1 = 25;
        double converted = number1;
        Console.WriteLine(converted.GetType());

        //int to string
        int number2 = 42;
        string name=number2.ToString();
        Console.WriteLine(name.GetType());
        Console.WriteLine(name);

        //string to int
        string name4 = "67";
        int myname=int.Parse(name4);
        Console.WriteLine(myname);

        //another method for convert into string to int

        string name5 = "56";
        int conver=Convert.ToInt32(name5);
        Console.WriteLine(conver);


        //datetime


        DateTime date = DateTime.Now;
        Console.WriteLine(date);

    }
}

