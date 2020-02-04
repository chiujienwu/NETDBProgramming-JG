using System;

namespace YourName
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*            // display a literal value
                        Console.WriteLine("What is your name?");
                        // input a value and assign it to a string variable
                        string name = Console.ReadLine();
                        // display the string variable
                        Console.WriteLine("Hello, " + name);
                        Console.WriteLine("Hello, {0}", name);*/
            try
            {
                Console.WriteLine("Enter number one:");
                var number1 = Console.ReadLine();
                Console.WriteLine("Enter number two:");
                var number2 = Console.ReadLine();

                int result = 0;
                var isValidx = int.TryParse(number1, out int x);
                var isValidy = int.TryParse(number2, out int y);

                if (isValidx && isValidy)
                {
                    result = x + 7;
                }

                Console.WriteLine($"Your answer is: {result}" );

            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
