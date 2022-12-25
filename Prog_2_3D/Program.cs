/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

/* int x1 = 0, y1 = 0, z1 = 0, x2 = 0, y2 = 0, z2 = 0; // A (x1, y1, z1), B (x2, y2, z2)!!!

InitCoordinates(ref x1, ref y1, ref z1, ref x2, ref y2, ref z2);
PrintCoords(x1, y1, z1, x2, y2, z2);

static void InitCoordinates(ref int x1, ref int y1, ref int z1, ref int x2, ref int y2, ref int z2)
{
    try
    {
        Console.Write("Введите координату Х точки А: ");
        x1 = int.Parse(Console.ReadLine()!);
        Console.Write("Введите координату Y точки А: ");
        y1 = int.Parse(Console.ReadLine()!);
        Console.Write("Введите координату Z точки A: ");
        z1 = int.Parse(Console.ReadLine()!);
        Console.Write("Введите координату X точки B: ");
        x2 = int.Parse(Console.ReadLine()!);
        Console.Write("Введите координату Y точки B: ");
        y2 = int.Parse(Console.ReadLine()!);
        Console.Write("Введите координату Z точки B: ");
        z2 = int.Parse(Console.ReadLine()!);
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода попробуйте снова {exc.Message}");
        return;
    }
}

static void PrintCoords(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    double resultRound = Math.Round(result, 2);
    Console.Write($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}) --> {resultRound}");
} */
int x1, y1, x2, y2, z1, z2; // В вышеуказанном методе выходит ошибка при вводе текста... и при этом нельзя повторно вводить данные (только после рестарта)...

while (true)
{
    Console.Write("Введите координату Х точки А: ");
    try
    {
        x1 = Convert.ToInt32(Console.ReadLine()!);
        break;
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода! {exc.Message} Попробуйте повторно ввести целое число: ");
    }
}
while (true)
{
    Console.Write("Введите координату Y точки А: ");
    try
    {
        y1 = Convert.ToInt32(Console.ReadLine()!);
        break;
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода! {exc.Message} Попробуйте повторно ввести целое число: ");
    }
}
while (true)
{
    Console.Write("Введите координату Z точки А: ");
    try
    {
        z1 = Convert.ToInt32(Console.ReadLine()!);
        break;
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода! {exc.Message} Попробуйте повторно ввести целое число: ");
    }
}
while (true)
{
    Console.Write("Введите координату Х точки B: ");
    try
    {
        x2 = Convert.ToInt32(Console.ReadLine()!);
        break;
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода! {exc.Message} Попробуйте повторно ввести целое число: ");
    }
}
while (true)
{
    Console.Write("Введите координату Y точки B: ");
    try
    {
        y2 = Convert.ToInt32(Console.ReadLine()!);
        break;
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода! {exc.Message} Попробуйте повторно ввести целое число: ");
    }
}
while (true)
{
    Console.Write("Введите координату Z точки B: ");
    try
    {
        z2 = Convert.ToInt32(Console.ReadLine()!);
        break;
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода! {exc.Message} Попробуйте повторно ввести целое число: ");
    }
}

double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
double resultRound = Math.Round(result, 2);
Console.Write($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}) --> {resultRound}");