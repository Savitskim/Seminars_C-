// Задача 2. Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.


Console.WriteLine("Введите два числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2) Console.WriteLine($"Большее число {number1}, Меньшее число {number2}");
else if (number1 < number2) Console.WriteLine($"Большее число {number2}, Меньшее число {number1}");
else Console.WriteLine("Эти числа равны");

