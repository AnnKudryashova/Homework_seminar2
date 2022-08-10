// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
Console.WriteLine("Введите трехзначное целое число");

int number = int.Parse(Console.ReadLine());

//int firstNumber = number/10;

int secondNumber = number/10%10;

if (secondNumber < 0)
{
    secondNumber = secondNumber * (-1);
} 

Console.WriteLine(secondNumber);
