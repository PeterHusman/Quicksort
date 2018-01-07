using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            for (int i = 0; i < 1000; i++)
            {
                int[] vals = new int[100];

                for (int j = 0; j < vals.Length; j++)
                {
                    vals[j] = rand.Next(1, 1001);
                }

                //foreach (int val in vals)
                //{
                //    Console.Write(val + " ");
                //}
                //Console.WriteLine();
                /*int[] output = */
                Quicksort(vals);
                //foreach (int val in vals)
                //{
                //    Console.Write(val + " ");
                //}
                //Console.WriteLine();
                Console.WriteLine(IsSorted(vals));
            }

            Console.ReadKey();
        }

        public static bool IsSorted(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i])
                {
                    return false;
                }
            }
            return true;
        }

        static int[] Quicksort(int[] input, int startingIndex = 0, int endingIndex = -100)
        {
            endingIndex = endingIndex == -100 ? input.Length - 1 : endingIndex;


            if (startingIndex < endingIndex)
            {
                int wall = startingIndex - 1;
                int currentElementIndex = startingIndex;
                int pivotIndex = endingIndex;
                int swappingIntermediate;

                while (currentElementIndex < endingIndex)
                {
                    if (input[currentElementIndex] < input[pivotIndex])
                    {
                        swappingIntermediate = input[currentElementIndex];
                        input[currentElementIndex] = input[wall + 1];
                        input[wall + 1] = swappingIntermediate;
                        wall++;
                    }
                    currentElementIndex++;
                }
                if (input[pivotIndex] < input[wall + 1])
                {
                    swappingIntermediate = input[pivotIndex];
                    input[pivotIndex] = input[wall + 1];
                    input[wall + 1] = swappingIntermediate;
                }
                wall++;
                Quicksort(input, startingIndex, wall - 1);
                Quicksort(input, wall + 1, endingIndex);

            }
            //if (wall < input.Length - 1)
            //{
            //    Quicksort(input, wall + 1);
            //}
            //if (pivotIndex > 0)
            //{
            //    Quicksort(input, 0, wall);
            //}
            return input;
        }
    }
}
