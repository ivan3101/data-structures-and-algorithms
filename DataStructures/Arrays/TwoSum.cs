using System.Collections;

namespace DataStructures.Arrays;

// Given an array of integers numbers and a integer target,
// return indices of the two numbers such that they add up to target
// Example: Using [2, 7, 11, 15] and 9 as input, should return:
// (0, 1)
// Constraints:
// 1. Each input have exactly one solution
// 2. The array is not sorted
public static class TwoSum
{
    // Using Dictionary
    // Time complexity: Linear time O(n)
    public static (int, int) FirstWay(int[] numbers, int target)
    {
        var complAndIndex = new Dictionary<int, int>();
        var result = (0, 0); 

        for (var i = 0; i < numbers.Length; i++)
        {
            if (complAndIndex.ContainsKey(numbers[i]))
            {
                result = (complAndIndex[numbers[i]], i);
                break;
            }

            var compl = target - numbers[i];
            complAndIndex[compl] = i;
        }

        return result;
    }
    
    // Using brute force
    // Time complexity: Quadratic time O(n^2)
    public static (int, int) SecondWay(int[] numbers, int target)
    {
        var result = (0, 0); 

        for (var i = 0; i < numbers.Length; i++)
        {
            for (var j = i + 1; j < numbers.Length; j++)
            {
                var sum = numbers[i] + numbers[j];

                if (sum == target)
                {
                    result = (i, j);
                }
            }
        }

        return result;
    }
}