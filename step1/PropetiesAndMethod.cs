using System;
using System.Web;




internal class PropetiesAndMethod
    {
    static void Main(string[] args)
    {
        //uppercase
        string name = "praveen";
        string other = name.ToUpper();
        Console.WriteLine(other);

        //Trim
        string empname = "@@@@@@@praveenkumar@@@@@@@@@@@";
        string emp1 = empname.TrimEnd('@');
        Console.WriteLine(emp1);


        //padding

        string empname5 = "praveen";
        string updatedempname5 = empname5.PadLeft(20, '&');
        Console.WriteLine(updatedempname5);

        //equals

        string username = "praveenfullstack";
        bool isequal=username.Equals("praveen.fullstack");
        Console.WriteLine(isequal);

        //substring

        string line = "hi every one today we will discuss about the substring concept";
        string substring = line.Substring(8, 12);
        Console.WriteLine(substring);

        //spilt

        string tiffin = "idly,dosa,poori,pongal,pesarattu";
        string[] dailytiffin = tiffin.Split(',');
        Console.WriteLine(dailytiffin);

        //Replace

        string real = "hi everyone today we were sitting infornt you that is only reason is job";
        string real2 = real.Replace("were", "are");
        Console.WriteLine(real2);

        //format

        int items = 25;
        double rate = 10.50;
        double total = items * rate;
        string bill = string.Format("my number of items is {0} * {1} quantity of items=total is  {2}",items,rate,total);
        Console.WriteLine(bill);


    }
}

