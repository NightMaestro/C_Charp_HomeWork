// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Задание 10");
// Console.Write("Введите 3-х значное ччисло: ");
// string numbers = Console.ReadLine()!;
// start:
// if (numbers.Length>3)
// {
//   Console.WriteLine("Ошибка ввода, ведите 3-х значное число!!!");
//   Console.Write("Введите трехзначное число: ");
//   numbers = Console.ReadLine()!;
//   goto start;
// }
// Console.WriteLine ($"Вторая цифра цисла {numbers[1]}");


//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Задание 13");
// Console.Write("Введите число: ");
// string numbers = Console.ReadLine()!;
// start:
// if (numbers.Length<3)
// {
//   Console.WriteLine("Ошибка ввода, ведите трех или более разрядное число");
//   Console.Write("Введите : ");
//   numbers = Console.ReadLine()!;
//   goto start;
// }
// Console.WriteLine ($"Вторая цифра цисла {numbers[2]}");

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Задание 15");
Console.Write("Введите число: ");
string day = Console.ReadLine()!;
switch (day)
{
    case "1":
        Console.WriteLine("Будний день - понедельник");
        break;
    case "2":
        Console.WriteLine("Будний день - вторник");
        break;
    case "3":
        Console.WriteLine("Будний день - среда");
        break;
    case "4":
        Console.WriteLine("Будний день - четверг");
        break;
    case "5":
        Console.WriteLine("Будний день - пятница");
        break;
    case "6":
        Console.WriteLine("Выходной день - суббота");
        break;
    case "7":
        Console.WriteLine("Выходной день - воскресенье");
        break;
        default:
        Console.WriteLine("Введено не коректное число");
        break;
}
