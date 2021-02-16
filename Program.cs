using System;
using System.Collections.Generic;
namespace ConsoleApplication
{
    public class Program
    {
        // public static string SayHello(string firstName = "there")
        // {
        //     return $"Hey {firstName}";
        // }
        // public static void Main(string[] args)
        // {
        //     string greeting;
        //     greeting = SayHello();
        //     Console.WriteLine(greeting);
        // }

        public static void Main(string[] args)
        {
            PrintNumbers();
            PrintOdds();
            PrintSum();
            LoopArray(new int[5] { 1, 2, 3, 4, 5 });
            FindMax(new int[5] { 0, -3, -1, 10, 5 });
            GetAverage(new int[3] { 2, 10, 3 });
            OddArray();
            GreaterThanY(new int[5] { 1, 2, 6, 4, 5 }, 3);
            GreaterThanY(new int[5] { 1, 2, 6, 4, 5 }, 3);
            SquareArrayValues(new int[4] { 1, 5, 10, -10 });
            EliminateNegatives(new int[4] { 1, 5, 10, -2 });
            MinMaxAverage(new int[4] { 1, 5, 10, -2 });
            ShiftValues(new int[5] { 1, 5, 10, 7, -2 });
            NumToString(new int[3] { -1, -3, 2 });

        }
        public static void PrintNumbers()
        {
            // Print all of the integers from 1 to 255.
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintOdds()
        {
            // Print all of the odd integers from 1 to 255.
            for (int i = 1; i <= 255; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void PrintSum()
        {
            // Print all of the numbers from 0 to 255, 
            // but this time, also print the sum as you go. 
            // For example, your output should be something like this:

            // New number: 0 Sum: 0
            // New number: 1 Sum: 1
            // New Number: 2 Sum: 3
            int sum = 0;
            for (int i = 0; i <= 255; i++)
            {
                sum = sum + i;
                Console.WriteLine($"New number: {i} Sum: {sum}");
            }
        }

        public static void LoopArray(int[] numbers)
        {
            // Write a function that would iterate through each item of the given integer array and 
            // print each value to the console. 
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        public static int FindMax(int[] numbers)
        {
            // Write a function that takes an integer array and prints and returns the maximum value in the array. 
            // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
            // or even a mix of positive numbers, negative numbers and zero.
            int max = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine(max);
            return max;

        }

        public static void GetAverage(int[] numbers)
        {
            // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
            // For example, with an array [2, 10, 3], your program should write 5 to the console.
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }
            Console.WriteLine($"Average: {sum / numbers.Length}");
        }

        public static int[] OddArray()
        {
            // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
            // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
            // int[] newArr = new int[];
            List<int> newList = new List<int>();
            for (int i = 1; i <= 255; i++)
            {
                if (i % 2 != 0)
                {
                    newList.Add(i);
                }
            }
            int[] newArr = newList.ToArray();
            // Console.WriteLine(newArr); - WRONG: it will only print the type of the array, not its value
            foreach (var entry in newArr)
            {
                Console.Write($"{entry}, ");
                // Console.WriteLine(entry);
            }
            return newArr;
        }

        public static int GreaterThanY(int[] numbers, int y)
        {
            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > y)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            return count;
        }

        public static void SquareArrayValues(int[] numbers)
        {
            // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
            // For example, [1,5,10,-10] should become [1,25,100,100]
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] * numbers[i];
                Console.WriteLine(numbers[i]);
            }
        }

        public static void EliminateNegatives(int[] numbers)
        {
            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
            }
            foreach (var entry in numbers)
            {
                Console.WriteLine(entry);
            }
        }

        public static void MinMaxAverage(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.
            int max = 0;
            int min = 0;
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                sum = sum + numbers[i];
            }
            Console.WriteLine($"Max: {max}, Min: {min}, Average: {sum / numbers.Length}");
        }

        public static void ShiftValues(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, 7, -2], 
            // Write a function that shifts each number by one to the front and adds '0' to the end. 
            // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
            // it should become [5, 10, 7, -2, 0].
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                numbers[i] = numbers[i + 1];
            }
            numbers[numbers.Length - 1] = 0;

            foreach (var entry in numbers)
            {
                Console.WriteLine(entry);
            }
        }

        public static object[] NumToString(int[] numbers)
        {
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].
            List<object> newObj = new List<object>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    newObj.Add("Dojo");
                }
                else 
                {
                    newObj.Add(numbers[i]);
                }
            }
            object[] newArr = newObj.ToArray();
            foreach (var entry in newArr)
            {
                Console.WriteLine(entry);
            }
            return newArr;
         

        }
    }
}
