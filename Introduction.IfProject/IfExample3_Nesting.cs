using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.IfProject
{
    class IfExample3_Nesting
    {
        private void NestingExample()
        {
            // Change the values of these variables to test the results.
            bool Condition1 = true;
            bool Condition2 = true;
            bool Condition3 = true;
            bool Condition4 = true;

            if (Condition1)
            {
                // Condition1 is true.
                // Drink
            }
            else if (Condition2)
            {
                // Condition1 is false and Condition2 is true.
            }
            else if (Condition3)
            {
                if (Condition4)
                {
                    // Condition1 and Condition2 are false. Condition3 and Condition4 are true.
                }
                else
                {
                    // Condition1, Condition2, and Condition4 are false. Condition3 is true.
                }
            }
            else
            {
                // Condition1, Condition2, and Condition3 are false.
            }
        }
    }
}
