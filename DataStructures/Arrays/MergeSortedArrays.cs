namespace DataStructures.Arrays;

// Given two sorted arrays of integers, merge them into one sorted array
// Example: Using [0, 3, 4, 31] and [4, 6, 30] as input, should return:
// [0, 3, 4, 4, 6, 30, 31]
public static class MergeSortedArrays
{
    // Using Merge sort 
    // Time complexity: O(n1 + n2) 
    public static int[] FirstWay(int[] arrOne, int[] arrTwo)
    {
        if (arrOne.Length < 1) return arrTwo;
        if (arrTwo.Length < 1) return arrOne;

        var mergedArrayLength = arrOne.Length + arrTwo.Length;
        var mergedArray = new int[mergedArrayLength];

        int indexOne = 0, indexTwo = 0, indexThree = 0;

        bool isArrayOneCompleted = false, isArrayTwoCompleted = false;

        while (!isArrayOneCompleted && !isArrayTwoCompleted) 
        {
            if (arrOne[indexOne] < arrTwo[indexTwo])
            {
                mergedArray[indexThree] = arrOne[indexOne];
                indexOne++;
                indexThree++;
            }
            else
            {
                mergedArray[indexThree] = arrTwo[indexTwo];
                indexTwo++;
                indexThree++;
            }

            isArrayOneCompleted = indexOne >= arrOne.Length;
            isArrayTwoCompleted = indexTwo >= arrTwo.Length;
        }

        while (!isArrayOneCompleted)
        {
            mergedArray[indexThree] = arrOne[indexOne];
            indexOne++;
            indexThree++;

            isArrayOneCompleted = indexOne >= arrOne.Length;
        }
        
        while (!isArrayTwoCompleted)
        {
            mergedArray[indexThree] = arrTwo[indexTwo];
            indexTwo++;
            indexThree++;

            isArrayTwoCompleted = indexTwo >= arrTwo.Length;
        }


        return mergedArray;
    }
}