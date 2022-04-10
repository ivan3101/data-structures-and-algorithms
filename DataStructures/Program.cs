
using DataStructures.Arrays;

var arrOne = new int[] {0, 3, 4, 31, 105};
var arrTwo = new int[] {4, 30, 50, 99, 101};

var mergedArray = MergeSortedArrays.FirstWay(arrOne, arrTwo);

foreach (var n in mergedArray) {
    Console.WriteLine(n);
}