﻿//Дано N гирь с разным весом в случайном порядке.
//Определить вес самой тяжелой гири.

int [] arr = {16, 13, 8, 32, 4};
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