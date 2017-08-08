using System;

namespace CSharpFundamentalsUnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] numbers = new int[5];
            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;
            */

            int[] numbers = new int[] { 4, 8, 15, 16, 23, 41 };

            Console.WriteLine(numbers[1].ToString());
            Console.ReadLine();

        }
    }
}