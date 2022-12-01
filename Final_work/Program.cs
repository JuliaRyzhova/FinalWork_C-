

string[] CreatetArray3CharsMAX(string[] arr)
{
    int lengthMax = 3;
    int count = 0;
    string[] resultArray = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= lengthMax)
        {
            resultArray[count] = arr[i];
            count++;
        }
    }
    return resultArray;

}

void ShowArray(string[] array, string info)
{
    Console.WriteLine(info);
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

string[] array = new string[] { "hello", "2", "world", ":)" };
ShowArray(array, "The source array is: ");

string[] resultArray = CreatetArray3CharsMAX(array);
ShowArray(resultArray, "The new created array is: ");
