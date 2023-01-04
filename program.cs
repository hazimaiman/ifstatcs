using System;

namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your name: ");
            String name = Console.ReadLine();

            if (name != "") 
            {
                Console.WriteLine("Hello " + name); 

            }
            else
            {
                Console.WriteLine("you did not enter your name");
            }

            /*
              Console.WriteLine("Please enter your age: ");
             
              int age = Convert.ToInt32(Console.ReadLine());

            if (age > 99) {

                Console.WriteLine("you too old");

            }
            else if (age >= 18)
            {
                Console.WriteLine("Yo are now signed up");
            }
            else if (age < 0)
            {
                Console.WriteLine("you not born");
            }
            else
            {
                Console.WriteLine("you must be 18+");
            }
            */





            Console.ReadKey();

        }

    }

}
