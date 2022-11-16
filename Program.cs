//Console.Write("Input your number: ");
//int number = Convert.ToInt32(Console.ReadLine());

/*Console.WriteLine("Введите число, квадрат которого нужно найти: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number * number;
Console.WriteLine($"квадрат {number} равен {result}");
*/

//a = 25, b = 5 -> yes 
//a = 2, b = 10 -> no
//a = 9, b = -3 -> yes
//a = -3, b = 9 -> no

/*Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number2 * number2 == number1)
{
    Console.WriteLine($"число {number1} является квадратом {number2}");
}
else
{
    Console.WriteLine($"число {number1} не являеться квадратом {number2}");
}
*/

//Программа, которая на вход принимает число одно(N) а на выходе показывает все целые числа в промежутке от (-N до N).

/*Console.WriteLine("Введите число N:");
int num = Convert.ToInt32(Console.ReadLine());
int current = num * (-1);
while(current <= num)
{
    Console.Write(current + " ");
    current++;
}
*/

/* 
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 99 && number < 1000)
{
 int current = number % 10;
 Console.WriteLine($"Последняя цифра числа {number} - {current}");
}
else
{
    Console.WriteLine("Число не трехзначное ");
}
*/

//Задача 2 
//Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

/*Console.WriteLine("Введите два числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"наибольшее число {number1}");
}
else 
{
    Console.WriteLine($"наибольшее число {number2}");
}
*/

//Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел

/*Console.WriteLine("Введите три числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2 && number1 > number3)
{
    Console.WriteLine($"Наибольшее число {number1}");
}
if (number2 > number1 && number2 > number3)
{
    Console.WriteLine($"Наибольшее число {number2}");
}
if (number3 > number2 && number3 > number2)
{
    Console.WriteLine($"Наибольшее число {number3}");
}
*/

//Задача 6: Напишите программу, которая на вход принимает число
// и выдает, является ли число четным 

/*Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine($"Число четное {number}");
}
else
{
    Console.WriteLine($"Число не четное {number}");
}
*/

// Задача 8: Напишите программу, которая на вход принимает число(N)
// а на выходе показывает все четные числа от 1 до N

/*Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Четные числа от 1 до {number}");
while (1 <= number)
{
    if (number % 2 == 0)
    {
    Console.WriteLine(number + ", ");
    }
    number++;
}
*/
//Решение так и не смог дадумать по последней задаче. Запускается "бесконечность чисел"
