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

string[] ResultMass(string[] input)
{
    string[] output = new string[LessThanThree(input)];

    for (int i = 0, j = 0; i < input.Length; i++)
    {
        if (input[i].Length <= 3)
        {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

string[] M;
Console.WriteLine("Введите массив строк через пробел");
string stroka = Console.ReadLine();
M = stroka.Split(' ');

LessThanThree(M);
int count = LessThanThree(M);
if (count == 0)
{
    Console.WriteLine("Строк с тремя и менее символами нет");
}
else
{
string[] Result = ResultMass(M);

Console.WriteLine($"[{string.Join(", ", M)}] -> [{string.Join(", ", Result)}]");
}

