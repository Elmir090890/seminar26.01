// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int[] GetArray(int size, int MinValue, int MaxValue)

{
int[] Result = new int[size];

for (int i = 0; i < size; i++)
{
Result[i] = new Random().Next(MinValue, MaxValue + 1);
}
return Result;
}

int EvenNumberArray(int[]array)
{
    int result = 0;
    for( int i = 0; i<array.Length; i++)
    {
        if(array[i] % 2 ==0) result++;
    }
    return result;
}

int[] array = GetArray(5,100,1000);
Console.Write(string.Join(", ", array));

int result=EvenNumberArray(array);
Console.Write($" -> {result}");