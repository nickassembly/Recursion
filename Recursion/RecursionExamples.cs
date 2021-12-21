using Recursion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



    }
}
