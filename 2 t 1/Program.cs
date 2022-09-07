// See https://aka.ms/new-console-template for more information
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координату x1 ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y1 ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z1 ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату x2 ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y2 ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z2 ");
int z2 = Convert.ToInt32(Console.ReadLine());

string Qadrat(int a1, int b1, int c1, int a2, int b2, int c2)
{
    double distance = Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2) + Math.Pow(c2 - c1, 2));
    return "Расстояние между двумя точками в пространстве равно " + distance;
}
string c = Qadrat(x1, y1, z1, x2, y2, z2);
Console.WriteLine(c);