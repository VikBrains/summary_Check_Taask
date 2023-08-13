/* Задача: Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
------------------------------------------
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/

Console.WriteLine("input array size: ");
int size  = int.Parse(Console.ReadLine()!);

string[] array1 = new string[size];

for (int i = 0; i < size; i++)
{
    Console.Write("input array line: ");
    string line = Console.ReadLine()!;
    array1[i] = line;  
}
Console.WriteLine();
Console.Write("Your array: [");
Console.Write(string.Join(", ", array1));
Console.Write("]");
