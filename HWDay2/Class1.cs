using System;
using System.Collections.Generic;
using System.Text;

namespace HWDay2
{
    class Class1
    {
        static void Main(string[] args)
        {
            int num1 = Utils.GetNumber("Enter a number");
            int num2 = Utils.GetNumber("Enter another number");
            if (num1 > num2)
            {
                Console.WriteLine("The bigger number is: " + num1);
            }
            else
            {
                Console.WriteLine("The bigger number is: " + num2);
            }
            int numb1 = Utils.GetNumber("Enter a number");
            int numb2 = Utils.GetNumber("Enter another number");
            int numb3 = Utils.GetNumber("Enter another number");
            if(numb1>numb2 && numb1 > numb3)
            {
                Console.WriteLine("The biggest number is: " + numb1);
            }
            else if (numb2 > numb1 && numb2 > numb3)
            {
                Console.WriteLine("The biggest number is: " + numb2);
            }
            else if (numb3 > numb1 && numb3 > numb2)
            {
                Console.WriteLine("The biggest number is: " + numb3);
            }
            if (numb1<numb2 && numb1 < numb3)
            {
                Console.WriteLine("The smallest number is: " + numb1);
            }
            else if (numb2 < numb1 && numb2 < numb3)
            {
                Console.WriteLine("The smallest number is: " + numb2);
            }
            else if (numb3 < numb2 && numb3 < numb1)
            {
                Console.WriteLine("The smallest number is: " + numb3);
            }
        }
    }
}
