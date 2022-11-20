// // Задайте двумерный массив размером m×n, заполненный случайными
// вещественными числами. Сделать отдельный метод который
// генерирует двумерный массив и отдельный метод который
// выводит его на экран.
// // m и n вводит пользователь в консоль
Console.WriteLine("Введите числа");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка!");
    return;
}
double[,] createArrayOfКandomRealNumbers = СreateArrayOfКandomRealNumbers(m, n);
PrintArray(createArrayOfКandomRealNumbers);
double[,] СreateArrayOfКandomRealNumbers(int m, int n)
{
    double[,] array = new double[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-100,100) + Math.Round(random.NextDouble(),2);
        }
    }
    return array;
}
void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
