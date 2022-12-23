/* Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

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
int number_next = Math.Abs(number);

if (number_next < 9999 && number_next >= 100000)
{
    Console.WriteLine("Вы ввели не 5-ти значное число!");
    return;
}

int number1 = number_next / 10000;          //найдем 1 число
int number2 = number_next / 1000 % 10;      //найдем 2 число
int number4 = number_next % 100 / 10;       //найдем 4 число
int number5 = number_next % 10;             //найдем 5 число

if (number1 == number5 && number2 == number4)
{
    Console.WriteLine($"{number} --> YES");
}
else if (number1 != number5 && number2 != number4)
{
    Console.WriteLine($"{number} --> NO");
}

