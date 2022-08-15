int number = Convert.ToInt32(Console.ReadLine());
string result = FindNumber(number);
Console.WriteLine(result);

string FindNumber(int q)
{
    if (q == 1)
    {
        return "x > 0, y > 0";
    }
    if (q == 2)
    {
        return "x < 0, y > 0";
    }
     if (q == 3)
    {
        return "x < 0, y < 0";
    }
    if (q == 4)
    {
        return "x > 0, y < 0";
    }

    throw new Exception("Ввели не правильные данные,");
}
