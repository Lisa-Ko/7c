int[,] CreateInttable()
{
    Console.Write("Введите длину  ");
    int m = int.Parse(Console.ReadLine()!);

    Console.Write("Введите ширину  ");
    int n = int.Parse(Console.ReadLine()!);

    Console.WriteLine();
    int[,] table = new int[m,n];
    return  table;
}
void Filltable(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i,j] =new Random().Next(0, 10);
        }
    }
}
void Printtable(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(" " + table[i,j]);
        }
     Console.WriteLine();
     }
}
int FindMinString(int[,] table, int i)
{   
  int sumLine = table[i,0];
  for (int j = 1; j < table.GetLength(1); j++)
  {
    sumLine += table[i,j];
  }
  return sumLine;
}
void MinLine(int[,] table)
{
    int minSumLine = 0;
    int sumLine = FindMinString(table, 0);

    for (int i = 1; i < table.GetLength(0); i++)
    {
    int tempSumLine = FindMinString(table, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
         minSumLine = i;
    }
    }
    Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");
}

int[,] numbers = CreateInttable();
Filltable(numbers);
Console.WriteLine("массив: ");
Printtable(numbers);
MinLine(numbers);


