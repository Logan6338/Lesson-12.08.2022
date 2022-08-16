System.Console.WriteLine("Ведите кординаты первой точки ");
double x1 = Convert.ToInt32(Console.ReadLine());
double y1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Ведите кординаты второй точки ");
double x2 = Convert.ToInt32(Console.ReadLine());
double y2 = Convert.ToInt32(Console.ReadLine());

double lengthGet(double a1, double b1, double a2, double b2)
{
    return Math.Sqrt(Math.Pow((a1 - a2), 2) + Math.Pow((b1 - b2), 2));
}

System.Console.Write("Длина отрезка  = ");
System.Console.Write(lengthGet(x1, y1, x2, y2));