var arr = new int[] { 1, 4, 8, 9, 6, 5, 8 };
SortArray(in arr, out int[] arr1, out int[] arr2);
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();

for (int i = 0; i < arr1.Length; i++)
{
    Console.Write(arr1[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < arr2.Length; i++)
{
    Console.Write(arr2[i] + " ");
}
static void SortArray(in int[] array, out int[] sortedasc, out int[] sorteasc)
{
    sortedasc = SortArrayDasc(array);
    sorteasc = SortArrayAsc(array);
}

static int[] SortArrayDasc(int[] array)
{
    int temp;
    int[] newArray = new int[array.Length];
    array.CopyTo(newArray, 0);
    for (int i = 0; i < newArray.Length; i++)
    {
        for (int j = i + 1; j < newArray.Length; j++)
        {
            if (newArray[j] > newArray[i])
            {
                temp = newArray[i];
                newArray[i] = newArray[j];
                newArray[j] = temp;
            }
        }
    }

    return newArray;
}

static int[] SortArrayAsc(int[] array)
{
    int temp;
    int[] newArray = new int[array.Length];
    array.CopyTo(newArray, 0);
    for (int i = 0; i < newArray.Length; i++)
    {
        for (int j = i + 1; j < newArray.Length; j++)
        {
            if (newArray[j] < newArray[i])
            {
                temp = newArray[i];
                newArray[i] = newArray[j];
                newArray[j] = temp;
            }
        }
    }

    return newArray;
}
