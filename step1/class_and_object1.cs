using System;
using System.CodeDom;
using System.Globalization;



namespace step1
{
     class class_and_object1
    {
        public string name;
        public int age=13;
        public static int studentid=0009;

        public void showme()
        {
            Console.WriteLine("student name :" +name);
            Console.WriteLine("student age : " + age);

        }

        public static void show()
        {
            Console.WriteLine("student id is: " +studentid);

        }

    }
     
  class student3
    {
        static void Main(string[] args)
        {
            class_and_object1 hi = new class_and_object1();
            hi.name = "kumar";
            hi.showme();
            class_and_object1.show();



            

        }

    }
}
