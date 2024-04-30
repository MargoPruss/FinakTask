// //Задача: Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на 
// старте выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// //[“Russia”, “Denmark”, “Kazan”] → []//

void ArrayToArrayLess4Symbols(string[] str1, string[] str2)
{
    int count = 0;
    for (int i = 0; i < str1.Length; i++)
    {
    if(str1[i].Length <= 3)
        {
        str2[count] = str1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

﻿string[] str1 = new string[] {"Hello", "2", "world", ":-)"};
string[] str2 = new string[str1.Length];
ArrayToArrayLess4Symbols(str1, str2);
PrintArray(str2);