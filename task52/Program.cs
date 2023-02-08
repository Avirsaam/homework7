/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


int[,] InitMatrix(int rows, int columns, int rndMax, int rndMin)
{
    int[,] matrix = new int[rows, columns];
    
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = rnd.Next(rndMin, rndMax);
        }                
    }

    return matrix;
}


void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}".PadLeft(7, ' '));
            //".PadLeft(8, ' '));
        }
        Console.WriteLine();
    }
}

double getColumnAverage(int[,] matrix, int column)
{
    double sum = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)    
    {
        sum += matrix[i, column];
    }

    return sum/matrix.GetLength(0);
}


const int columns = 1, rows = 0;
int[] newMatrixDimensions = {7, 6};

int[,] matrix = InitMatrix (rows : newMatrixDimensions[rows],
                            columns: newMatrixDimensions[columns],
                            rndMin: 0,
                            rndMax: 10);

PrintMatrix (matrix);


Console.WriteLine("Среднее арифметическое каждого столбца: ");

for (int i = 0; i < matrix.GetLength(columns); i++)
{
    Console.Write ("{0, 7:F1}", getColumnAverage(matrix, i));
}
Console.WriteLine();


