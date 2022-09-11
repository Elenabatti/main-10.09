// Напишите программу, котрая принимант на вход число N
// и выдаёт произведение чисел от 1 до N.

Console.Clear();
Console.WriteLine("Введите число N: ");
 int n = int.Parse(Console.ReadLine());
 int r = 1;
 for (int i =1; i<=n; i++)
 {
    r *= i;
 }
 Console.WriteLine(n > 0 ? r : 0);// тернарные операции
 /*
 if (n > 0)
 {
    r;
 }
 else
 {
    n;
 }
 */