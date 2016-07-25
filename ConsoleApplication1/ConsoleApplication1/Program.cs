using System;

namespace Udemy_1
{
    class Program
    {
        public static void byReference(ref int num1, ref int num2)
        {
            num1 = 1;
            num2 = 2;
        }

        public static void byValue(int number1, int number2)
        {
            number1 = 15;
            number2 = 25;
        }


        static void Main(string[] args)
        {
            MyClass ob; // declaration of an object


            int myNumber1 = 100;
            int myNumber2 = 200;
            // Why do I need to declare static in order to use in Main?!

            byReference(ref myNumber1, ref myNumber2);

            Console.WriteLine("Numbers value after using byReference are {0} and {1}", myNumber1, myNumber2); // string formatting


            myNumber1 = 100;
            myNumber2 = 200;

            byValue(myNumber1, myNumber2);
            Console.WriteLine("Numbers value after using byValue are {0} and {1}", myNumber1, myNumber2);


            Console.ReadKey();

            ob = new MyClass(); // class initialization
            Console.WriteLine(ob.getStr());
            Console.WriteLine("Setting a new string , press Enter!");
            Console.ReadKey();
            ob.setStr("A new String");
            Console.WriteLine("New string is - '{0}'",ob.getStr());
            Console.ReadKey();


        }
    }
}
