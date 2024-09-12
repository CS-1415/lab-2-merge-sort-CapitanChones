using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;

namespace Routines.Merge;

public class Sort
{

    public static int[] CombineSortedArrays(int[] a, int[] b)
    {
        int[] combined = new int[a.Length + b.Length];
        int i = 0;
        int j = 0;
        int c = 0;
        while (c < combined.Length)
        {
            if (j == b.Length || i != a.Length && a[i] < b[j])
            {
                combined[c] = (a[i]);
                i++;
            }

            else
            {
                combined[c] = b[j];
                j++;
            }
            c++;
        }
        return combined;
    }


    public static int[] SortViaMergesort(int[] values)
    {
        if (values.Length < 2)
        {
            return values;
        }

        else
        {
            int middle = values.Length / 2;
            int[] firstHalf = values[0..middle];
            int[] secondHalf = values[middle..values.Length];
            return CombineSortedArrays(SortViaMergesort(firstHalf), SortViaMergesort(secondHalf));
        }
    }
}
