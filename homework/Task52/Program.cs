// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Задайте количество строк массива:");
int N = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Задайте количество столбцов массива:");
int M = Convert.ToInt32(Console.ReadLine())!;

int[,] matrix = new int[N, M];
Random rand = new Random();
int[] summ = new int[M];
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        matrix[i, j] = rand.Next(0, 10);                
    }
}
Console.WriteLine("Матрица");
for (int i = 0; i < N; i++)
{
   for (int j = 0; j < M; j++)
   {
       Console.Write($"{matrix[i, j]} ");
       summ[i] += matrix[j, i];      
   } 
    Console.WriteLine();
}
Console.WriteLine();
foreach (double elem in summ)
{               
 Console.WriteLine($"Среднее арифметическое столбца: {elem/M}"); 
}
 