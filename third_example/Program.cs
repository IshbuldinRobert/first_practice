// Программа, которая проверяет, является ли первое число квадратом второго
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите предполагаемый квадрат этого числа: ");
int sq_num = Convert.ToInt32(Console.ReadLine());

if (sq_num == num * num)
{
    Console.WriteLine($"Ваше предположение верно, {sq_num} - квадрат числа {num}. Вы молодец :)");
}
else
{
    Console.WriteLine($"Вы ошиблись :( квадрат чилса {num} на самом деле {num * num}. Подтяни свою математику, растяпа ;)");
}