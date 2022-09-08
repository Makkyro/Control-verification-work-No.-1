// Итоговая проверочная работа:
// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] stringArray = new string[] {"Mid", "45", "hello", "1234", "Russia", "-2", "world", "1567", "Denmark", "computer science", ":-)"};

int stringSize = 3; 

string[] stringArrayNew = StrnigArrayNew(stringSize, stringArray);

System.Console.Write($"[");
for (int i = 0; i < stringArrayNew.Length; i++)
{
    System.Console.Write($"{stringArrayNew[i]},  ");
}
System.Console.Write($"]");

string[] StrnigArrayNew(int stringSize, string[] stringArray)
{
    int count = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= stringSize) count++;
    }
    string[] stringArrayNew = new string[count];
    int j = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= stringSize)
        {
            stringArrayNew[j] = stringArray[i];
            j++;
        }
    }
    return stringArrayNew;
}