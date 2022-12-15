// table [0,0] - 1 столбик, table [0,4] последний 5-й столбик
// table [1,0] - 1 столбик второй строки, table [0,4] последний 5-й столбик второй строки
// string.Empty
// string[,] table = new string[2, 5];
// table[1, 2] = "x";
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }



// int[,] matrix = new int[3, 4];
// for (int i = 0; i < 3; i++)
// {
//     for (int j = 0; j < 4; j++)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // GetLength(0) - 1- количество строк (в нащем случае 3 строки)
    {
        for (int j = 0; j < matr.GetLength(1); j++)  // GetLength(1) - 1 - количество столбцов (в нащем случае 4 столбца)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // GetLength(0) - 1- количество строк (в нащем случае 3 строки)
    {
        for (int j = 0; j < matr.GetLength(1); j++)  // GetLength(1) - 1 - количество столбцов (в нащем случае 4 столбца)
        {
            matr[i, j] = new Random().Next(1, 10); // [1;10)
        }

    }
}

int[,] matrix = new int[3, 4]; // тут обязательно указываем,чтобы знать, сколько памяти оставлять
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);