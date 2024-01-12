//Дано N гирь с разным весом в случайном порядке.
//Определить вес самой тяжелой гири.

int [] arr = {16, 13, 100, 32, 4};
int i = 0;
int max = 0;
while (i < arr.Length)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    i = i + 1;
}
Console.Write($"Самая тяжелая гиря имеет массу {max} кг");

for (int j = 0; j < arr.Length; j++)
{
    if (arr[j] > max)
    {
        max = arr[j];
    }
}
Console.Write($"Самая тяжелая гиря имеет массу {max} кг");

max = arr[0];
foreach (int e in arr)
{
    if (e > max)
    {
        max = e;
    }
}
Console.WriteLine(max);