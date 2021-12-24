// See https://aka.ms/new-console-template for more information
using Recursion;

Console.WriteLine("Hello, World!");

var binary233 = RecursionExamples.FindBinary(233, "");
Console.WriteLine($"Binary of 233: {binary233}");

var sumOfNaturalNumbers = RecursionExamples.recursiveSummation(55);
Console.WriteLine($"Sum of natural numbers up to 55: {sumOfNaturalNumbers}");

var fib = RecursionExamples.Fibonacci(5);
Console.WriteLine($"Fibonacci Sequence: {fib}");
