Console.Clear();
//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
/*
bool Triangle(double a, double b, double c)
{
    if(a + b > c)
        if(a + c > b) 
            if(c + b > a)
                return true;
    return false;   
}

Console.Write("Введите сторону а: ");
double a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону b: ");
double b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону c: ");
double c = Convert.ToInt32(Console.ReadLine());

bool result = Triangle(a, b, c);
if(result == true)
{
    Console.Write("Такой треугольник возможен.");
}
if(result == false)
{
     Console.Write("Такой треугольник не возможен.");
}
*/

//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.


int[] Fibo(int a, int b)
{    
    Console.Write("Введите N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[n];
    array[0] = a;
    array[1] = b;
    for(int i = 2; i < n; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"array[{i}] = {array[i]}");
    }
    Console.WriteLine();
}

/*
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] myArray = Fibo(a, b);
ShowArray(myArray);
*/

//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] CreateArray()
{
    Console.Write("Введите размер своего массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите minValue: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите maxValue: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void Revers(int[] array)
{
    int[] newArray = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
}
/*
int[] myArray = CreateArray();
ShowArray(myArray);

Revers(myArray);
ShowArray(myArray);
*/



int CreateArrayFromUser()
{
    Console.Write("Введите кол-во чисел: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    int count = 0;
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1}е число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        if(array[i] > 0)        
            count ++;        
    }  
    return count;
    
}

int result = CreateArrayFromUser();
Console.WriteLine("Кол-во чисел больше 0, из введенных вами, равно " + result);

