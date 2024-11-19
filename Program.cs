namespace Assignment_3_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                // Initialize a 2D array with some integers
                int[,] matrix = new int[,]
                {
                { 2, 3, 4 },
                { 1, 4, 6 },
                };

                Console.WriteLine("Matrix Output");
                PrintMatrix(matrix);
            }
        }                    
            
            static void PrintMatrix(int[,] matrix)
            {
                // Get the number of rows and columns in the matrix
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);

                // Loop through each row
                for (int i = 0; i < rows; i++)
                {
                    // Loop through each column
                    for (int j = 0; j < cols; j++)
                    {
                       
                        Console.Write($"{matrix[i, j],4}"); 
                    }
                    Console.WriteLine(); 
                }
            }
        }
    }

