Console.Clear();
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue) // генерирует массив с заданными параметрами
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i] + " ");
    Console.WriteLine();
}

int GetSumOfNegatives(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] < 0) 
            sum += array[i];
    return sum;
}

Console.Write("Введите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
/*
int result = GetSumOfNegatives(myArray);
Console.WriteLine("Sum of negative elements is" + (GetSumOfNegatives{sum}));
*/







//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

/*
int[] CreateRandomArray (int size, int min, int max) //, int min, int max
{
    int[] array = new int [size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1); //min, max + 1
    }
    return array;    
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"array [{i + 1}] is {array[i]}");
    }
    Console.WriteLine("\nПеревернутые числа: ");   // добавит сроку с данным текстом перед следующим выводом 
}


int[] Revers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < array.Length)
        {
            array[i] = array[i] * -1;
        }        
    }
    return array;
    Console.WriteLine();
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите min: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

int[] result = Revers(myArray);
ShowArray(result);
*/


//Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].
/*
int[] CreateRandomArray (int size) //, int min, int max
{
    int[] array = new int [size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10 + 1); //min, max + 1
    }
    return array;    
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"array [{i + 1}] is {array[i]}");
    }    
}

int Find(int[] array, int numA, int numB)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= numA && array[i] <= numB)
            count++;
    }
    return count;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите numA: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите numB: ");
int numB = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size);
ShowArray(myArray);

int result = Find(myArray, numA, numB);
Console.Write($"количество элементов массива, значения которых лежат в отрезке = {result}");
*/

//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.


int[] CreateRandomArray (int size, int min, int max) //, int min, int max
{
    int[] array = new int [size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1); //min, max + 1
    }
    return array;    
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"array [{i + 1}] is {array[i]}");
    }
    Console.WriteLine();   
}

int[] Proiz(int[] array)
{
    int size = array.Length / 2;
    if(size % 2 != 0)
        size++;     
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
    {
       newArray[i] = array[i] * array[array.Length - 1 - i];
    }
    return newArray;
}

Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
int [] result = Proiz(myArray);
ShowArray(result);

