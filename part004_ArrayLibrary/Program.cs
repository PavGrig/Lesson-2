﻿void FillArray(int[] collection) // Функция/метод, выполняющая заполнение массива случайными числами.
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) //фунция/метод, выполняющая печать массива.
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }   
    return position;

}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 44);
Console.WriteLine(pos);
