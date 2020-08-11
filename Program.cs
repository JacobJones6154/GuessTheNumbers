using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int firstNumber = randomNumber.Next(2, 10);
            int secondNumber = randomNumber.Next(2, 10);
            var subtraction = randomNumber.Next(2, 10);
            int answer = firstNumber * secondNumber - subtraction;
            string prompt = " Dont type in the answer just press enter when ready";

            Console.WriteLine("Think of a number between 1 and 10 " + prompt);
            Console.ReadKey();
            Console.WriteLine("multiply your number by " + firstNumber + prompt);
            Console.ReadKey();
            Console.WriteLine("multiply the result by " + secondNumber + prompt);
            Console.ReadKey();
            Console.WriteLine("Divide the result by the number you orignially thought of" + prompt);
            Console.ReadKey();
            Console.WriteLine("now subtract " + subtraction + prompt);
            Console.ReadKey();

            Console.WriteLine("the answer is " + answer);
        }
    }
}
