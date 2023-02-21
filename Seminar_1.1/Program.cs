// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)  [1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6]

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void ReversArray(int[] inArray) //первый способ
{
    for (int i = 0; i < inArray.Length / 2; i++) // делим на два т.к. иначе функция сработает не правильно
    {
        int temp = inArray[i]; // в свободную переменную положили 1 элемент
        inArray[i] = inArray[inArray.Length - 1 - i]; // -1 - i т.к. мы движемся справа налево приближаясь к 0
        inArray[inArray.Length - 1 - i] = temp; // переливаем значение из темп в свободную
    }
}

int[] ReversArray2(int[] inArray) //второй способ
{
    int length = inArray.Length;
    int[] result = new int[length];

    for (int i = 0; i < length; i++)
    {
        result[i] = inArray[length - 1 - i];
    }
    return result;
}

int[] array = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ", array));

ReversArray(array);
Console.WriteLine(String.Join(" ", array));

int[] reversed = ReversArray2(array);
Console.WriteLine(String.Join(" ", reversed));
Console.WriteLine(String.Join(" ", array));