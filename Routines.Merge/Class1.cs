using System.ComponentModel.DataAnnotations;

namespace Routines.Merge;

public class Sort
{
    public static int[] CombineSortedArrays(int[] a, int[] b)
    {
        var result = new List<int>();
        var _a = a.ToList();
        var _b = b.ToList();
//determines When Process is over
        while (_a.Count > 0 && _b.Count > 0)
        {

                
            if (_a.Min() <= _b.Min())
            {
                int low = _a.Min();
                result.Add(low);
                _a.Remove(low);

                //Checks to see if a list is empty and deals with any remaining Values in the list.
                if (_a.Count() == 0 || _b.Count() == 0) 
                {
                    if (_a.Count == 0)
                    {
                        while (_b.Count() > 0)
                        {
                            low = _b.Min();
                            result.Add(low);
                            _b.Remove(low);
                        }
                    }
                    if (_b.Count == 0)
                    {
                        while (_a.Count() > 0)
                        {
                            low = _a.Min();
                            result.Add(low);
                            _a.Remove(low);
                        }
                    }
                    return result.ToArray();
                }
            }
            
            if (_a.Min() >= _b.Min())
            {
                int low = _b.Min();
                result.Add(low);
                _b.Remove(low);
                if (_a.Count() == 0 || _b.Count() == 0)
                {
                    if (_a.Count == 0)
                    {
                        while (_b.Count() > 0)
                        {
                            low = _b.Min();
                            result.Add(low);
                            _b.Remove(low);
                        }
                    }
                    if (_b.Count == 0)
                    {
                        while (_a.Count() > 0)
                        {
                            low = _a.Min();
                            result.Add(low);
                            _a.Remove(low);
                        }
                    }
                    return result.ToArray();
                }
            }
        }
        return result.ToArray();

    }

    public static int[] SortViaMergesort(int[] values)
    {
        int middle = values.Length / 2;
        int[] firstHalf = values[0..middle];
        int[] secondHalf = values[middle..values.Length];

        return CombineSortedArrays(firstHalf, secondHalf);
    }

}
