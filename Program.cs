string[] M;
Console.WriteLine("Введите массив строк через пробел");
string stroka = Console.ReadLine();
M = stroka.Split(' ');

void PrintArray(string [] mass)
{
    foreach (string el in mass)
        Console.Write($"{el} ");
    Console.WriteLine();
}

PrintArray(M);


