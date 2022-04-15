namespace DataStructures.Recursion;

// Fibonnaci numbers
public static class Fibonacci
{
    private const int Limit = 1000000;
    private static ulong[] ComputedResults = new ulong[Limit];
    
    // Brute force
    // Time complexity: O(2^n)
    public static ulong FirstWay(int number)
    {
        if (number <= 1) return 0;

        return FirstWay(number - 1) + FirstWay(number - 2);
    }
    
    // Dynamic Programming - Memoization
    // Time complexity: Linear time O(n)
    public static ulong SecondWay(int number)
    {
        if (number >= Limit) return 0;
        
        if (ComputedResults[number] == 0)
        {
            if (number <= 1) ComputedResults[number] = (ulong) number;

            else ComputedResults[number] = SecondWay(number - 1) + SecondWay(number - 2);
        }

        return ComputedResults[number];
    }

    // Dynamic Programming - Tabulation
    // Time complexity: Linear time O(n)
    public static ulong ThirdWay(int number)
    {
        if (number >= Limit) return 0;

        var computedResults = new ulong[number + 1];
        computedResults[0] = 0;
        computedResults[1] = 1;

        for (var i = 2; i <= number; i++)
        {
            computedResults[i] = computedResults[i - 1] + computedResults[i - 2];
        }

        return computedResults[number];
    }
}