// Задача 15: Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

bool Weekend(int week)
{
    return week == 6 || week == 7;
}

bool result = Weekend(day);
Console.Write($"{day} -> ");
Console.WriteLine(result ? "Да" : "Нет");

























// int SecondDigit(int num)
// {
//     int num1 = num / 10;
//     int num2 = num1 % 10;
//     return num2;
// }


// bool IsTrue = true;
// while (IsTrue)
// {
//     Console.Write("Введите трехзначное число: ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     if (number < 1000 && number > 100)
//     {
//         int result = SecondDigit(number);
//         Console.WriteLine($"Вторая цифра числа {result}");
//         IsTrue = false;
//     }

// }
