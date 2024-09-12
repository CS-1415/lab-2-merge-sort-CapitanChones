using System.Diagnostics;
using Routines.Merge;
namespace Test.Merge;

public class Tests
{

    [Test]
    public void TestCombineSortedArrays()
    {
        var a = new[] { 1, 2, 4, 5, 6 };
        var b = new[] { -41, 6, 34, 3, 7, 9 };
       
        Debug.Assert
        (
            Enumerable.SequenceEqual
            (
                Sort.CombineSortedArrays(new int[] { 1, 3, 5 }, new int[] { -5, 3, 6, 7 }),
                new int[] { -5, 1, 3, 3, 5, 6, 7 }
            )
        );

        Debug.Assert
        (
            Enumerable.SequenceEqual
            (
            Sort.CombineSortedArrays(new int[] { -5, 2, 5, 8, 10 }, new int[] { 1, 2, 5 }),
            new int[] { -5, 1, 2, 2, 5, 5, 8, 10 }
            )
        );

    }
    [Test]
    public void TestSortViaMergeSort()
    {
        Debug.Assert
        (
            Enumerable.SequenceEqual
            (
                Sort.SortViaMergesort(new int[] { 6, 1, -5, 3, 5, 3, 7 }),
                new int[] { -5, 1, 3, 3, 5, 6, 7 }
    )
        );

        Debug.Assert
        (
            Enumerable.SequenceEqual
            (
            Sort.SortViaMergesort(new int[] { 1, 10, -5, 2, 5, 2, 5, 8 }),
            new int[] { -5, 1, 2, 2, 5, 5, 8, 10 }
            )
        );

    }
}