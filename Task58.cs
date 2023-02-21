using System;

namespace MatrixMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = new int[2, 2] { { 1, 2 }, { 4, 5 } };  // Первая матрица размером 2x3. 

            int[,] matrix2 = new int[2, 2] { { 7, 8 }, { 9, 10 }, }; // Вторая матрица размером 3x2.

            int rows1 = matrix1.GetLength(0); // Количество строк в первой матрице. 

            int columns1 = matrix1.GetLength(1); // Количество столбцов в первой матрице.

            int rows2 = matrix2.GetLength(0); // Количество строк во второй матрице.

            int columns2 = matrix2.GetLength(1); // Количество столбцов во второй матрице.

            if (columns1 != rows2) //Провекка: умножения 2-ух матриц A*B (A - m x n; B - n x k) - m x k - умнджный случай!
                Console.WriteLine("Matrices cannot be multiplied!");

            else
            {
                int[,] resultMatrix = new int[rows1, columns2]; // C - m x k

                for (int i = 0; i < rows1; i++)   
                    for (int j = 0; j < columns2; j++)  
                        for (int k = 0; k < columns1; k++)  
                            resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];  

                Console.WriteLine("Result Matrix:");

                for (int i = 0; i < rows1; i++)  
                {
                    for (int j = 0; j < columns2; j++)  
                        Console.Write(resultMatrix[i, j] + " ");  

                    Console.WriteLine();                    

                }             
            } 
        }     
    }
}
