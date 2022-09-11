// Напишите программу, котрая выводит массив из 8 элементов, 
// заполненный 0 и 1 в случайном порядке.
Console.Clear();

int [] array = new int[8];// объявление массива
for (int i = 0; i < array.Length; i++)
{
    array [i] = new Random().Next(0, 2);
    Console.Write(array[i] + " ");
  //  Console.Write($"{array[i]} ");// Больше подходит когда какое-то вычисление и текст ввести нужно
}