/*
Author: Tim Tieng
Task: Whiteboard Problem
Concept: Binary Search

Prompt:
Write a function that takes a sorted array, target value, and returns the target value index/location in the array.
Must use the Binary Search Algorithm.

Notes: Binary Search splits a collection in half, and searches in a certain pile based of a middle value
*/
using System;
using System.Runtime.CompilerServices;

namespace WhiteBoard_BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearch();
        }
        public static void BinarySearch()
        {
            //Prompt user program purpose
            Console.WriteLine("This program asks you to store values into an array, asks you for value you want to find, and returns the target values index");
            //Capture and store values provided by the user, Length, Array (use loop to iterate task)
            Console.Write("How many values do you want to enter in the array?: ");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] numberArray = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Please enter a value to store at index {0}: ", i);
                numberArray[i] = int.Parse(Console.ReadLine());
            }
            //Declare and Initialize target value - use a value in the numberArray, Left Right and Middle Index values
            int leftIndex = 0;
            int rightIndex = arrayLength - 1;
            int middleIndex = (leftIndex + rightIndex) / 2;
            //Ask user for target value
            Console.Write("What is the value you wish to find in the array?: ");
            int targetValue = int.Parse(Console.ReadLine());
            //Evalate and iterate -- While Loop
            while (leftIndex <= rightIndex)//if indices overlap this means target value not present
            {
                //Compare target value to middle index to determine how to move Left and Right Indices
                if (targetValue < numberArray[middleIndex])
                {
                    rightIndex = middleIndex - 1;
                }
                else if (targetValue > numberArray[middleIndex])
                {
                    leftIndex = middleIndex + 1;
                }
                else if (targetValue == numberArray[middleIndex])
                {
                    Console.WriteLine("Your target value of {0} is located at index {1}.", targetValue, middleIndex);
                    break;
                }
                else if (targetValue != numberArray[middleIndex])
                {
                    Console.WriteLine("The target value of {0} is not present in the array", targetValue);
                    break;
                }
                //Reassign middleIndex based off new positions of L/R indices
                middleIndex = (leftIndex + rightIndex) / 2;
            }
        }
    }
}
