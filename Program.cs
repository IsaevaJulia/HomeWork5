//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2


/*
int [] MyArray (int size)
{
    int [] newArrey = new int [size];
    for (int i = 0; i < size; i++)
    {
        newArrey[i] = new Random().Next(100,1000);
        
    }
    return newArrey;
}

void PrintArray(int[] array)
{
    Console.Write("Массив -> ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void EvenNumber (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count = count + 1;                 
        
    }
    Console.WriteLine($"количество чётных чисел в массиве -> {count}"); 
}

Console.WriteLine("Введите размер массива  ");
int a = Convert.ToInt32(Console.ReadLine());

int [] myNewArrey = MyArray(a);
PrintArray(myNewArrey);

EvenNumber(myNewArrey);
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

/*
int [] RandomArray (int size)
{
    int [] newArrey = new int [size];
    for (int i = 0; i < size; i++)
    {
        newArrey[i] = new Random().Next(0,100);
        
    }
    return newArrey;
}

void PrintArray(int[] array)
{
    Console.Write("Массив -> ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int NotEvenNumber(int [] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] %2 == 0){}       
                    
        else sum =sum + array [i];       
                                
    }     
    return sum;      
          
}
Console.WriteLine("Введите размер массива  ");
int a = Convert.ToInt32(Console.ReadLine());


int [] myArrey = RandomArray(a);
PrintArray(myArrey);
int result = NotEvenNumber(myArrey);
Console.WriteLine($"сумма нечетных чисел = {result}");
*/

//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

double [] RandomArray (int a)
{
    double [] newArrey = new double [a];
    for (int i = 0; i < a; i++)
    {
        newArrey[i] = Convert.ToDouble( new Random().Next(-100,100));        
    }
    return newArrey;
}

void PrintArray(double[] array)
{
    Console.Write("Массив -> ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double MinNumber(double[] array)
{
    double MinNumber = array [0];    
    for (int i = 0; i < array.Length; i++)
    {
        if(array [i] < MinNumber) MinNumber = array [i];
    }
    return MinNumber;
}
double MaxNumber(double[] array)
{    
    double MaxNumber = array [0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array [i] > MaxNumber) MaxNumber = array [i];
    }
    return  MaxNumber;
}

void MinMaxDef(double a, double b)
{
    double difference = a - b;
    Console.WriteLine($"Разница между максимальным и минимальным -> {difference}");
}

Console.WriteLine("Введите размер массива  ");
int a = Convert.ToInt32(Console.ReadLine());

double [] myArrey = RandomArray(a);
PrintArray(myArrey);
double min = MinNumber(myArrey);
double max = MaxNumber(myArrey);
Console.WriteLine($"min -> {min}, max -> {max}");
MinMaxDef(max,min);
