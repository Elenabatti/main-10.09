//Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива, значения которых лежат в отрезке [ 10, 99].

Console.Clear();
Console.WriteLine("Укажите длину массива: ");
int size = int.Parse(Console.ReadLine());
int [] rand = new int[size];
int [] rand2 = new int [size];
for (int i = 0; i < rand.Length; i++){
    rand[i] = new Random().Next(-99, 100);
    Console.WriteLine(rand[i]+" ");
}
Console.WriteLine();


int x = 0;
int y = rand.Length;
while (x == y){
    rand2[x] = rand[x] * rand[y];
    x++;
    y++;
}
Console.WriteLine (String.Join(" ", rand2));
Console.WriteLine();