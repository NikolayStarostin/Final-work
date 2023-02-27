// Задача:

// Написать программу, которая из имеющегося массива строк формирует 
// массив из строк, длина которых меньше либо равна 3 символа.


void IncorrectValue()
{
    Console.WriteLine("Введено некорректное значение");
    Environment.Exit(0);
}

int UserInput()
{
    if (!int.TryParse(Console.ReadLine(), out int temp)) IncorrectValue();
    return temp;
}

string[] CreateArray(int arraysize)
{
    string[] stringArray = new string[arraysize];
    for (int i = 0; i < arraysize; i++)
    {
        Console.Write("Введите данные для заполнения массива: ");
        stringArray[i] = Console.ReadLine();
    }
    return stringArray;
}

void PrintEnteredArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"\"{array[i]}\", ");
        else Console.Write($"\"{array[i]}\"");
    }
    Console.Write("]");
}

void LimitedArray(string[] array, string[] arraylimited, int maxlimitsymbols)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= maxlimitsymbols)
        {
        arraylimited[j] = array[i];
        j++;
        }
    }
}

int LimitedArraySize(string[] array, int maxlimitsymbols)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxlimitsymbols)
            count++;
    }
    return count;
}

void PrintArray(string[] array, int limitedarraysize)
{
    Console.Write("[");
    for (int i = 0; i < limitedarraysize; i++)
    {
        if (i < limitedarraysize - 1) Console.Write($"\"{array[i]}\", ");
        else Console.Write($"\"{array[i]}\"");
    }
    Console.Write("]");
}

Console.Write("Введите размер массива: ");
int arraysize = UserInput();
string[] array = CreateArray(arraysize);
Console.WriteLine("Введите ограничение длинны строк: ");
int maxlimitsymbols = UserInput();
PrintEnteredArray(array);
int limitedarraysize = LimitedArraySize(array, maxlimitsymbols);
string[] arraylimited = new string[limitedarraysize];
LimitedArray(array, arraylimited, maxlimitsymbols);
Console.Write(" -> ");
PrintArray(arraylimited, limitedarraysize);