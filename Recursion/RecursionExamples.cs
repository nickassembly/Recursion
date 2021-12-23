using Recursion.Models;

namespace Recursion
{
    public static class RecursionExamples
    {
        public static int GetMyPositionInLine(Person person)
        {
            if (person.NextInLine == null)
            {
                return 1;
            }

            return 1 + GetMyPositionInLine(person.NextInLine);
        }

        public static string ReverseString(string input)
        {
            // what is the base case? When should the algorithm stop?
            // what is the smallest unit between each invocation

            if (input.Equals(""))
            {
                return "";
            }

            return ReverseString(input.Substring(0)) + input.Substring(0, 1);
        }

        public static string FindBinary(int decimalInput, string result)
        {
            if (decimalInput == 0) return result;

            result = decimalInput % 2 + result;
            return FindBinary(decimalInput / 2, result);
        }

        public static int recursiveSummation(int inputNumber)
        {
            if (inputNumber <= 1) return inputNumber;

            return inputNumber + recursiveSummation(inputNumber - 1);
        }


    }
}
