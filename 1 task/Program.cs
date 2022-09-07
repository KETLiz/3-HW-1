// See https://aka.ms/new-console-template for more information
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
string n = Console.ReadLine();
string Method(string a)
{
    if (n[0] == n[4] && n[1] == n[3]) return "Введенное число является палиндромом!";
    else return "Введенное число не палиндром!";
}
string result = Method(n);
Console.WriteLine(result);