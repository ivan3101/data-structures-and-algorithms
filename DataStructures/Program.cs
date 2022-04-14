
using DataStructures.Arrays;

var numbers = new int[] { 1,1,1,1,1,4,1,1,1,1,1,7,1,1,1,1,1 };
const int target = 11;

var result = TwoSum.FirstWay(numbers, target);

Console.WriteLine($"[{result.Item1}, {result.Item2}]");