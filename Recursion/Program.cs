// See https://aka.ms/new-console-template for more information
using Recursion;

Console.WriteLine("Hello, World!");

var binary233 = RecursionExamples.FindBinary(233, "");
Console.WriteLine($"Binary of 233: {binary233}");

var sumOfNaturalNumbers = RecursionExamples.recursiveSummation(55);
Console.WriteLine($"Sum of natural numbers up to 55: {sumOfNaturalNumbers}");

var fib = RecursionExamples.Fibonacci(5);
Console.WriteLine($"Fibonacci Sequence: {fib}");

int[] data = new int[] { -5, 20, 10, -99, 3, 2, 0 };
int[] sortedData = RecursionExamples.MergeSort(data, 0, data.Length - 1);

Console.WriteLine("Sorted Array");
Array.ForEach(sortedData, Console.Write);


