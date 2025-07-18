using System;




class Task
{
    static void Main(string[] args)
    {
        string[] employee = { "Jhon", "Robert", "Chandra", "Peter" };
        //Console.WriteLine(employee[2]);
        //Console.WriteLine((employee[1] == employee[2]));
        Console.WriteLine("who's name is starting with 'j' ");
        foreach (string emp in employee)
        {
            if ((emp[0] == 'J'))
            {
                Console.WriteLine(emp);
            }


        }

        //string[] employee2 = employee.split(',');
        //Console.WriteLine(employee2);
    }
}


