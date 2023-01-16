// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

string[] initalStringArray = new string[] { "Hello", "2", "world", ":-)" };
// string[] initalStringArray = new string[] { "1234", "1567", "-2", "computer science" };
// string[] initalStringArray = new string[] { "Russia", "Denmark", "Kazan" };
Console.WriteLine("Введенный массив:");
ShowArray(initalStringArray);
int j = 0;
for (int i = 0; i < initalStringArray.Length; i++)
{
    if (initalStringArray[i].Length <= 3)
    { j++; }
}
string[] sortedArray = new string[j];
j = 0;
for (int i = 0; i < initalStringArray.Length; i++)
{
    if (initalStringArray[i].Length <= 3)
    { 
        sortedArray[j] = initalStringArray[i];
        j++; 
    }
}
Console.WriteLine("Новый массив с элементами длиной меньше или равными 3 символам:");
ShowArray(sortedArray);