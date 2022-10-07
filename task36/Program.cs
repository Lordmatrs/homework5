// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Решение с интернета (надо разбираться)

int FindRandomInt(int min, int max)
{
    return new Random().Next(min, max);
}
int[] Create(int size)
{
    return new int[size];
}
void Fill(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] += new Random().Next(-99, 99);
    }
}
int SearchSum(int[] array)
{
    int size = array.Length;
    int sum = 0;
    for (int i = 1 ; i < size; i += 2)
    {
        sum += array[i];
    }
    return sum;
}
Console.Clear();
int size = FindRandomInt(3,12);
int[] collection = Create(size);
Fill(collection);
Console.WriteLine($"Задан массив из случайных псевдочисел: " + "{" + (String.Join(' ', collection)) + "}");
int sum = SearchSum(collection);
Console.WriteLine($"Сумма всех чисел, стоящих на нечетных позициях равна: {sum}");

