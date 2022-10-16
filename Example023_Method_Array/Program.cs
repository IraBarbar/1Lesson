    int[] array = {1, 55, 44, 88, 64, 74, 22, 50, 95, 44};


    int n = array.Length;
    int find = 44;
    int index = 0;

    while ( index < n)
    {
        if(array[index]  == find)
        {
            Console.WriteLine(index);
            break;
    
        }
        index++;
    }