// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

int SizeOfShortArray(string[] array)
{
    int shortElements = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            shortElements = shortElements + 1;
    }
    return shortElements;
}

string[] ShortArray(string[] array, int size)
{
    int a = 0;
    string[] shortArray = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            shortArray[a] = array[i];
            a = a + 1;
        }
    }
    return shortArray;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < (array.Length - 1))
            Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine($"]");
}

Console.WriteLine("Введите элементы массива через запятую");
string[] str = Console.ReadLine().Split(',');

Console.WriteLine("Начальный массив");
PrintArray(str);

int num = SizeOfShortArray(str);
string[] shortStr = ShortArray(str, num);

Console.WriteLine("Итоговый массив");
PrintArray(shortStr);