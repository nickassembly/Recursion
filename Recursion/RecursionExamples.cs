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

        // Not optimized
        public static long Fibonacci(long n)
        {
            if ((n == 0) || (n == 1))
            {
                Console.Write($"{n} ");
                return n;
            }
            else
            {
                Console.Write($"{n} ");
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        // Merge Sort
        public static int[] MergeSort(int[] data, int start, int end)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;
                MergeSort(data, start, mid); // left half of array
                MergeSort(data, mid + 1, end); // right half of array
                Merge(data, start, mid, end);
            }

            return data;
        }

        private static void Merge(int[] data, int start, int mid, int end)
        {
            // build a temporary array to avoid modifying the original contents
            int[] temp = new int[end - start + 1];

            int i = start, j = mid + 1, k = 0;

            // While both sub arrys have values, try to merge them in sorted order
            while (i <= mid && j <= end)
            {
                if (data[i] <= data[j])
                {
                    temp[k++] = data[i++];
                }
                else
                {
                    temp[k++] = data[j++];
                }
            }

            // Add the rest of the values from left sub array into the result
            while (i <= mid)
            {
                temp[k] = data[i];
                k++; i++;
            }

            // Add the rest of the values from the right sub-array
            while (j <= end)
            {
                temp[k] = data[j];
                k++; j++;
            }

            for(i = start; i <= end; i++)
            {
                data[i] = temp[i - start];
            }
        }

         


    }
}
