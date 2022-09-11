// Напишите программу, котрая принимает на вход число и выдаёт количество цифр в числе.

Console.Clear();
Console.WriteLine("Введите число А");
int A = int.Parse(Console.ReadLine());

Console.WriteLine();
/* string a = Convert.ToString(A);
Console.WriteLine(a.Length);
*/
int count = 0;
while (A>= 1);
{
    count++;
    A=A/10;
}
Console.WriteLine(count);
