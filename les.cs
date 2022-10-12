// Задача 47. Задайте двумерный массив размером m×n, заполненный 
//случайными вещественными числами.

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] table = new double[m, n];
for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            table[i,j] = Math.Round((new Random().Next(-9, 9) + new Random().NextDouble()), 1);
            Console.Write($"{table[i,j]}  ");

        }
        Console.WriteLine();
    }





//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном 
//массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


/*Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] table = new int[m, n];
for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            table[i,j] = new Random().Next(0, 100);
            Console.Write($"{table[i,j]} ");
        }
        Console.WriteLine();
    }
Console.Write("Введите номер строки числа: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца числа: ");
int t = Convert.ToInt32(Console.ReadLine());
if(k <= m) 
{
    if(t <= n)
    {
    Console.WriteLine(table[k - 1,t - 1]);
    }
}
else
    Console.WriteLine("Такого числа нет");

*/


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
//элементов в каждом столбце.


/*Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] table = new int[m, n];
for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            table[i,j] = new Random().Next(0, 10);
            Console.Write($"{table[i,j]} ");
        }
        Console.WriteLine();
    }
Console.WriteLine();   

for(int t = 0; t < n; t++)
{
    double sum = 0;
    int k = 0;
    while(k < m)
    {
        sum = sum + table[k,t];
        k++;
    }
    Console.WriteLine($"Среднее арифметическое в {t} столбце: " + Math.Round((sum / k), 2));
}
*/
