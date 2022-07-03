using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace algorithm
{
    class Search
    {

        static void Main(string[] args)
        {
            int[] array = { 123, 5, 324, 44, 32, 12, 98, 4, 331, 11, 3 };
            int max = array[0];
            int maxindex = 0;
            int minindex = 0;
            int comprassions = 0;
            int replacements = 0;
            for (int i = 0; i < array.Length; i++)   // search in array O(n)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxindex = i;
                    replacements++;
                }
                comprassions++;
            }
            int min = array[0];
            for(int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                    minindex = i;
                    replacements++;
                }
                comprassions++;
            }
            
           Console.WriteLine("Max element of array: " + max);
           Console.WriteLine("Min element of array: " + min);
            Console.WriteLine("Max element index: " + maxindex);
            Console.WriteLine("Min element index: " + minindex);
            Console.WriteLine("Replacements: " + replacements);
            Console.WriteLine("Comprassions: " + comprassions);
            
           


        }


    }
}

