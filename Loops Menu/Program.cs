namespace Loops_Menu
{
    internal class Program
    {
        public static void menu()
        {
            int selection;

            Console.WriteLine("Welcome to the loop menu for assignment 6. Please enter the number corresponding to the program you want to run.");
            Console.WriteLine();
            Console.WriteLine("1. Prompter\n\r2. Percent Passing\n\r3. OddSum\n\r4. Random Numbers");
            Console.WriteLine();
            selection = Convert.ToInt32(Console.ReadLine());


            if (selection == 1)
            {
                Console.Clear();
                prompt();
            }
            else if (selection == 2)
            {
                Console.Clear();
                prcnt();
            }
            else if (selection == 3)
            {
                Console.Clear();
                odd();
            }
            else if (selection == 4)
            {
                Console.Clear();
                rndm();
            }
            else
            {
                Console.Clear();
                menu();
            }

        }

        public static void prompt()
        {
            double min, max, selection;

            Console.WriteLine("Please enter a number that will be your minimum value. Decimals are permitted.");
            Console.WriteLine();
            min = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Please enter a number that will be your maximum value. Decimals are permitted.");
            Console.WriteLine();
            max = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Please enter a number that is in between you minimum and maximum values.");
            Console.WriteLine();
            selection = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            while (selection > max || selection < min)
            {
                Console.WriteLine("That is not a valid entry, please try again:");
                Console.WriteLine();
                selection = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Your number is: " + selection + ". Press 'enter' to return to the loop menu.");
            Console.ReadLine();
            Console.Clear();
            menu();
        }

        public static void prcnt()
        {
            double entry, above70 = 0, total = 0;
            bool running = true;


            Console.WriteLine("Please enter as manny scores out of 100 as you would like, just enter them one at a time. When you are satisfied with your scores, enter the number '100'.");
            Console.WriteLine();

            do
            {
                entry = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (entry == 100)
                {
                    break;
                }
                else if (entry >= 70)
                {
                    total = total + 1;
                    above70 = above70 + 1;
                }
                else if (entry < 70)
                {
                    total = total + 1;
                }
             
            } while (running);

            total = above70 / total * 100;
            Console.WriteLine(total + "% of your scores where above 70. Press 'enter' to return to the loop menu.");
            Console.ReadLine();
            Console.Clear();
            menu();
        }

        public static void odd()
        {
            Console.WriteLine("Enter a number:");
            Console.WriteLine();
            int number = Convert.ToInt32(Console.ReadLine());

            int sumOfOdds = 0;
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 != 0)
                {
                    sumOfOdds += i;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"The sum of odd numbers from 1 to {number} is: {sumOfOdds} \n\r Press 'enter' to return to the loop menu.");
            Console.ReadLine();
            Console.Clear();
            menu();
        }

        public static void rndm()
        {
            int min, max, value;
            Random generator = new Random();

            Console.WriteLine("Please enter a number that will be your minimum value.");
            Console.WriteLine();
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Please enter a number that will be your maximum value.");
            Console.WriteLine();
            max = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 25; i++)
            {
                
                value = generator.Next(min, max);
                Console.Write(value + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Press 'enter' to return to the loop menu.");
            Console.ReadLine() ;
            Console.Clear() ;
            menu();
        }


        static void Main(string[] args)
        {
            menu();
        }
    }
}