// Задайте массив. Напишите программу, котрая определяет присутствует ли данное число в массиве.

Console.Clear();

Console.WriteLine("Укажите длину массива: ");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Введите искомое число: ");
int num = int.Parse(Console.ReadLine());
int [] rand = new int[size];
bool A = false;

for (int i =0; i < rand.Length; i++){
    rand[i] = new Random().Next(0, 11);
    Console.Write(rand[i]+" ");
    if (rand [i] == num)
    A = true;
}
Console.WriteLine();
if (A == true)
Console.WriteLine("Да");
else
Console.WriteLine("Нет");
