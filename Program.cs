using System;
namespace Lab6
{                           //Application that simulates dice rolling 
    class MainClass
    {
        public static void Main(string[] args)
        {
                Console.WriteLine("Welcome to the Grand Circus Casino! Roll the dice?(y/n)");
                string starting = Console.ReadLine().ToLower();
                if(starting == "n")
                {
                    return; // If the user doesn't want to play the game the program will terminate
                }
                //If the user would like to run the game again
                Boolean repeat = true;
                int counter = 0; //count how many times the user will play the game

                do
                {
                    counter++;// The user started playing
                    Console.WriteLine("How many sides should each die have?");
                    int numSides = int.Parse(Console.ReadLine());
                    Console.WriteLine("Roll {0}: ", counter);
                    RandomNumberGenerator(numSides);
                    repeat = Continue(repeat);//cheek if the user would like to continue
                } while (repeat);
        }

        public static Boolean Continue(Boolean repeat) 
        {
            Console.WriteLine("Roll again?(y/n)");
            string userChoice = Console.ReadLine().ToLower();
            repeat = (userChoice == "y") ? true : false;
            return repeat;
        }

        public static void RandomNumberGenerator (int num)
        {
            Random rnd = new Random();
            int numGen1 = rnd.Next(1, num+1);
            int numGen2 = rnd.Next(1, num+1);
            Console.WriteLine(numGen1 + "\n" + numGen2);

        }
    }
}
