//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

void PrintArray(string[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write("{0}", arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write("   ");
        }
    }
    Console.WriteLine("]");
}

void FillArray(string[] arrayToFill, int diviation)
{
    int ElementArrayToFill = 0;
    for (int i = 0; i < arrayToFill.Length; i++)
    {
        ElementArrayToFill = new Random().Next(-diviation, diviation + 1);
        arrayToFill[i] = Convert.ToString(ElementArrayToFill);
    }
}

void CopyArray(string[] arrayToCopy, string[] arrayToFill)
{
    int len = 3;
    int pos = 0;
    for (int i = 0; i < arrayToCopy.Length; i++)
    {
    //arrayToFill[i] = arrayToCopy[i];
    if (arrayToCopy[i].Length <= len)
    {
        arrayToFill[pos] = arrayToCopy[i];
        pos++;
    }
    }
}

int arraySize = 0;
arraySize = new Random().Next(5, 20);
string[] firstArray = new string[arraySize];
string[] secondArray = new string[arraySize];
//string[] secondArray = new string[size];
FillArray(firstArray, 1500);
CopyArray(firstArray, secondArray);
Console.Clear();

Console.WriteLine("Исходный массив:");
PrintArray(firstArray);
Console.WriteLine();
Console.WriteLine("Массив элементов с длиной меньше 3:");
PrintArray(secondArray);
Console.ResetColor();