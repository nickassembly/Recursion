using Recursion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class RecursionExamples
    {
        public int GetMyPositionInLine(Person person)
        {
            if (person.NextInLine == null)
            {
                return 1;
            }

            return 1 + GetMyPositionInLine(person.NextInLine);
        }
    }
}
