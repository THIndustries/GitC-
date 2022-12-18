// void FillArray(int[] collection)

// {
//     int length = collection.Length;
//     int index = 0;
//     while(index < length)
//     {
//         collection[index] = new Random().Next(1, 10);
//         index++;
//     }
// }
// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }


// int IndexOf(int[] collection, int find)
// {
//     int count = collection.Length;
//     int index = 0;
//     int position = -1;
//     while(index < count)
//     {
//         if(collection[index] == find)
//         {
//             position = index;
//             break;
//         }
//         index++;
//     }
//     return position;
    
// }

// int[] array = new int[10]; //создай новый массив вкотором будет десять эллементов

// FillArray(array);
// array[4] = 4;
// array[6] = 4;

// PrintArray(array);
// Console.WriteLine();

// int pos = IndexOf(array, 4);
// Console.WriteLine(pos);

// Console.Clear();
// void Poli(int num)
// {
//     int n = num; // переменная которая будет хранить число
//     int rev = 0; // переменная, в которой будет хранится это же число, но развернутое наоборот
//     while (n != 0)
//     {
//         int r = n % 10; // переменная, в которой будет хранится последняя цифра числа, с помощью откусывания младших разрядов
//         rev = rev * 10 + r; // "склабываю" откусанные младшие разряды в подготовленную переменную
//         n = n / 10; // отделяю младший разряд от искомого числа, чтобы продолжить с ним работу на следующей итерации.
//     }
//     if(rev == num)
//     {
//         Console.WriteLine($"Number {num} is Polindrom.");
//     }
//     else
//     {
//         Console.WriteLine($"Number {num} is NOT Polindrom.");
//     }
// }
// Console.Write("Input number: ");
// int myNum = Convert.ToInt32(Console.ReadLine());

// Poli(myNum);

// Напишите программу, которая на вход принимает некоторое число N и выдает сумму чисел от 1 до N.
// Console.Clear();
// int SumOfNumbers(int num)
// {
//     int sum = 0;
//     if(num == 0) return 1;
//     for(int i = 1; i <= num; i++)
//     {
//         sum = sum + i;        
//     }
//     return sum;
// }
// Или
// {
    
//     int sum = 0;
//     while(num > 0)
//     {
//         sum = sum + num;
//         num = num - 1;  
       
//     }
//     return sum;
// }
// Console.Write("Введите число: ");
// int myNum = Convert.ToInt32(Console.ReadLine());

// int result = SumOfNumbers(myNum);
// Console.WriteLine($"Сумма чисел от 1 до {myNum} равна {result}");
//--------------------------------------------------------------------------------------------------------------------------------------
/*
//Массивы
// 1. как массив попадёт в программу
// 2. в каком виде массив будет предоставлен пользователю
//Обрати внимение, что пока мы работаем ТОЛЬКО со СТАТИЧНЫМИ массивами - т.е. строго фиксированным размером, память под которую выделяется единовременно.
// Метод, который сгенерирует целочисленный массив, заполненный случайными значениями: (свой аналог связки WriteLine и ReadLine, только для массива)

//указываем, что возвращаемый тип имеет отношение к массиву [], если мы хотим вернуть именно массив, если скобки не указать, то это обычный возврат переменной.
int[] CreateRandomArray(int size, int min, int max ) // по агрументам - первая информация, которую нужно ввести, чтобы получить массив, это размер этого массива.
{
    int[] array = new int[size]; //инициализируем\создаем массив\ выделяем под массив память, перед таем как продолжить заподнять тело функции
    // командное слово new - связано с выделением памяти под обьекты и в случае с массивами это тоже актуально. 
    //конструкция new int[size] - говорит, сколько памяти нужно выделить - попять под одну int пемеременную умножить на кол-во этих int переменных в массиве (size).

    //заполняем наш массив
    //для обращения отдельных элементов массива, мы используем его индекс.
    //индекс последнего элемента массива, всегда меньше размера массива на единицу. поэтому, если мы хотим пробежаться по всему массиву, мы используем:
    //i < size, а не i == size
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1); 
//Обрати внимение на + 1 в аргментах у функции генерации случайного числа. Связанно это с тем, что генератор работает в рамках(]  и нижний диапазон полностью включен,
//то верхний нет, и если я хочу чтобы код функцианировал как надо, то надо добивить + 1 к верхнему диапазону. 
    }
    return array; // обрати внимание, возвращаем мы массив указывая только его имя, без скобок.
}

//теперь будем выводить массив, как это сделать? обычным WriteLine массив мы не выведем, поэтому напишем для этого отдельный метод.
void ShowArray(int[] array) //обрати внимание - тип метода void, потому что нам нужно чтобы он выводил информацию сразу в консоль, а не возвращал в программу
//в качестве аргумента указываем массив, который хотим показать
{
    for(int i = 0; i < array.Length; i++) //array.Length - команда, которая поможет нам определить размер любого массива
    {
        Console.WriteLine($"array[{i + 1}] is {array[i]}");
    }
}   

Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max); //выделяем память под наш массив и запросим туда то, что вернёт наш метод, а в качестве аргументов отправим
//переменные, которые ввел пользователь. Теперь, обладая методом, мы создаем массив всего за одну строчку.

ShowArray(myArray); //отправляем название, без пояснений, что это массив. причина в том, что мы отправляем не совсем массив, а ссылку.
*/


// Console.Clear();
// int[] CreateArray()
// {
//     Console.Write("Введите размер массива: ");
//     int mySize = Convert.ToInt32(Console.ReadLine());
//     int[] array = new int[mySize];
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"Введите элемент по индексом {i}: ");        
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;

// }
// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine($"array[{i+1}] = {array[i]}");
//     }
// }
// // Console.Write("Введите размер: ");
// // int size = Convert.ToInt32(Console.ReadLine());

// // Console.Write("Введите min: ");
// // int min = Convert.ToInt32(Console.ReadLine());

// // Console.Write("Введите max: ");
// // int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateArray();
// ShowArray(myArray);


//     static void Test(string[] arg)
//     {
//         Console.Write("Введите кол-во элементов массива: ");

//         int size = int.Parse(Console.ReadLine());

//         int[] array = new int[size];
//         for(int i = 0; i < array.Length; i++)
//         {
//             Console.Write($"Введите элемент массива под индексом {i}: ");
//             array[i] = Convert.ToInt32(Console.ReadLine());
//         }
        
//         Console.Write("Вывод массива: ");

//         for(int i = 0; i < array.Length; i++)
//         {
//             Console.Write(array[i]);
//         }
//         Console.ReadLine();
//     }
// Test();


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// Console.Clear();
// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"Введите элемент по индексом {i}: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;    
// }
// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine($"arrai[{i + 1}] = {array[i]}");
//     }
// }

// void SelecthionSort(int[] array)
// {
//     for(int i = 0; i < array.Length - 1; i++)
//     {
//         int minPos = i;
//         for(int j = i + 1; j < array.Length; j++)
//         {
//             if(array[j] < array[minPos])
//             {
//                 minPos = j;
//             }            
//         }
//         int temporary = array[i];
//         array[i] = array[minPos];
//         array[minPos] = temporary;
//     }
//     Console.WriteLine("\nОтсортируем: ");
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// // Console.Write("Введите min: ");
// // int min = Convert.ToInt32(Console.ReadLine());

// // Console.Write("Введите max: ");
// // int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateArray(size);
// Console.WriteLine();
// ShowArray(myArray);

// SelecthionSort(myArray);
// ShowArray(myArray);











// Console.Clear();

// int[] arr = {1, 31, 5, 11, 8, 4, 91, 22};

// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for(int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]}");
//     }
//     Console.WriteLine();
// }
// void SelecthionSort(int[] array)
// {
//     for(int i = 0; i < array.Length - 1; i++)
//     {
//         int minPos = i;
//         for(int j = i + 1; j < array.Length; j++)
//         {
//             if(array[j] < array[minPos])
//             {
//                 minPos = j;
//             }            
//         }
//         int temporary = array[i];
//         array[i] = array[minPos];
//         array[minPos] = temporary;
//     }
// }
// PrintArray(arr);
// SelecthionSort(arr);

// PrintArray(arr);


//напишите цикл, который принимает н вход два чила а и б и возводит число а в степень б

// 3 5 243
// 2 4 16

// int Method(int arg1, int arg2)
// {
//     int result = 1;
//     for(int i = 0; i < arg2; i++)
//     {
//             result = result * arg1;
//     }
//     return result;
// }

// Console.Write("Input first number:\t");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number:\t");
// int numB = Convert.ToInt32(Console.ReadLine());

// int result = Method(numA, numB);
// Console.Write(result);


//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.


// Console.Clear();
// int[] CreateArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"Введите элемент по индексом {i}: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;    
// }
// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine($"arrai[{i + 1}] = {array[i]}");
//     }
// }

// int GetSumOfnegatives(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] < 0)
//         {
//             sum = sum + array[i];
//         }
//     }
//     return sum;
// }

// Console.Write("Введите размер: ");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите min: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите max: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateArray(size, min, max);
// ShowArray(myArray);

// int result = GetSumOfnegatives(myArray);

