/*
Виды алгоритмов:

1. Константные (нет зависимости)
int n = 0;
if(n >= 0)
    n++;
else
    n *= 2;

2. Логарифмические
(log2(n)) = 7 ходов (игра в угадай число от 1 до 100)

3. Линейные (y = kx + b)
int n = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 1; i <= n; n++)
    result = result * i; переменная result зависит от i
Console.WriteLine(result);

4. Линейно-логарифмические (быстрая сортировка, сортировка слиянием)

5. Квадратичный (из-за цикла)
int count = 0;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
        count++;
}
Console.WriteLine(count);

6. Кубический
тоже самое, что и квадратный, но еще добавляется один цикл


НОД (Алгоритм Евклида) наибольший общий делитель

НОД (140, 175) = 35
int n = 140;
int m = 175;

while (n != m)
{
    if (n > m)
        n = n - m;
    else
        m = m - n;
    
    Console.WriteLine(n);
    Console.WriteLine(m);
    Console.WriteLine();
}

НОК наименьшее общее кратное 
НОК (a,b) = (a*b)/НОД (a,b)

int n = 140;
int m = 175;
int count = n * m;
while (n != m)
{
    if (n > m)
        n = n - m;
    else
        m = m - n;
}

Console.WriteLine(count / (n + m));

*/
int n = 140;
int m = 175;
int count = n * m;
while (n != m)
{
    if (n > m)
        n = n - m;
    else
        m = m - n;
}

Console.WriteLine(count / (n + m));