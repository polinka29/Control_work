/*Задача : Написать программу, которая из массива строк формирует массив из строк, длина которых 
меньше или равна 3м символам. Первоначальный массив можно ввести с помощью комбинации, либо нажать на начало выполнения алгоритма. Не рекомендуется использовать коллекции, лучше всего собирать уникальные массивы.
Примеры :
["привет", "2", "мир", ":-)"] -> ["2", ":-)"]
["Россия", "Дания", "Казань"] -> []*/

Console.WriteLine("Введите символы через пробел:  ");
string[] Array = Console.ReadLine().Split().ToArray();
Console.WriteLine();
int count = 0;
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i].Length <= 3) count++;
}
string[] MyArray = new string[count];
for (int i = 0; i < MyArray.Length; i++)
{
    for (int j = 0; j < Array.Length; j++)
    {
        if (Array[j].Length <= 3 && Array[j] != string.Empty)
        {
            MyArray[i] = Array[j];
            Array[j] = string.Empty;
            break;
        }
    }
    Console.WriteLine($"Массив < или = 3м символам содержат следующие элементы: {MyArray[i]} ");
}