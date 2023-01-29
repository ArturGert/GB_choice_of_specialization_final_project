/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.*/

string[] InitArray(string message)
{
    Console.WriteLine(message);
    string[] sourceArray = (Console.ReadLine() ?? "").Split(' ').ToArray();
    return sourceArray;
}

int GetLenghtArray(string[] array)
{
    int newArraylenght = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            newArraylenght++;
    }
    return newArraylenght;
}

string[] GetNewArray(string[] array)
{
    int newArraylenght = GetLenghtArray(array);
    int index = 0;
    string[] newArray = new string[newArraylenght];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            newArray[index++] = array[i];
    }
    return newArray;
}

void PrintArray(string[] anyArray)
{
    Console.Write("[");

    for (int i = 0; i < anyArray.Length; i++)
    {
        Console.Write(anyArray[i] + ((i != anyArray.Length-1) ? ", " : ""));
    }
    Console.Write("]");
}

Console.Clear();
string[] sourceArray = InitArray("Введите значения исходного массива строк через пробел: ");
Console.Clear();
Console.WriteLine("Исходный массив: ");
PrintArray(sourceArray);
Console.WriteLine();
if (GetLenghtArray(sourceArray) > 0)
{
    string[] newArray = GetNewArray(sourceArray);
    Console.WriteLine("Сформированный массив:");
    PrintArray(newArray);
}
else Console.WriteLine("В заданном массиве отсутствуют строки, длина которых меньше 3!");

