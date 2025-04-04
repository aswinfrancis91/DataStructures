// See https://aka.ms/new-console-template for more information

Console.WriteLine("Bubble Sort");

var arrayToSort = new int[] { 5, 8, 7, 5, 3 };
var sortedArray = BubbleSort(arrayToSort);
Console.WriteLine(string.Join(',', sortedArray.Select(x => x)));
return;

int[] BubbleSort(int[] inputArray)
{
    var hasSwapped = false;
    for (int i = 0; i < inputArray.Length; i++)
    {
        for (int j = 0; j < inputArray.Length - 1 - i; j++)
        {
            if (inputArray[j] > inputArray[j + 1])
            {
                //C#'s tuple deconstruction syntax, which was introduced in C# 7.0.
                //Same as:
                // var temp = inputArray[j];
                // inputArray[j] = inputArray[j + 1];
                // inputArray[j + 1] = temp;
                (inputArray[j], inputArray[j + 1]) = (inputArray[j + 1], inputArray[j]);
                hasSwapped = true;
            }
        }

        if (!hasSwapped)
            break;
    }

    return inputArray;
}