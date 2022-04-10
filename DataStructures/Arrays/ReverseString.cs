namespace DataStructures.Arrays;

// Given a string, it should return the string reversed
// Example: Using "Hello World!" as input should return:
// "!dlroW olleH"
public static class ReverseString
{
    // Manual way
    // Time complexity: Linear time O(n)
    public static string FirstWay(string s)
    {
        if (s.Length < 2) return s;
        
        var reversedChars = new char[s.Length];

        for (var i = 0; i < s.Length; i++)
        {
            reversedChars[i] = s[s.Length - i - 1];
        }

        return new string(reversedChars);
    }

    // LINQ way
    // Time
    public static string SecondWay(string s)
    {
        if (s.Length < 2) return s;
        
        return s.Reverse().ToString()!;
    }
}