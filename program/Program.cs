// Задача:

// Написать программу, которая из имеющегося массива строк формирует 
// массив из строк, длина которых меньше либо равна 3 символа.


/** Выводит на печать сообщение о некорректности введенных данных и завершает работу.
*/
void IncorrectValue()
{
    Console.WriteLine("Введено некорректное значение");
    Environment.Exit(0);
}

/** Проверяет введенные данные соответствию числовых значений "int", в случае несоответствия отсылает к методу и IncorrectValue
* return - возвращает полученное числовое значение.
*/
int UserInput()
{
    if (!int.TryParse(Console.ReadLine(), out int temp)) IncorrectValue();
    return temp;
}

/** Cоздает массив и заполняет его путем ручного ввода данных пользователем.
* int arraysize - принимает на вход значение размера массива, задаваемого пользователем.
* return - возвращает созданный и заполненный массив.
*/
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


/** Выводит на печать созданный в ручную массив.
* string[] array - принимает на вход ранее созданный пользователем массив.
*/
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


/** Определяет размер нового массива, куда будут выводится данные, подпадающие под ограничение количества символов, путём перебора всех элементов массива, подподающих под установленне ограничения, с увеличением каждый раз счетчика.
* string[] array - принимает на вход созданный пользователем массив.
* int maxlimitsymbols - принимает на вход заданное пользователем значение строк, длина которых меньше либо равна установленному ограничению символов. 
* return - возвращает счетчик, который показывает сколько элементов в массиве соотвествуют заданным ограничениям.
*/ 
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


/** Cоздает массив, куда будут выводится данные, подпадающие под ограничение количества символов.
* string[] array - принимает на вход ранее созданный пользователем массив. 
* string[] arraylimited - принимает на вход новый массив, размер которого ранее определен в методе "LimitedArraySize" и куда будут записываться данные из введенного пользователем массива, длина которых меньше либо равна установленному ограничению символов.
* int maxlimitsymbols - принимает на вход заданное пользователем значение строк, длина которых меньше либо равна установленному ограничению символов. 
*/
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


/** Выводит на печать массив из строк, длина которых меньше либо равна установленному ограничению символов.
* string[] array - принимает на вход массив с данными, подпадающими под установленное ограничение символов.
* int limitedarraysize - принимает на вход размер  массива с данными, подпадающими под установленное ограничение символов.
*/
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