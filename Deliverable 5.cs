using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength;
            bool validEntry = false;

            // Ask the user to enter an integer number between 5 and 15
            Console.WriteLine("Enter an integer number between 5 and 15:");

            do
            {
                try
                {
                    // Use a try/catch block to validate the user’s entry
                    arrayLength = Convert.ToInt32(Console.ReadLine());

                    // Use a conditional statement to check the user’s entry is between 5 and 15
                    if (arrayLength >= 5 && arrayLength <= 15)
                    {
                        validEntry = true;
                        int[] randomArray = PopulateArray(arrayLength);

                        // Display in the console all the elements in the array
                        Console.WriteLine("The elements in the array are:");
                        foreach (int number in randomArray)
                        {
                            Console.Write(number + " ");
                        }

                        int sum = SumArray(randomArray);

                        // Display in the console the summation of all the elements in the array
                        Console.WriteLine("\nThe summation of all the elements in the array is: " + sum);
                    }
                    else
                    {
                        Console.WriteLine("Please enter an integer number between 5 and 15:");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid entry. Please enter an integer number between 5 and 15:");
                }
            } while (!validEntry);
        }

        // Method 1: Randomly populate an array with integers numbers between 10 and 50
        static int[] PopulateArray(int length)
        {
            int[] randomArray = new int[length];
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                randomArray[i] = random.Next(10, 51);
            }

            return randomArray;
        }

        // Method 2: Return the summation of all the elements of an array
        static int SumArray(int[] array)
        {
            int sum = 0;

            foreach (int number in array)
            {
                sum += number;
            }

            return sum;
        }
    }
}