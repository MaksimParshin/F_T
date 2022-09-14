/*Написать программу, которая из имеющегося массива строк формирует 
массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать 
на старте выполнения алгоритма. 
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

void SortArray(string[] array)
{
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i].Length > 0 && array[i].Length <= 3)
            System.Console.WriteLine(array[i]);
    }
}

string[] arr1 = {"hello", "2", "world", ":-)"};
string[] arr2 = {"1234", "1567", "-2", "computer science"};
string[] arr3 = {"Russia", "Denmark", "Kazan"};
SortArray(arr1);
Console.WriteLine();
SortArray(arr2);
Console.WriteLine();
SortArray(arr3);