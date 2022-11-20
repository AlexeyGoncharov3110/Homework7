// Задача 50. Напишите программу, которая на вход принимает
//  позиции элемента в двумерном массиве, и возвращает значение
//  этого элемента или же указание,
//  что такого элемента нет.
Console.WriteLine("Введите размеры массива");
bool isParsedK = int.TryParse(Console.ReadLine(), out int k);
bool isParsedL = int.TryParse(Console.ReadLine(), out int l);
if (!isParsedK || !isParsedL)
{
    Console.WriteLine("Ошибка!");
    return;
}
Console.WriteLine("Введите позиции элемента в массиве");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка!");
    return;
}
int[,] createArrayOfRandomRealNumbers = СreateArrayOfRandomRealNumbers(k, l);
(string,int) elementValueByIndex = ElementValueByIndex(createArrayOfRandomRealNumbers, m, n);
(string,int) ElementValueByIndex(int[,] array, int m, int n)
{
    if (m >= array.GetLength(0) || n >= array.GetLength(1))
    {
        return ("Элемента с таким индексом в массиве нет", 0);
    }
    else
    {
        return ("Элемент с данным индексом имеет значение",array[m, n]);
    }
}
Console.WriteLine(elementValueByIndex);
int[,] СreateArrayOfRandomRealNumbers(int k, int l)
{
    int[,] array = new int[k, l];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}
PrintArray(createArrayOfRandomRealNumbers);
void PrintArray(int[,] arr)
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
