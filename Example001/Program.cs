Console.Clear();

int Max (int []arr)
{
    int maxNumber = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (maxNumber < arr[i])
        {
            maxNumber = arr[i];
        }
    }

    return maxNumber;
}

int []array = {5, 88, 13, 67, 55, 4, 0, -3};

Console.Write("Max number = " + Max(array));
