using System.IO;

namespace ProblemSolving.Concepts.Recursion;

internal class Recursion
{

    /*
     
    Let's break it down with SumOfNumber(3):

    Initial Call: SumOfNumber(3)

    The function checks if num == 0. It's not, so it proceeds to:
    return 3 + SumOfNumber(2)
    State: The stack now has SumOfNumber(3) waiting for SumOfNumber(2) to return.

    Recursive Call 1: SumOfNumber(2)

    The function checks if num == 0. It's not, so it proceeds to:
    return 2 + SumOfNumber(1)
    State: The stack now has SumOfNumber(3) and SumOfNumber(2) waiting for SumOfNumber(1).

    Recursive Call 2: SumOfNumber(1)

    The function checks if num == 0. It's not, so it proceeds to:
    return 1 + SumOfNumber(0)
    State: The stack now has SumOfNumber(3), SumOfNumber(2), and SumOfNumber(1) waiting for SumOfNumber(0).
    Base Case: SumOfNumber(0)

    The function checks if num == 0. It is, so it returns 0.
    State: The stack starts to unwind since the base case is reached.


    Unwinding the Stack


    Now that SumOfNumber(0) has returned, the stack unwinds:

    SumOfNumber(1):
    return 1 + 0 = 1
    The stack pops SumOfNumber(1).

    SumOfNumber(2):
    return 2 + 1 = 3
    The stack pops SumOfNumber(2).

    SumOfNumber(3):
    return 3 + 3 = 6
    The stack pops SumOfNumber(3).

    */

    public static int SumOfNumber(int num)
    {
        if (num == 0)
            return 0;
        return num + SumOfNumber(num - 1);

    }


    /// <summary>
    /// Reverse a string
    /// 
    /// ReverseString("abc")
    /// ├── ReverseString("bc")
    /// │   └── ReverseString("c")
    /// │       └── ReverseString("")
    /// │           └── return ""
    /// │       └── return "" + "c" = "c"
    /// │   └── return "c" + "b" = "cb"
    /// └── return "cb" + "a" = "cba"

    /// </summary>
    /// <param name="input">hello</param>
    /// <returns>olleh</returns>
    public static string ReverseString(string input)
    {
        if (input.Equals("")) return "";
        return ReverseString(input.Substring(1)) + input[0];
    }

    /// <summary>
    /// Is input string palindrome or not
    /// </summary>
    /// <param name="str">racecar</param>
    /// <returns>true</returns>
    public static bool IsPalindrome(string str)
    {
        if (str.Length == 0 || str.Length == 1) return true;

        if (str[0] == str[str.Length - 1])
        {
            return IsPalindrome(str.Substring(1, str.Length - 2));
        }

        return false;
    }

    /// <summary>
    /// Convert Decimal To Binary
    /// </summary>
    /// <param name="number">233</param>
    /// <param name="result">11101001</param>
    /// <returns></returns>
    public static string DecimalToBinary(int number, string result)
    {
        if (number == 0) return result;

        result = number % 2 + result;
        return DecimalToBinary(number / 2, result);
    }

    /// <summary>
    /// Sum of natural number
    /// </summary>
    /// <param name="num">10</param>
    /// <returns>55</returns>
    public static int SumOfNaturalNo(int num)
    {
        if (num <= 1)
            return num;

        return num + SumOfNaturalNo(num - 1);
    }

    /// <summary>
    /// Fibonacci Series
    /*
     * F(0)=0
       F(1)=1F(1) = 1F(1)=1
       F(2)=F(1)+F(0)=1+0= 1F(2) = F(1) + F(0) = 1 + 0 = 1F(2)=F(1)+F(0)=1+0=1
       F(3)=F(2)+F(1)=1+1=2F(3) = F(2) + F(1) = 1 + 1 = 2F(3)=F(2)+F(1)=1+1=2
       F(4)=F(3)+F(2)=2+1=3F(4) = F(3) + F(2) = 2 + 1 = 3F(4)=F(3)+F(2)=2+1=3
       F(5)=F(4)+F(3)=3+2=5F(5) = F(4) + F(3) = 3 + 2 = 5F(5)=F(4)+F(3)=3+2=5

    */


    // Recursive Tree for fib(4):
    //               fib(4) [1]
    //              /          \
    //        fib(3) [2]       fib(2) [7]
    //        /       \          /      \
    //   fib(2) [3]  fib(1) [6] fib(1) [8] fib(0) [9]
    //   /     \
    // fib(1) [4] fib(0) [5]

    //fib(4) [Call #1]
    //├── fib(3) [Call #2]
    //│   ├── fib(2) [Call #3]
    //│   │   ├── fib(1) [Call #4] (Base case, returns 1) 
    //│   │   └── fib(0) [Call #5] (Base case, returns 0)
    //│   └── fib(1) [Call #6] (Base case, returns 1)
    //└── fib(2) [Call #7]
    //    ├── fib(1) [Call #8] (Base case, returns 1)
    //    └── fib(0) [Call #9] (Base case, returns 0)

    //fib(2) = fib(1) + fib(0) = 1 + 0 = 1.
    //fib(3) = fib(2) + fib(1) = 1 + 1 = 2.
    //fib(4) = fib(3) + fib(2) = 2 + 1 = 3


    /// </summary>
    /// <returns></returns>
    public static int FibonacciValue(int n)
    {

        if (n <= 1)
            return n;
        return FibonacciValue(n - 1) + FibonacciValue(n - 2);

    }
}
