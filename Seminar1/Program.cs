// Задание 1. Напишите программу кот.на вход принимает два числа и прверяет, является ли первое число квадратом второго
// a=25; b=5;
// a=2; b=10;
// a=9; b=3; 
// a=3; b=-9;

// Console.Write("Введите первое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int b = int.Parse(Console.ReadLine()!);
// int quad = b * b;
// if (quad == a)
// {
//   Console.WriteLine($"{a} является квадратом {b}");
// }
// else Console.WriteLine($"{a} не является квадратом {b}");


// //Задание 2. Дни недели
// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// if (number == 1)Console.WriteLine ("Понедельник");
// if (number == 2)Console.WriteLine ("Вторник");
// if (number == 3)Console.WriteLine ("Среда");
// if (number == 4)Console.WriteLine ("Четверг");
// if (number == 5)Console.WriteLine ("Пятница");
// if (number == 6)Console.WriteLine ("Суббота");
// if (number == 7)Console.WriteLine ("Воскресенье");
// else if (number<1 || number>7)Console.WriteLine ("Введен неверный день недели");



//Задание 3. На вход принимает одно число (n), а на выходе показывает все целые числа в промежутке от -n до n.
// 4 < -4, -3, -2, -1, 0, 1, 2, 3, 4

// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// int number2 = -number;
// while (number2 <= number)
// {
//   Console.WriteLine($"{number2}");
//   number2++;
// }



//Задание 4. На вход трехзначное число и на выходе показывает последнюю циру этого числа
// 456 -> 6
// 782 -> 2

// % - деление с остатком 456%10=45.6 - остаток 6
// / - целочисленное деление 456/10=45.6 - целое число 45

// Console.WriteLine("Введите трехзначное число: ");
// int number = int.Parse(Console.ReadLine()!);
// int n = number%10;
// Console.WriteLine($"Последняя цифра числа {number} равна {n}");
