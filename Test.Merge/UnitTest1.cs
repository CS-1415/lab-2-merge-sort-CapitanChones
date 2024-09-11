using System.Diagnostics;
namespace Test.Merge;

public class Tests
{

    [Test]
    public void Test1()
    {
        var a = new[] { 1, 2, 4, 5, 6 };
        var b = new[] { -41, 6, 34, 3, 7, 9 };
        Debug.Assert(true);
        Debug.Assert
        (
            Enumerable.SequenceEqual
            (
                Routines.Merge.Sort.CombineSortedArrays(a, b),
                 new int[] { -5, 1, 3, 3, 5, 6, 7 }
            )
        )
        ;
    }
}