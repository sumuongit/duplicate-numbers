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
            //COMPARE EVERY ITEM OF THE GIVEN ARRAY WITH ALL THE ITEMS OF THE ARRAY
            for (int i = 0; i < numArray.Count(); i++)
            {
                temp = numArray[i];
                count = 0;

                //ALREADY DUPLICATED NUMBER SHOULD NOT BE COMPARED AGAIN WITH ALL THE ITEMS OF THE GIVEN ARRAY
                if (!duplicateNumberList.Contains(temp))
                {
                    for (int j = 0; j < numArray.Count(); j++)
                    {
                        if (temp == numArray[j])
                        {
                            count = count + 1;
                        }
                    }

                    //MORE THAN ONE TIME OF OCCURRENCE OF A NUMBER MEANS IT IS A DUPLICATE NUMBER
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
            Console.Write("Duplicate numbers are as follows: ");
            Console.Write("{0} ", numWithCommas);           
            Console.ReadLine();
        }
    }
}
