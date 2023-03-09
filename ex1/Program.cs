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
void PrintArray(int[] array)
{
    for    (int i=0;   i<array.GetLength(0); i++)
    {
        Console.Write(array[i]+ "|");
    }
}
 void Average(int[,] table)
    {            
        for (int j = 0; j < table.GetLength(1); j++)
        {
            double sum = 0;
 
            for (int i = 0; i < table.GetLength(0); i++)
            {
                sum += table[i, j];
            }
            System.Console.WriteLine($"Сумма элементов {j+1}-го столбца = {sum / table.GetLength(1)}");
        }
    }
int[,] numbers = CreateInttable();
Filltable(numbers);
Console.WriteLine("массив: ");
Printtable(numbers);
Average(numbers);
