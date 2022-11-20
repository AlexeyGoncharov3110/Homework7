// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
//  Поиск среднее арифметического в отдельном методе
Console.WriteLine("Введите размеры массива");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка!");
    return;
}
int[,] createArrayOfRandomRealNumbers = СreateArrayOfRandomRealNumbers(m, n);
PrintArray(createArrayOfRandomRealNumbers);
double [] arithmeticMeanInaColumn = ArithmeticMeanInaColumn(createArrayOfRandomRealNumbers); 
Console.WriteLine();
PrintArray2(arithmeticMeanInaColumn);
double [] ArithmeticMeanInaColumn( int [,] array)
{
    double[] result = new double[array.GetLength(1)];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        result [j] = result[j] + array[i,j];
    } 
}
for (int i = 0; i < result.Length; i++)
{
   result[i]=Math.Round(result[i]/array.GetLength(0),2);
}
    return result;
}

int[,] СreateArrayOfRandomRealNumbers(int m, int n)
{
    Random random = new Random();
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}
void PrintArray( int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void PrintArray2(double [] array )
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}