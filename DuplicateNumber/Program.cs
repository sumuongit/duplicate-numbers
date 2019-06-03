using System;
using System.Collections.Generic;
using System.Linq;

namespace DuplicateNumber
{
    public class Duplicate
    {
        int[] numArray = new int[] { 11, 15, 3, 18, 30, 22, 37, 7, 11, 8, 22, 2, 50, 41, 15, 30, 16, 27, 19, 7 };
        int temp, count;
        List<int> duplicateNumberList = new List<int>();        

        public List<int> FindDuplicateNumber()
        {
            // Compare every item of the given array with all the items of the array.
            for (int i = 0; i < numArray.Count(); i++)
            {
                temp = numArray[i];
                count = 0;

                // Already duplicated number should not be compared again with all the items of the given array.
                if (!duplicateNumberList.Contains(temp))
                {
                    for (int j = 0; j < numArray.Count(); j++)
                    {
                        if (temp == numArray[j])
                        {
                            count = count + 1;
                        }
                    }

                    // More than one time of occurrence of a number means it is a duplicate number.
                    if (count > 1)
                    {
                        if (!duplicateNumberList.Contains(temp))
                        {
                            duplicateNumberList.Add(temp); 
                        }
                    }
                }
            }
            
            return duplicateNumberList;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Duplicate dp = new Duplicate();
            string numWithCommas = string.Join(", ", dp.FindDuplicateNumber());
            Console.WriteLine("INPUT: An array of numbers is as follows:");
            Console.WriteLine("=========================================");
            Console.WriteLine("11, 15, 3, 18, 30, 22, 37, 7, 11, 8, 22, 2, 50, 41, 15, 30, 16, 27, 19, 7");
            Console.WriteLine();
            Console.WriteLine("OUTPUT: Duplicate numbers are as follows: ");
            Console.WriteLine("=========================================");
            Console.WriteLine("{0} ", numWithCommas);           
            Console.ReadLine();
        }
    }
}
