string SqrtFind (int N)
{
    string result = "";
    for (int i = 1; i <= N; i++)
    {
        result += $"{Math.Pow(i, 3)} ";
    }
    return result;
}

Console.Write("Ввкдите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SqrtFind(N));

//int n = Convert.ToInt32(Console.ReadLine());

//int[] TableSquares(int s)
//{
  //  int[] array = new int[s];

    //for (int i = 1; i <= n; i++)
    //{
      //  array[i - 1] = i * i;
    //}
    //return array;
//}
//int[] result = TableSquares(n);
//for (int i = 0; i < result.Length; i++)
//{
  //  Console.WriteLine(result[i]);
//}

