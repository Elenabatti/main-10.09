// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3, 9, -8, 1, 0, 
Console.Clear();

Console.WriteLine("Введите размерность массива: ");
 int size = int.Parse(Console.ReadLine());

int [] array = GetArray(size, -9, 9);// объявили переменную и заполнили её числами. GetArray как генератор чисел.

  Console.WriteLine(String.Join(" ", array));//  так выводим элементы массива

   int sumPositive = 0;
   int sumNegative = 0;

   foreach(int element in array){
    sumPositive += element > 0 ? element : 0;
    sumNegative += element < 0 ? element : 0;
   }
   Console.WriteLine($"sum positive: {sumPositive} sun negative{sumNegative}");

   int [] GetArray (int size, int min, int max){
    int[ ] result = new int [size];

    for (int i =0; i < size; i++){
        result [i] = new Random().Next(min, max + 1);
    }
    return result;
   }
   /*
   Console.Clear();
   Console.Write("Массив: ");
   int [] rand = new int[12];
   int sumPositive = 0;
   int sumNegative = 0;
   for (int i =0; i < rand.Length; i++){
    rand[i] = new Random().Next(-9, 10);
    Console.Write(rand[i]+" ");
    if (rand[i] > 0)
    sumPositive += rand[i];
    if (rand[i] < 0)
    sumNegative += rand [i];
   }
   Console.WriteLine();
   Console.WriteLine($"Сумма положительных {sumPositive }");
   Console.WriteLine($"Сумма отрицательных {sumNegative }");
   */