// Задача:

// Написать программу, которая из имеющегося массива строк формирует 
// массив из строк, длина которых меньше либо равна 3 символа.


// методы IncorrectValue и UserInput 
// проверяют корректность ввода данных
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


// CreateArray создает массив путем ручного ввода данных пользователем
// с ограничением размера массива на основе ранее заданного параметра arraysize
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


// PrintEnteredArray выводит на печать созданный в ручную массив
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


// LimitedArraySize определяет размер нового массива, куда будут выводится данные,
// подпадающие под ограничение количества символов.
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


// CreateLimitedArray - создаем сам массив, куда будут выводится
// данные, подпадающие под ограничение количества символов.
void CreateLimitedArray(string[] array, string[] arraylimited, int maxlimitsymbols)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxlimitsymbols)
        {
            arraylimited[j] = array[i];
            j++;
        }
    }
}


// PrintArray выводит на печать массив из строк, длина которых
// меньше либо равна установленному ограничению символов.
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
CreateLimitedArray(array, arraylimited, maxlimitsymbols);
Console.Write(" -> ");
PrintArray(arraylimited, limitedarraysize);