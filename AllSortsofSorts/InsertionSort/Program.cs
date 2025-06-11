// See https://aka.ms/new-console-template for more information

Console.WriteLine("Insertion Sort");

var arrayToSort = new int[] { 5, 8, 7, 5, 3 };
var sortedArray = InsertionSort(arrayToSort);
Console.WriteLine(string.Join(',', sortedArray.Select(x => x)));


int[] InsertionSort(int[] inputArray)
{
    for (int i = 1; i < inputArray.Length; i++)
    {
        var j = i - 1;
        var currentValue = inputArray[i];
        while (j > -1 && inputArray[j] > currentValue)
        {
            inputArray[j + 1] = inputArray[j];
            j--;
        }
        inputArray[j + 1] = currentValue;
    }

    return inputArray;
}