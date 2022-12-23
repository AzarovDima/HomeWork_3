/* Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
ПРИМЕР
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */
int number;
while (true)
{
    Console.Write("Введите целое число: ");

    try
    {
        number = Convert.ToInt32(Console.ReadLine()!);
        break;
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Вы ввели не число! {exc.Message}");
    }
}
Console.Write($"{number} ---> ");

int num_abs = Math.Abs(number);
int count = 0;
if (number == 0)
{
    Console.Write($"Отсутствуют числа от 1 до 0");
    return;
}
while (count <= num_abs)
{
    Console.Write($"{Math.Pow(count, 3)}, ");
    count++;
}
