/*
Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
*/
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        if (i % 2 == 1 && j % 2 == 1)
            matrix[i, j] = matrix[i, j] * matrix[i, j];
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
        Console.Write(matrix[i, j] + " \t");
    Console.WriteLine();
}
