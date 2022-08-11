//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    number = number*(-1);
}

string numberArray = Convert.ToString(number);

if (numberArray.Length > 2)
{
    Console.WriteLine(numberArray[2]);    
}
else
{
    Console.WriteLine("третьей цифры нет"); 
}