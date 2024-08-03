// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int CountStringOfThreeOrFewerChar(string[] input)
{
    int count = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] CreateStringArray(string str)
{
    char[] DelimiterChars = { ' ', ',', '.', '!', '?', '\t' };
    string[] words = str.Split(DelimiterChars);

    string[] newArray = new string[CountStringOfThreeOrFewerChar(words)];
    int j = 0;
    for (int i = 0; i < words.Length; i++)
    {
        if (words[i].Length <= 3)
        {
            newArray[j] = words[i];
            j++;
        }
    }
    return newArray;
}

void PrintArrayString(string[] str)
{
    foreach (var item in str)
    {
        Console.Write(item + ' ');
    }
    Console.WriteLine();
}

Console.WriteLine("Enter a phrase:");
string phrase = Console.ReadLine();
string[] words = CreateStringArray(phrase);
PrintArrayString(words);
