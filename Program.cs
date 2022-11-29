// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
/*
int[] CreateRandomArray (int size, int minValue, int maxValue) //метод создания массива с ранд элементами
{
    int [] newArray = new int [size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}
void ShowArray(int[] array) //демострация массива
{
    for(int i = 0; i < array.Length; i++)
    Console.WriteLine(array[i] +" ");
    Console.WriteLine();
}
int FindSummPos(int[] array)
{
    int sumPos = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] > 0)
            sumPos += array[i];
    return sumPos;
}
int FindSummNeg(int[] array)
{
    int sunNeg = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] < 0)
            sunNeg += array[i];
    return sunNeg;
}
int size_array = 12;
int minValue_array = -9;
int maxValue_array = 9;

int[] CreatedArray = CreateRandomArray(size_array, minValue_array, maxValue_array);
ShowArray(CreatedArray);
Console.WriteLine($"Sum of positive elem is {FindSummPos(createdArray)}");
int resultNeg = FindSummNeg(CreatedArray);
Console.WriteLine($"Sum of negative elem is {resultNeg}");
*/

//Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//6 7 3 6] -> 36 21
/*
int[] CreateRandomArray (int size, int minValue, int maxValue) //метод создания массива с ранд элементами
{
    int [] newArray = new int [size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
}
void ShowArray(int[] array) //демострация массива
{
    for(int i = 0; i < array.Length; i++)
    Console.WriteLine(array[i] +" ");
    Console.WriteLine();
}

int[] FindMultiPar (int[] arrayCreated)
{
    int size2;
    if (array.Length % 2 == 0)
    size2 = size / 2;         // длина массива с произведением
    else size2 = (array_size + 1) / 2;
    int[] arrayMulti = new int[size2];
    for(int i = 0; i < arrayCreated.Length / 2; i++)
    {
        arrayMulti[i] = arrayCreated[i] * arrayCreated[arrayCreated.Length - 1 - i];
    }
    if(arrayCreated.Length % 2 != 0)
        arrayMulti[size2 - 1] = arrayCreated[size2 - 1];
    
    return arrayMulti;
}
Console.WriteLine("Input size if array: ");
int array_size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min possible val if array: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possible val if array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] array1 = CreateRandomArray(array_size, minValue, maxValue);
ShowArray(array1);
int[] array2 = FindMultiPar(array1);
ShowArray(array2);

*/



//Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
/*
int[] CreateRandomArray (int size, int minValue, int maxValue) //метод создания массива с ранд элементами
{
    int[] newArray = new int [size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
        // + Random().NextDouble(); //от 0 до 1
        //Math.Round(newArray[i], 3);
    }
    return newArray;
}
void ShowArray(int[] array) //демострация массива
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] +" ");
    Console.WriteLine();
}

int Count1099(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] > 9 && array[i] < 100)
        count++;
    return count;
}

Console.WriteLine("Input min possible val if array: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possible val if array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int size_array = 12;
int[] arrayCreated = CreateRandomArray(size_array, minValue, maxValue);
ShowArray(arrayCreated);
int res = Count1099(arrayCreated);
Console.WriteLine($"Count of elem between 10 and 99 is {res}");
*/

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
int[] CreateRandomArray (int size, int start, int end) 
{
    int[] newArray = new int [size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(start, end + 1);        
    }
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] +" ");
    Console.WriteLine();
}

int CountOfEven(int[] array1)
{
    int count = 0;
    for(int i = 0; i < array1.Length; i++)
        if(array1[i] % 2 == 0)
        count++;        
    return count;
}
int[] array1 = new int[3];
array1 = CreateRandomArray(3,100,1000);
ShowArray(array1);
Console.WriteLine("numbers : " + CountOfEven(array1));
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
/*
void CreateRandomArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void ShowArray (int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    Console.Write(numbers[i] + " ");
    Console.WriteLine();
}

Console.WriteLine("Input Array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
CreateRandomArray(numbers);
Console.WriteLine("Your array: ");
ShowArray(numbers);
int sum = 0;

for (int z = 0; z < numbers.Length; z+=2)
    sum = sum + numbers[z];

Console.WriteLine($"All {numbers.Length}, summ on the uneven = {sum}");
*/


//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
/*
int[] CreateRandomArray (int[] numbers) 
{
    //int[] newArray = new int [size];
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(10, 1000);        
    }
    return numbers;
}
void ShowArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    Console.Write(numbers[i] +" ");
    Console.WriteLine();
}

Console.WriteLine("Input array");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
CreateRandomArray(numbers);
Console.WriteLine("Your Array: ");
ShowArray(numbers);
int min = Int32.MaxValue;
int max = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
        {
            max = numbers[i];
        }
    if (numbers[i] < min)
        {
            min = numbers[i];
        }
}

Console.WriteLine($"All {numbers.Length} numbers. Maximum = {max}, Minimum = {min}");
Console.WriteLine($"Difference = {max - min}");
*/

