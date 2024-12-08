// See https://aka.ms/new-console-template for more information
using ProblemSolving.ArrayDS;
using ProblemSolving.Concepts;

Console.WriteLine("Hello, World!");
Console.WriteLine(E_ProductOfArrExceptSelf.ProductOfArray());
Console.WriteLine(E_ContainsDuplicate.ContainsDuplicate());

#region Buy and Sell stock for maximum profit
Console.WriteLine("Maximum profit = ", E_BuyAndSellStock.maxProfit());
#endregion

#region Two Sum
//int[] array = { 3, 5, -4, 8, 11, 1, -1, 6 };
//var result = TwoSum.CalculateTwoSum(array, 10);
//var resultWithHashSet = TwoSum.CalculateTwoSumOption2(array, 4);


//Console.WriteLine(string.Join(",", resultWithHashSet));
//Console.WriteLine(string.Join(",", resultWithHashSet));

#endregion

#region Validate subsequence

//int[] array = { 5, 1, 22, 25, 6, -1, 8, 10 };
//int[] sequence = { 1,6,-1,10};

//var result = SubSequence.ValidateSubSequence(array, sequence);
//var resultOption2 = SubSequence.ValidateSubSequenceOption2(array, sequence);
//Console.WriteLine("Validate Sequence: " + result);
//Console.WriteLine("Validate Sequence: " + resultOption2);

#endregion

#region Sorted Square Array
//int[] array = { -3, 1, 2, 4, 5, 6, 8, 9 };
//var result = SquaredArray.SortedSquaredArray(array);
//var resultOption2 = SquaredArray.SortedSquaredArrayOption2(array);

//Console.WriteLine("Sorted Square Array: " + string.Join(",", result));
//Console.WriteLine("Sorted Square Array: " + string.Join(",", resultOption2));
#endregion

#region Sliding window concepts

Console.WriteLine("Maximum Sub array = ", SlidingWindow.MaximumSumSubArray());
#endregion


#region Algorithm
/// <summary>
/// Call Binary Search by uncommenting Iterative or Recursive 
/// </summary>   

#region Binary search call

// int[] arr = { 2, 3, 4, 10, 40 };

// BinarySearch bs = new BinarySearch();

// //Recursive
// int resultRec = bs.BinarySearchHelperRecursive(arr, 40, 0, arr.Length - 1);
// if (resultRec == -1)
//     Console.WriteLine("Element not present");
// else
//     Console.WriteLine($"Element found at index {resultRec}");

// // Iterative
// int resultIterative = bs.BinarySearchHelperIterative(arr, 10);
// if (resultIterative == -1)
//     Console.WriteLine("Element not present");
// else
//     Console.WriteLine("Element found at index " + resultIterative);

#endregion
#endregion

Console.WriteLine("Thank you");