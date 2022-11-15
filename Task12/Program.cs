// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

// if(number1%number2==0) Console.WriteLine("Кратно");
// if(number1%number2!=0)
// {
//     int result = number1 % number2;
//     Console.WriteLine($"Не кратно, остаток {result}");
// }

int RemDivision(int num1, int num2)
{
    return num1%num2;
}

int result = RemDivision(number1,number2);
if (result==0) 
{
    Console.WriteLine("Кратно");
}
else 
{
    Console.WriteLine($"Не кратно, остаток {result}");
}