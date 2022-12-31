void PrintArray(string[] mass)
{
    foreach (string el in mass)
        Console.Write($"{el} ");
    Console.WriteLine();
}

//Определяет колличество элеиентов, удовлетворяющих условию
//Нужна для определения размера нового массива
int LessThanThree(string[] input)
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

string[] M;
Console.WriteLine("Введите массив строк через пробел");
string stroka = Console.ReadLine();
M = stroka.Split(' ');

PrintArray(M);
int count = LessThanThree(M);
Console.WriteLine($"{count}");



