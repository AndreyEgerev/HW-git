// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина
// которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться
// коллекциями, лучше обойтись исключительно массивами
// функция ввода числа и возврата в числовом формате

//функция вывода массива
void PrintArray(string[] arr)
{
    //Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    //Console.WriteLine("] ");
}

//функция создания массива из строки
string[] CreateArray (string valueText, char splitChar)
{
    Console.WriteLine(valueText);
    return Console.ReadLine().Split(splitChar, StringSplitOptions.RemoveEmptyEntries);
}

//функция отбора слов заданной длинны из массива
string[] SortArray (string[] valueArray, int lengthStr)
{
    char splitChar = ',';
    string sortText = "";
    for (int i = 0; i < valueArray.Length; i++)
    {
        if (valueArray[i].Length <= lengthStr) sortText = sortText + splitChar  + valueArray[i];
    }

    return sortText.Split(splitChar, StringSplitOptions.RemoveEmptyEntries);
}


// Приветствие и объявление переменных
Console.Clear();
Console.WriteLine("Программа отбора слов из массива");

char razdelitel = ',';
int dlinnaStr = 3;
string helloText = "Введите слова через '" + razdelitel + "'";
// Создание и отбор массива
string[] userArrayStr = CreateArray(helloText, razdelitel);
string[] userArrayStrSort = SortArray(userArrayStr, dlinnaStr);
// Вывод массивов в консоль
PrintArray(userArrayStr);
Console.Write(" -> ");
PrintArray(userArrayStrSort);

