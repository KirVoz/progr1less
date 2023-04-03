// int x = Convert.ToInt32(Console.ReadLine());
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0)
// {
//     Console.WriteLine("1");
// }
// if (x < 0 && y > 0)
// {
//     Console.WriteLine("2");
// }
// if (x > 0 && y < 0)
// {
//     Console.WriteLine("4");
// }
// if (x < 0 && y < 0)
// {
//     Console.WriteLine("3");
// }


// Напишите программу, 
// которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
// int num = Convert.ToInt32(Console.ReadLine());

// if(num == 1)
// {
//     Console.WriteLine("x>0 y>0");
// }
// if(num == 2)
// {
//     Console.WriteLine("x>0 y<0");
// }
// if(num == 3)
// {
//     Console.WriteLine("x>0 y<0");
// }
// if(num == 4)
// {
//     Console.WriteLine("x<0 y<0");
// }
// else
// {
//     Console.WriteLine("такой четверти нет");
// }


// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 
// 2D пространстве.

// int x1 = Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());
// int x2 = Convert.ToInt32(Console.ReadLine());
// int y2 = Convert.ToInt32(Console.ReadLine());
// double d = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2)); // pow = взятие в степень (число после запятой показывает какая степень). sqwrt = квадратный корень
// // Console.WriteLine(Math.Round(d)); // round = округление
// Console.WriteLine(d);


// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N ( я написал сразу для дз кубы)

// Console.WriteLine("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());

// for(int i = 1; i <= N; i++)
// {
//     Console.WriteLine($" Куб числа {i} = {i*i*i}");
// }