// Программа, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 309 -> 0
// 197 -> 9


Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 999)
{
    Console.WriteLine("Я зря написала ТРЕХЗНАЧНОЕ число? Число слишком длинное");
    
}
else if (number < 100)
{
    Console.WriteLine("Я зря написала ТРЕХЗНАЧНОЕ число? Число недостаточно длинное");
}
else
{
    int number2 = number / 10 % 10;
    Console.WriteLine("Вторая цифра " + number + " = " + number2);
}

