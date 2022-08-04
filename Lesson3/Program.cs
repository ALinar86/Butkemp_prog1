/*int[] array = new int[5];
for (int i = 0; i < 5; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("[" + string.Join(", ", array ) + "]"); // функция Join соединяет элементы через разделитель
Console.WriteLine(array[3]);
// [2, 3, 4, 5, 6]
O[1]*/


/*int n = 5;
 int[] array = new int[n];
for (int i = 0; i < n; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("[" + string.Join(", ", array ) + "]"); // функция Join соединяет элементы через разделитель
int summa = 0;
for (int i = 0; i < n; i++)
    summa += array[i];
    Console.WriteLine(summa);*/
// O[n]

// [1, 2, 3, 4, 5] - O(n* log n) log с основанием 2 (это время быстрой сортировка)

// сумма элментов можно записать одной формулой ((5 + 1) / 2) * 5 (всего одна операция О(1))
// или цикл из пяти действий



/*int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n; j++)
    {
        Console.Write(i * j + " ");
        Console.Write("\t"); // табуляция
    }
    Console.WriteLine();
}*/
// O(n^2)    

// Чтобы уменьшить время алгоритма:

int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        {
            matrix[i, j] = (i + 1) * (j + 1);
            matrix[j, i] = (i + 1) * (j + 1);
        }
    }
    Console.WriteLine();
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        {
            Console.Write(matrix[i, j]);
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}
// O((n^2) / 2 ) 