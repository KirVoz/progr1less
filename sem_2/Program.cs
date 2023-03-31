// Напишите программу, которая выводит случайное число из отрезка 10-99 и показывает наибольшее цифру числа

// int number = new Random().Next(10,100);
// Console.WriteLine($"random number - {number}"); // Интерполяция 
// int digit1 = number / 10;
// int digit2 = number % 10;
// Console.WriteLine(digit1);
// Console.WriteLine(digit2);
// // if(digit1<digit2)
// // {
// //     Console.WriteLine(digit2);
// // }
// // else
// // {
// //     Console.WriteLine(digit1);
// // }
// int max = Math.Max(digit1, digit2); // max из двух переменных
// int min = Math.Min(digit1,digit2); // min из двух переменных
// Console.WriteLine($"Max nuber is - {max}");
// Console.WriteLine($"Max nuber is - {min}");


// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру
// этого числа.
// int number = new Random().Next(100, 1000);
// Console.WriteLine($"random number - {number}");
// int digit1 = number / 100;
// int digit2 = number % 10;
// Console.Write(digit1);
// Console.Write(digit2);


// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1,
// то программа выводит остаток от деления.
// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if((num1%num2) == 0)
// {
//     Console.WriteLine("YES");
// }
// else
// {
//     Console.WriteLine("ostatok: "+(num1%num2));
// }


// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23
// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// if ((num1 % 7) == 0 && (num1 % 23) == 0)
// {
//     Console.WriteLine("kratno");
// }
// else
// {
//     Console.WriteLine("ne kratno");
// }