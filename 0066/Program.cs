// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

void PrintSumm(int M, int N, int summa)
{
  summa = summa + N;
  if (N <= M)
  {
    Console.Write($"Сумма элементов= {summa} ");
    return;
  }
  PrintSumm(M, N - 1, summa);

}


if (M > N) 
{
 int temp = M;
  M= N; 
  N = temp;
}

PrintSumm(M, N, 0);

