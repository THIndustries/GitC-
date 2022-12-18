Console.Clear();
//Двумерные массивы и рекурсия.
// string[,] table = new string[2,3]; //[,] - это указание на то, что это двумерный массив.В данном случае таблица из строк.
// int[,] matr = new int[5,8]; // в данном случае будет - 5 строк и 8 столбцов. [5, 8]

string[,] table = new string[2, 5];
//String.Empty;
// table[0, 0] table[0, 1] table[0, 2] table[0, 3] table[0, 4]
// table[1, 0] table[1, 1] table[1, 2] table[1, 3] table[1, 4]

table[1, 2] = "слово"; //таким образом обращаемся к нужному элементу. наименование массива и его индекс.

//используем цикл, чтобы распечатать этот массив.
// for(int rows = 0; rows < 2; rows++)
// {
//     for(int colums = 0; colums < 5; colums++)
//     {
//         Console.WriteLine($"{table[rows, colums]}-");
//     }
// }

/*
void PrintArray(int[,] matr)
{    
    for(int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for(int colums = 0; colums < matr.GetLength(1); colums++)
        {
            Console.Write($"{matr[rows, colums]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

int[,] matrix = new int[3, 4];

PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
*/


//Порисуем
//Рекурсия, это функция, которая вызывает сама себя

//Рекурсия вычисления факториала
// 5! = 5 * 4 * 3 * 2 * 1
//1! = 1
//0! = 1
/*
double Factorial (int n)
{
    if(n == 1) return 1;
    else return n * Factorial(n - 1);
}
for(int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
// Console.WriteLine(Factorial(10));
*/



//f(1) = 1
//f(2) = 1
//f(n) = f(n-1) + f(n-2)

// int Fibonacci(int n)
// {
//     if(n == 1 || n == 2) return 1;
//     else return Fibonacci(n-1) + Fibonacci(n-2);
// }

// for(int i = 1; i < 100; i++)
// {
//     Console.WriteLine($"f[{i}] = {Fibonacci(i)}");
// }




//Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
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
    Console.WriteLine();   
}

void ReversArray(int[] array)
{
    for(int i = 0, j = array.Length - 1; i < 2; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;

    }
}

Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
ReversArray(myArray);
ShowArray(myArray);
*/


//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
/*
bool Trangl(double a, double b, double c)
{
    if(a+ b > c)
        if(b+c > a)
            if(a+c > b)
                return true;
    return false;
}
Console.Write("Введите a: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите c: ");
int numC = Convert.ToInt32(Console.ReadLine());

bool result = Trangl(numA, numB, numC);
Console.WriteLine(result);
*/

//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.


/*
int[] Fibanacci(int a, int b, int n)
{
    int[] array = new int[n];
    array[0] = a;
    array[1] = b;
    for(int i=2; i < n; i++)
    {
        array[i] = array[i-1] + array[i-2];
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

Console.Write("Введите A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write("последнее число: ");
int numC = Convert.ToInt32(Console.ReadLine());

int[] myArray = Fibanacci(numA, numB, numC);
ShowArray(myArray);
*/

//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] CreateRandomArray(int size, int minValue, int maxValue) // генерирует массив с заданными параметрами
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
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

int [] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}


Console.Write("Введите A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write("последнее число: ");
int numC = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(numA, numB, numC);
ShowArray(newArray);