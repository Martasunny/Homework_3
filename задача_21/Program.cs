//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите число x1: ");
int x1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите число y1: ");
int y1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите число z1: ");
int z1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите число x2: ");
int x2 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите число y2: ");
int y2 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите число z2: ");
int z2 = Int32.Parse(Console.ReadLine());

static void Distance (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distancePoints = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
    Console.WriteLine(" рассстояние между двумя точками: " +  distancePoints);
}
Distance (x1, y1, z1, x2, y2, z2);
