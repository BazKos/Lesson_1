//Создать массив и заполнить его целыми числами
//от 1 до N (N - произвольное натуральное число).
//Вывести элементы на экран.

Console.WriteLine("Введите натуральное число N:");
int N = int.Parse(Console.ReadLine()!);
int [] arr = new int[N];
int i = 0;
//while (i < N)
while (i < arr.Length)
{
    arr [i] = i + 1;
    Console.Write($"{arr[i]} ");
    i = i + 1;
}
