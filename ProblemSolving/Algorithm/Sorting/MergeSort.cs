namespace ProblemSolving.Algorithm.Sorting;

internal class MergeSort
{

    /// <summary>
    /// Time Complexity - o(nlogn) Space Complexity - o(n)
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="start"></param>
    /// <param name="end"></param>

    public static void MergeSortCall()
    {
        int[] arr = [35, 12, 31, 32, 38, 8, 17];

        MergeSortArray(arr, 0, arr.Length - 1);

        string.Join(",",arr);

        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }

    public static void MergeSortArray(int[] arr, int start, int end)
    {
        if (start < end)
        {
            int mid = (start + end) / 2; //this might throw overflow exception if array size is too large for that we can use -> start +  (end-start)/2;

            MergeSortArray(arr, start, mid); // left half
            MergeSortArray(arr, mid + 1, end); // right half

            Merge(arr, start, mid, end);
        }
    }

    private static void Merge(int[] data, int start, int mid, int end)
    {
        List<int> temp = new List<int>();

        int i = start, j = mid + 1;

        //while both sub array have values , then try and merge them in sorted order
        while (i <= mid && j <= end)
        {
            if (data[i] <= data[j])
            {
                temp.Add(data[i]);
                i++;
            }
            else
            {
                temp.Add(data[j]);
                j++;
            }
        }

        while (i <= mid)
        {
            temp.Add(data[i]);
            i++;
        }

        while (j <= end)
        {
            temp.Add(data[j]);
            j++;
        }

        for (int k = 0; k < temp.Count; k++)
        {
            data[k + start] = temp[k];
        }
    }
}
