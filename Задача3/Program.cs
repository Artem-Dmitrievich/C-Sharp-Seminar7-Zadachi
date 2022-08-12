/*
Задача 48: Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
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
        matrix[i, j] = i + j;
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
        Console.Write(matrix[i, j] + " \t");
    Console.WriteLine();
}
