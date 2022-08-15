

int x = Convert.ToInt32(Console.ReadLine());

int y = Convert.ToInt32(Console.ReadLine());

int result = FindNumberQuater(x,y);

Console.WriteLine(result);

int FindNumberQuater(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }

     if (x < 0 && y > 0)
    {
        return 2;
    }

     if (x < 0 && y < 0)
    {
        return 3;
    }

     if (x > 0 && y < 0)
    {
        return 4;
    }

    throw new Exception("Ввели не правильные данные,");
}