/*
ЗАДАЧА:
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

РЕШЕНИЕ:
*/

Console.Clear();

//Метод получения данных с клавиатура
string[] InputArray()
{
    Console.WriteLine("Сколько строк вы планируете ввести? Введите положительное целое число: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[size];
    for (int index = 0; index < size; index++)
    {
        Console.WriteLine($"Введите строку номер {index + 1}: ");
        array[index] = Console.ReadLine();
    }
    return array;
}

//Метод подсчета числа строк, длина которых менее заданному в задаче
int CountRows(string[] array, int length)
{
    int countrows = 0;
    for (int index = 0; index < array.Length; index++)
        if (array[index].Length <= length)
            countrows++;
    return countrows;
}

//Метод заполнения новой матрицы строками, чья длина удовлетворяет условию задачи
string[] CreateArray(string[] array, int length)
{
    int countrows = CountRows(array, length);
    string[] array2 = new string[countrows];
    int count = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index].Length <= length)
        {
            array2[count] = array[index];
            count++;
        }
    }
    return array2;
}

// Метод, печатающий массив в строку
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int index = 0; index < array.Length - 1; index++)
    {
        Console.Write('\u0022' + $"{array[index]}" + '\u0022' + ", ");
    }
    Console.Write('\u0022' + $"{array[array.Length - 1]}" + '\u0022' + "]");
}

string[] array = InputArray();
int length = 3;// это длина строк, которые удовлетворяют условию задачи
int countrows = CountRows(array, length);
if (countrows > 0)
{
    string[] array2 = CreateArray(array, 3);
    Console.WriteLine($"Вот строки, чья длина меньше или равна {length}");
    PrintArray(array2);
}
else
{
    Console.WriteLine($"Среди введенных строк отсутствуют строки, чья длина меньше или равна {length}: ");
    Console.WriteLine("[]");
}