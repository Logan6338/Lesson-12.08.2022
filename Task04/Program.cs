string SqrtFind (int N)
{
    string result = "";
    for (int i = 1; i <= N; i++)
    {
        result += $"{Math.Pow(i, 2)} ";
    }
    return result;
}

Console.Write("Ввкдите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SqrtFind(N));