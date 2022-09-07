// See https://aka.ms/new-console-template for more information
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());


string Palindrom(int x)
{
    int a1 = x/10000;
    int a2 = x%10;
    int b12 = x/1000;
    int b1 = b12%10;
    int b21 = x/10;
    int b2 = b21%10;

    if (a1 == a2 && b1 == b2) return "Число является палиндромом";
    else return "Число не является палиндромом";
}
string result = Palindrom(n);
Console.WriteLine(result);