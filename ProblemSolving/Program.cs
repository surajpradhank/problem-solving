// See https://aka.ms/new-console-template for more information
using ProblemSolving.Algorithm.Sorting;
using ProblemSolving.ArrayDS;
using ProblemSolving.Concepts.Graph;
using ProblemSolving.Concepts.Topics;
using ProblemSolving.Concepts.Recursion;
using ProblemSolving.Concepts;
using ProblemSolving.Concepts.LinkedList;
using ProblemSolving.String;

Console.WriteLine("Hello, World!");

#region Recursion

//Console.WriteLine(Recursion.SumOfNaturalNo(5));

//Console.WriteLine(Recursion.ReverseString("hello"));

//Console.WriteLine(Recursion.DecimalToBinary(233, ""));

//Console.WriteLine(Recursion.IsPalindrome("kayak"));
#endregion

//Console.WriteLine(string.Join(",", E_ProductOfArrExceptSelf.ProductOfArrayExceptSelfBruteForce()));
//Console.WriteLine(E_ContainsDuplicate.ContainsDuplicate());

#region Remove Duplicates
////int[] nums = { 1, 1, 2,2 , 3, 4,4, 5, 6, 6, 7, 8, 8, 9 };
//int[] nums = { 5, 3, 8, 3, 1, 5, 7, 8, 2 };
//var result = RemoveDuplicates.RemoveDuplicatesFromArray(nums);
//Console.WriteLine(string.Join(",", result));
#endregion

#region Maximum Product of Sub Array
//Console.WriteLine("Maximum Product of Sub Array = {0}",M_MaximumProductSubArray.MaxProductSubArray());
#endregion

#region Buy and Sell stock for maximum profit
//Console.WriteLine("Maximum profit = {0}", E_BuyAndSellStock.maxProfit());
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
//int[] array =[-4,-1,0,3,10];// { -3, 1, 2, 4, 5, 6, 8, 9 };
//var result = SquaredArray.SortedSquaredArray(array);
//var resultOption2 = SquaredArray.SortedSquaredArrayOption2(array);

//Console.WriteLine("Sorted Square Array: " + string.Join(",", result));
//Console.WriteLine("Sorted Square Array: " + string.Join(",", resultOption2));
#endregion

#region Maximum Subarray
//Console.WriteLine("Maximum Sub array sum = {0} ", E_MaximumSubarray.MaximumSubArrayTwoLoop());
#endregion

#region Search in Sorted Array
//M_SearchInSortedArray.SearchInSortedArrayCall();
#endregion

#region Sliding window concepts

//Console.WriteLine("Maximum Sub array = ", SlidingWindow.MaximumSumSubArray());
#endregion


#region Sub Array Equals Result

//new M_SubArrayEqualsOut().SubArrayEqualsResult();

#endregion
#region string Problems

#region Longest int without non repeating characters
//M_LongestintNon_RepeatingCharacter.LongestintNonRepeatingCharacterMaximumLength();
//int output = M_LongestintNon_RepeatingCharacter.LongestintNonRepeatingCharacter();
//Console.WriteLine("Longest int without repeating characters : " + output);
#endregion

#region String Compress
//M_CompressString m_CompressString = new M_CompressString();
//m_CompressString.CompressString();

#endregion

#region Valid Palindrome
//E_ValidPalindrome e_ValidPalindrome = new E_ValidPalindrome();
//e_ValidPalindrome.ValidPalindrome();
#endregion

#region Common Prefix
//E_LongestCommonPrefix e_LongestCommonPrefix = new E_LongestCommonPrefix();
//e_LongestCommonPrefix.LongestCommonPrefixString();
//Console.WriteLine("Output - "+e_LongestCommonPrefix.LongestCommonPrefixStringOption2());
#endregion

#region Remove all occurances in a string
//RemoveAllOccurrencesInString removeAllOccurrences = new RemoveAllOccurrencesInString();
//removeAllOccurrences.RemoveOccurrences();
#endregion
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

#region Sort
//Console.WriteLine("Bubble Sort = {0}",BubbleSort.BubbleSortMain());
//Console.WriteLine("Selection Sort = {0}", SelectionSort.SelectionSortMain());
//Console.WriteLine("Insertion Sort = {0}", InsertionSort.InsertionSortMain());
//MergeSort.MergeSortCall();
#endregion
#endregion


#region Concepts
#region Binary Tree
//BinaryTree.CallBinaryTree();
#endregion

#region Binary Tree Height

//Node root = new Node(1);
//root.left = new Node(2);
//root.right = new Node(3);
//root.left.left = new Node(4);
//root.left.right = new Node(5);

//Console.WriteLine(Height_BinaryTree.Height(root));

#endregion

#region Graph
//Classroom.CallClassroom();
#endregion

#region Linked List
LL lL = new LL();
lL.AddLast(10);
lL.AddLast(20);
lL.AddLast(30);
//lL.AddFirst(20);
//lL.AddFirst(40);
lL.AddLast(70);

lL.AddFirst(10);
lL.PrintNode();

//lL.GetSize();
//lL.RemoveLast();
//lL.RemoveFirst();
//lL.GetSize();
//lL.PrintNode();

// Inbuild LinkedList

//LinkedList<int> resultLL = new LinkedList<int>();
//resultLL.AddFirst(10);
//resultLL.AddFirst(20);
//resultLL.AddLast(40);
//Console.WriteLine(string.Join("->",resultLL));
//resultLL.RemoveFirst();
//resultLL.RemoveLast();
//Console.WriteLine(resultLL.Count());
#endregion
#endregion


#region Dynamic Programming
//H_SubSequence.SubSequenceMain();
#endregion

Console.WriteLine("Thank you");