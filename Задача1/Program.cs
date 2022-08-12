/*

*/
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());

int[] arraySum = new int[n];

for (int i = 1; i < n - 1; i++)
    arraySum[i - 1] = array[i - 1] + array[i] + array[i + 1];


arraySum[n - 2] = array[0] + array[n - 1] + array[n - 2];
arraySum[n - 1] = array[n - 1] + array[0] + array[1];
int MaxNumber = arraySum[0];

for (int i = 0; i < n; i++)
{
    if (MaxNumber < arraySum[i])
        MaxNumber = arraySum[i];
}

Console.WriteLine("[" + string.Join(", ", arraySum) + "]");
Console.WriteLine(MaxNumber);
