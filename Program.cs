// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
System.Console.WriteLine("Введите 5-ти значное число ");
string number = Console.ReadLine()!;
if (number.Length == 5)
{
    if (number[0]==number[4]&&number[1]==number[3])
    {
        Console.WriteLine($"{number} -> да ");
    }
    else
    {
        Console.WriteLine($"{number} -> нет ");
    }
}
else
{
    Console.WriteLine("Введено неверно число");
}