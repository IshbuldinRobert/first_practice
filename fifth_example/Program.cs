Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Третья цифра числа {a}: {a % 10}");