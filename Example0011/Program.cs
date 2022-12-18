Console.Clear();
int[] arr = {11, 5, 3, 7, 5, 11, 6, 71, 9, 12};
void Print(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
// void SelectSort(int[] array)
// {
//     for(int i = 0; i < array.Length - 1; i++)
//     {
//         int minP = i;
//         for(int j = i + 1; j < array.Length; j++)
//         {
//             if(array[j] < array[minP])
//             {
//                 minP = j;
//             }
//         }
//         int temp = array[i];
//         array[i] = array[minP];
//         array[minP] = temp;
//     }
// }

void SelectMax(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int maxP = i;
        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[maxP])
            {
                maxP = j;
            }
        }
        int temp = array[i];
        array[i] = array[maxP];
        array[maxP] = temp;
    }
}

void FindMin(int[] array)
{
    int min = array[0];
    int max = array[0];
    int result = 0;
    for(int i = 0; i < array.Length; i++)
    {
        // min = i;
        if (array[i] < min)
        {
            min = array[i];
        } 
        if (array[i] > max)
        {
            max = array[i];
        }     
    }
    result = max - min;
    // return min;
    Console.WriteLine("Разница между максимальным и минимальным элементом = " + result);
    // Console.ReadLine();
}


Print(arr);
// SelectMax(arr);

// Print(arr);

FindMin(arr);
// Console.Write("Минимальное число = " + result);