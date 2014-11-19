using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class MergeSort
    {
        public static void MergeSortAlgorithm()
        {
            int[] unsortedInts = { 5, 4, 1, 8, 7, 2, 6, 3 };
            int[] firstUnsortedPart = new int[unsortedInts.Length/2];
            int[] secondUnsortedPart = new int[unsortedInts.Length/2];
            int[] sortedInts = new int[unsortedInts.Length];
            int i;
            int l = 0;
            int m = 0;
            int numberOfInversions = 0;
            int inversionCounter = unsortedInts.Length/2; 

            for (i = 0; i < firstUnsortedPart.Length; i++)
            {
                firstUnsortedPart[i] = unsortedInts[i];
                secondUnsortedPart[i] =unsortedInts[(unsortedInts.Length/2)+i];
            }

            Array.Sort(firstUnsortedPart);

            foreach (int j in unsortedInts)
            {
                Console.WriteLine("Unsorted is = {0}.\n", j);
            }

            foreach (int j in firstUnsortedPart)
            {
                Console.WriteLine("First part is = {0}.\n", j);
            }

            foreach (int j in secondUnsortedPart)
            {
                Console.WriteLine("Second part is = {0}.\n", j);
            }

            for (int j = 0; j < firstUnsortedPart.Length; j++)
            {
                {
                    for (int k = 0; k < firstUnsortedPart.Length - 1; k++)
                    {
                        if (firstUnsortedPart[k]>firstUnsortedPart[k+1])
                        {
                            int z = firstUnsortedPart[k];
                            firstUnsortedPart[k] = firstUnsortedPart[k + 1];
                            firstUnsortedPart[k + 1] = z;  
                        }
                    }
                }
            }

            foreach (int j in firstUnsortedPart)
            {
                Console.WriteLine("First part is = {0}.\n", j);
            }

            for (int j = 0; j < secondUnsortedPart.Length; j++)
            {
                {
                    for (int k = 0; k < secondUnsortedPart.Length - 1; k++)
                    {
                        if (secondUnsortedPart[k] > secondUnsortedPart[k + 1])
                        {
                            int z = secondUnsortedPart[k];
                            secondUnsortedPart[k] = secondUnsortedPart[k + 1];
                            secondUnsortedPart[k + 1] = z;
                        }
                    }
                }
            }

            foreach (int j in secondUnsortedPart)
            {
                Console.WriteLine("Second part is = {0}.\n", j);
            }

            for (int k = 0; k < sortedInts.Length; k++)
            {
                if (l<unsortedInts.Length/2 && m<unsortedInts.Length/2)
                {
                    if (firstUnsortedPart[l] < secondUnsortedPart[m])
                    {
                        sortedInts[k] = firstUnsortedPart[l];
                        l++;
                        inversionCounter--;
                    }
                    else if (firstUnsortedPart[l] > secondUnsortedPart[m])
                    {
                        sortedInts[k] = secondUnsortedPart[m];
                        m++;
                        numberOfInversions += inversionCounter; 
                    }
                }

                if (l<m)
                {
                    sortedInts[sortedInts.Length - 1] = firstUnsortedPart[firstUnsortedPart.Length - 1];
                }
                else
                {
                    sortedInts[sortedInts.Length - 1] = secondUnsortedPart[secondUnsortedPart.Length - 1]; 
                } 
            }

            foreach (int sortedInt in sortedInts)
            {
                Console.WriteLine("Sorted int: {0}", sortedInt);  
            }

            Console.WriteLine("Number of inversions in unsorted array: {0}.", numberOfInversions); 
        }
    }
}
