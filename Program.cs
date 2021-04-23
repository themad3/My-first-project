using System;

namespace My_awsome_program
{
    class Program
    {
        static void Main(string[] args)
        {

            // This is where the apperance is changed
            Console.Title = "Skynet";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console. WindowHeight = 40;

            // this is where the conversation is started

            Console.WriteLine("Sup, So what's your name?");

            Console.ReadLine();

            Console.WriteLine("My name is HGD-9269.\nI am not a human, i am a robot!");
            Console.WriteLine("What is your foverite color?");

            Console.ReadLine();

            Console.WriteLine("Cool, Mine is distruction!");

            Console.WriteLine("What is your name again?");

            string userName = Console.ReadLine();

            Console.WriteLine("Sorry that i forgot your name " + userName );

            double num01;
            double num02;

            Console.Write("Input a number: ");
           
            num01 = Convert. ToDouble( Console.ReadLine() ); 

            Console.WriteLine("Input a second number: ");

            num02 = Convert.ToDouble( Console.ReadLine() );

            double result = num01 * num02;

            Console.WriteLine("i multiplyed your two numbers to get," + result);

            Console.ReadLine();

            Console.WriteLine("Here im going to find the avrage of 3 numbers that you put in!");

            Console.ReadLine();

            double num04;
            double num05;
            double num06;

            Console.WriteLine("input a number again: ");

            num04 = Convert. ToDouble( Console.ReadLine() ); 

            Console.WriteLine("Please enter a 2nd number: ");

            num05 = Convert. ToDouble( Console.ReadLine() ); 

            Console.WriteLine("Now enter the last number so i can find the avrage!!: ");

            num06 = Convert. ToDouble( Console.ReadLine() ); 

            Double result2 = num04 + num05 + num06;

            double result3 = result2 / 3;

            Console.WriteLine("i have found the avrage of all your numbers, it is " + result3);

            Console.ReadLine();

            int answer1;

            Console.WriteLine("here, lets see how good you are at math, what is 8 x 8?");
            answer1 = Convert.ToInt32(Console.ReadLine());

            if (answer1 == 64){
                Console.WriteLine("Correct!");
            }
            else if (answer1 >= 64 || answer1 <= 64){
                Console.WriteLine("Incorrect!");
            }

            int answer2;

            Console.WriteLine("what is 128 / 4?");
            answer2 = Convert.ToInt32(Console.ReadLine());

            if (answer2 == 32){
                Console.WriteLine("Correct!");
            }
            else if (answer2 >= 32 || answer2 <= 32) {
                Console.WriteLine("Incorrect!");
            }

            Console.ReadLine();
        

        }
    }
}
