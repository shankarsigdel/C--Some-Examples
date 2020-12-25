using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /*****************************
             * while loop
              ****************************/
        //static void Main(string[] args)
        //{
        //    int num = 0;
        //    while (num <= 10)
        //    {
        //        Console.WriteLine(num);
        //        num++;
        //    }
        //    Console.ReadLine();
        //}


        /*****************************
         * while loop
         * Guessing Game using 
         * ***************************/
        //static void Main(string[] args)
        //{
        //    string secretWord = "giraffe";
        //    string guess = "";
        //    int guessCount = 0;
        //    int guessLimit = 3;
        //    bool outOfGuesses = false;
        //    while (guess != secretWord && !outOfGuesses)
        //    {
        //        if (guessCount < guessLimit)
        //        {
        //            Console.WriteLine("Enter guess: ");
        //            guess = Console.ReadLine();
        //            guessCount++;
        //        }
        //        else
        //        {
        //            outOfGuesses = true;
        //        }
        //    }
        //    if (outOfGuesses)
        //    {
        //        Console.WriteLine("You Loose!: ");
        //    }
        //    else
        //    {
        //        Console.WriteLine("You Win!");
        //    }
        //    Console.ReadLine();
        //}


        /******************************
          * For Loop
          * ***************************/
        //static void Main(string[] args)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    Console.ReadLine();
        //}


        /******************************
          * For Loop inside Array[]
          * ***************************/
        //static void Main(string[] args)
        //{
        //    int[] luckyNumbers = { 4, 5, 8, 22, 43, 56 };

        //    for (int i = 0; i < luckyNumbers.Length; i++)
        //    {
        //        Console.WriteLine(luckyNumbers[i]);

        //    }
        //    Console.ReadLine();
        //}



        /******************************
          * Building an Exponent Method
          * Get Power Method
          * ***************************/

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(GetPower(4, 4));
        //    Console.ReadLine();
        //}
        //static int GetPower(int baseNumber, int powerNumber)
        //{
        //    int result = 1;
        //    for (int i = 0; i < powerNumber; i++)
        //    {
        //        result = result * baseNumber;
        //    }
        //    return result;
        //}


        /******************************
          * 2 Dimentional Array
          * ***************************/
        //static void Main(string[] args)
        //{
        //    int[,] numberGrid =
        //    {
        //        {1, 2},
        //        {3, 4},
        //        {5, 6}
        //    };
        //    Console.WriteLine(numberGrid[1, 1]);
        //    Console.ReadLine();
        //}


        /******************************
          * Exception Handeling
          * Try - Catch
          * ***************************/
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        Console.Write("Enter a Number: ");
        //        int number = Convert.ToInt32(Console.ReadLine());
        //        Console.Write("Enter another Number: ");
        //        int number2 = Convert.ToInt32(Console.ReadLine());

        //        Console.WriteLine(number / number2);
        //    }
        //    catch (DivideByZeroException exceptionhandle)
        //    {
        //        Console.WriteLine(exceptionhandle.Message);
        //    }
        //    catch ( FormatException formatexc)
        //    {
        //        Console.WriteLine(formatexc.Message);
        //    }
        //    Console.ReadLine();
        //}
    }
}
