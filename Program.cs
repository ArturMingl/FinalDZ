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

string[] Input;
Console.WriteLine("Введите массив строк через пробел");
string stroka = Console.ReadLine();
Input = stroka.Split(' ');

LessThanThree(Input);
int count = LessThanThree(Input);
if (count == 0)
{
    Console.WriteLine("Строк с тремя и менее символами нет");
}
else
{
string[] Result = ResultMass(Input);

Console.WriteLine($"[{string.Join(", ", Input)}] -> [{string.Join(", ", Result)}]");
}

