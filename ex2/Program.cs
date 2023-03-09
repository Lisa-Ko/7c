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
void Sort(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {

        for (int j = 0; j < table.GetLength(1); j++)
        {
             for (int k = 0; k < table.GetLength(1) - 1; k++)
            {
                if (table[i, k] < table[i, k + 1])
                {
                    int temp = table[i, k + 1];
                    table[i, k + 1] = table[i, k];
                    table[i, k] = temp;
                }
            }
        }

    }

}
int[,] numbers = CreateInttable();
Filltable(numbers);
Console.WriteLine("массив: ");
Printtable(numbers);
Sort(numbers);
Console.WriteLine("измененный массив: ");
Printtable(numbers);
