// Программа принимает на вход трехзначное число и на выходи показывает вторую цифру этого числа. 
// Console.Write("insert three digits number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = num1 % 100;
// int num3 = num2 / 10;
// Console.WriteLine(num3);

// Console.WriteLine("Введите любое число.\nВыхода из программы команда Exit.");
//     while(true)
//     {
//         string input = Console.ReadLine();
//         if(!input.Equals("exit"))
//             Console.WriteLine("{0}->{1}",input, input[2]);  // {} <- это плейсхолдеры для вывода переменных что идут после них
//         else
//             break;
//     }


// Console.WriteLine("Введите любое число: ");
// string input = Convert.ToString(Console.ReadLine());
// if (input.Lenght > 2)
// {
//     Console.WriteLine("{0}->{1}", input, input[2]);
// }
// else
// {
//     Console.WriteLine("less then three digits");
// }


// Console.Write("Введи число: ");
// int anyNumber = Convert.ToInt32(Console.ReadLine());
// string anyNumberText = Convert.ToString(anyNumber);
// if (anyNumberText.Length > 2)
// {
//     Console.WriteLine("третья цифра -> " + anyNumberText[2]);
// }
// else
// {
//     Console.WriteLine("-> третьей цифры нет");
// }


// Программа принимает цифру, обозначающую день недели
// и проверяет является ли этот день выходным.

Console.Write("введите номер дня недели");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void dow(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("this is weekends -> yes");
    }
    else if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("heeeeeel nooo");
    }
    else Console.WriteLine("this is not weekend");
}

dow(dayNumber);

