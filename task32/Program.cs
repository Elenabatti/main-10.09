﻿
// Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные и наоборот.
Console.Clear();

Console.WriteLine("Укажите длину массива: ");
int size = int.Parse(Console.ReadLine());
int [] rand = new int [size];
int [] rand2 = new int [size];
for (int i = 0; i <rand.Length; i++){
    rand[i] = new Random().Next(-99, 100);
    Console.WriteLine(rand[i]+" ");
}
for (int i = 0; i< rand.Length; i++){
    rand2[i] = rand[i]* -1;
    Console.Write(rand2[i]+" ");
}
Console.WriteLine();