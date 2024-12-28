namespace ProblemSolving.Recursion;

internal class Recursion
{
    /// <summary>
    /// Reverse a string
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
       F(2)=F(1)+F(0)=1+0=1F(2) = F(1) + F(0) = 1 + 0 = 1F(2)=F(1)+F(0)=1+0=1
       F(3)=F(2)+F(1)=1+1=2F(3) = F(2) + F(1) = 1 + 1 = 2F(3)=F(2)+F(1)=1+1=2
       F(4)=F(3)+F(2)=2+1=3F(4) = F(3) + F(2) = 2 + 1 = 3F(4)=F(3)+F(2)=2+1=3
       F(5)=F(4)+F(3)=3+2=5F(5) = F(4) + F(3) = 3 + 2 = 5F(5)=F(4)+F(3)=3+2=5

    */
    /// </summary>
    /// <returns></returns>
    public static int FibonacciValue(int n)
    {

        if (n <= 1)
            return n;
        return FibonacciValue(n - 1) + FibonacciValue(n - 2);

    }
}
