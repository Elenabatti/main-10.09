//Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний и тд.
//Результпт запишите в новом массиве

Console.Clear();

int [] array = new int[5];

for (int i = 0; i < 5; i++) {
array[i] = new Random().Next(0, 10);
}

Console.WriteLine(String.Join(" ", array));

int z = array.Length - 1;
for (int i = 0; i < z; i++)
{
int pr = array[i] * array[z];
z--;
Console.Write(pr + " ");
}

if (array.Length % 2 != 0) {Console.Write (array[array.Length/2]); }