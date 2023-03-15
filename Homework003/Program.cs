// Задание 19 (проверка числа на полиндром)
// string ReadString(string text)
// {
//   System.Console.Write(text);
//   return Console.ReadLine()!;
// }
// System.Console.WriteLine("Задание 19");
// System.Console.WriteLine("Проверка пятизначного числа на полиндром");
// string number = ReadString("Введите пятизначное число: ");
// if (number.Length == 5)
// {
//   if (number[0] == number[4] && number[1] == number[3])
//   {
//     System.Console.WriteLine($"Введенное число {number} является полиндромом");
//   }
//   else System.Console.WriteLine($"Введенное число {number} не является полиндромом");
// }
// else System.Console.WriteLine($"Вы ввели некоректное число");


// Задача 21 "Вычисление расстояния в 3-х метром пространстве"

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }
// double Distance (int ax, int ay, int bx, int by, int az, int bz)
// {
//   return Math.Sqrt(Math.Pow(bx-ax,2)+ Math.Pow(by-ay,2)+ Math.Pow(bz-az,2));
// }
// int[] a = new int[3];
// int[] b = new int[3];


// a[0]= ReadInt("Введите координату точки X точки А: ");
// a[1]= ReadInt("Введите координату точки Y точки А: ");
// a[2]= ReadInt("Введите координату точки Z точки А: ");

// b[0]= ReadInt("Введите координату точки X точки B: ");
// b[1]= ReadInt("Введите координату точки Y точки B: ");
// b[2]= ReadInt("Введите координату точки Z точки B: ");

// double sum = Distance(a[0],b[0],a[1],b[1],a[1],b[2]);
// System.Console.WriteLine($"Расстояние между точками {Math.Round(sum,4)}");


// Задача 23 Таблица кубов чисел

// int ReadInt(string text)
// {
//   System.Console.Write(text);
//   return Convert.ToInt32(Console.ReadLine());
// }

// void NumberPow(int number)
// {
//   for (int i = 1; i <= number; i++)
//   {
//     System.Console.Write(Math.Pow(i, 3) + " ");
//   }
// }

// int number = ReadInt("Введите число: ");
// NumberPow(number);
