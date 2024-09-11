
using Routines.Merge;
internal class Program
{
    private static void Main(string[] args)
    {
        //things are Printed to the Cosnole here to help me understand mistakes and issuse faster than with a debugger.
         var a = new[] { 1, 2, 4, 5, 6 };
        var b = new[] { -41, 6, 34, 3, 7, 9 };
        foreach (var c in a)
        {
            Console.Write(c+", ");
        }
        Console.WriteLine();

        foreach (var c in b)
        {
            Console.Write(c+", ");
        }
        Console.WriteLine();
        var nw = Sort.CombineSortedArrays(a, b);
        foreach(var c in nw )
        {
            
        
            Console.Write(c+", ");
        
        }
    }
}