/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента
в двумерном массиве, и возвращает значение этого элемента или же указание,
что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

пользователь вводит индексы 10, 10 - такого элемента нет.
пользователь вводите индексы 0, 2 - выводим элеменет 7
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


const int columns = 1, rows = 0;
int[] newMatrixDimensions = {6, 7};

Console.Clear();
int[] inputIndexes = new int[2];

while (true){
    Console.WriteLine("Введите cтолбец и строку элемента матрицы, через запятую, и нажмите ввод");

    var inputData =
             Console.ReadLine()
            .Replace(" ", "")         
            .Split(",")
            .ToArray()
            ;
    
    bool inputIsValid = true;

    if (inputData.Length != 2)
    {
        inputIsValid = false;
    }
    else
    {    
        for (int i = 0; i < inputIndexes.Length; i++)
        {
            if (!int.TryParse(inputData[i], out inputIndexes[i])){
                inputIsValid = false;
            }
        }
    }
    
    if (inputIsValid)  break;
    else
        Console.WriteLine("Ошибка ввода позиции элемента, повторите ввод");
    
}
//foreach (var i in inputIndexes){ Console.Write($"{i}, "); } Console.WriteLine();

int[,] matrix = InitMatrix (rows : newMatrixDimensions[rows],
                            columns: newMatrixDimensions[columns],
                            rndMin: 0,
                            rndMax: 100);

PrintMatrix (matrix);

if (inputIndexes[columns] > matrix.GetLength(columns)
||  inputIndexes[rows] > matrix.GetLength(rows))
{
    Console.WriteLine("Нет такого элемента");
}
else
{
    Console.WriteLine("Элемент в позиции ({0}, {1}): {2}", 
                        inputIndexes[columns],
                        inputIndexes[rows], 
                        matrix[ inputIndexes[columns], inputIndexes[rows] ]
                        );
}




