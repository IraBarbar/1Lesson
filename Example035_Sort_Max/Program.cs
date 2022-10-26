int[] arr = new int [10];

void PrintArrayRandom(int[] array)
{
    Random rnd = new Random();
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        array[i] = rnd.Next(0, 15);
        Console.Write($"{array[i]} ");
    }
Console.WriteLine();
}

PrintArrayRandom(arr);

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length-1 ; i++)
    {
        int maxPosition = i;
        for(int j = i+1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition])
            maxPosition = j;
        }
    int help = array[i];
    array[i] = array[maxPosition];
    array[maxPosition] = help;

    }

}
SelectionSort(arr);

void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
             Console.Write($"{array[i]} ");
    }
Console.WriteLine();
}

PrintArray(arr);