using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateNumber
{
    public class Duplicate
    {
        int[] numArray = new int[] { 11, 15, 3, 18, 30, 22, 37, 7, 11, 8, 22, 2, 50, 41, 15, 30, 16, 27, 19, 7 };
        int temp;
        int count;
        List<int> duplicateNumberList = new List<int>();

        public List<int> FindDuplicateNumber()
        {
            for (int i = 0; i < numArray.Count(); i++)
            {
                temp = numArray[i];
                count = 0;
               
                for (int j = 0; j < numArray.Count(); j++)
                {
                    if(temp == numArray[j])
                    {
                        count = count + 1;
                    }
                }

                if(count == 2)
                {
                    if (!duplicateNumberList.Contains(temp))
                    {
                        duplicateNumberList.Add(temp);
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
            foreach (int item in dp.FindDuplicateNumber())
            {
                Console.Write("{0} ", item);
            }
            Console.ReadLine();
        }
    }
}
