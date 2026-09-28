using System;

class MatrixOperations
{
    // Tạo ma trận N x M ngẫu nhiên
    public static int[,] CreateRandomMatrix(int rows, int cols, int minVal = 1, int maxVal = 50)
    {
        Random rand = new Random();
        int[,] matrix = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = rand.Next(minVal, maxVal + 1);
            }
        }
        return matrix;
    }

    // In ma trận
    public static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j],4}");
            }
            Console.WriteLine();
        }
    }

    // In hàng i 
    public static void PrintRow(int[,] matrix, int rowIndex)
    {
        int cols = matrix.GetLength(1);
        Console.Write($"Hang {rowIndex}: ");
        for (int j = 0; j < cols; j++)
        {
            Console.Write(matrix[rowIndex, j] + " ");
        }
        Console.WriteLine();
    }

    // In cột i 
    public static void PrintColumn(int[,] matrix, int colIndex)
    {
        int rows = matrix.GetLength(0);
        Console.Write($"Cot {colIndex}: ");
        for (int i = 0; i < rows; i++)
        {
            Console.Write(matrix[i, colIndex] + " ");
        }
        Console.WriteLine();
    }

    // Tìm giá trị lớn nhất toàn ma trận
    public static int FindMax(int[,] matrix)
    {
        int max = matrix[0, 0];
        foreach (int val in matrix)
        {
            if (val > max) max = val;
        }
        return max;
    }

    // Tìm min của hàng i
    public static int FindMinOfRow(int[,] matrix, int rowIndex)
    {
        int cols = matrix.GetLength(1);
        int min = matrix[rowIndex, 0];
        for (int j = 1; j < cols; j++)
        {
            if (matrix[rowIndex, j] < min) min = matrix[rowIndex, j];
        }
        return min;
    }

    // Tìm min của cột i
    public static int FindMinOfCol(int[,] matrix, int colIndex)
    {
        int rows = matrix.GetLength(0);
        int min = matrix[0, colIndex];
        for (int i = 1; i < rows; i++)
        {
            if (matrix[i, colIndex] < min) min = matrix[i, colIndex];
        }
        return min;
    }

    // Chuyển vị ma trận
    public static int[,] Transpose(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] transposed = new int[cols, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transposed[j, i] = matrix[i, j];
            }
        }
        return transposed;
    }

    // In đường chéo chính và đường chéo phụ
    public static void PrintDiagonals(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != cols)
        {
            Console.WriteLine("Ma tran khong phai ma tran vuong, khong co duong cheo chinh/phu!");
            return;
        }

        Console.Write("Duong cheo chinh: ");
        for (int i = 0; i < rows; i++)
        {
            Console.Write(matrix[i, i] + " ");
        }
        Console.WriteLine();

        Console.Write("Duong cheo phu: ");
        for (int i = 0; i < rows; i++)
        {
            Console.Write(matrix[i, rows - 1 - i] + " ");
        }
        Console.WriteLine();
    }

    public static void Main()
    {
        Console.Write("Nhap so hang N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Nhap so cot M: ");
        int m = int.Parse(Console.ReadLine());

        int[,] matrix = CreateRandomMatrix(n, m);

        Console.WriteLine(" MA TRAN DUOC TAO ");
        PrintMatrix(matrix);

        Console.Write($"\nNhap vi tri hang i (0 toi {n - 1}): ");
        int r = int.Parse(Console.ReadLine());
        PrintRow(matrix, r);
        Console.WriteLine($"Gia tri nho nhat cua hang {r}: {FindMinOfRow(matrix, r)}");

        Console.Write($"\nNhap vi tri cot i (0 toi {m - 1}): ");
        int c = int.Parse(Console.ReadLine());
        PrintColumn(matrix, c);
        Console.WriteLine($"Gia tri nho nhat cua cot {c}: {FindMinOfCol(matrix, c)}");

        Console.WriteLine($"Gia tri lon nhat cua toan ma tran: {FindMax(matrix)}");

        Console.WriteLine(" MA TRAN CHUYEN VI (TRANSPOSE)");
        PrintMatrix(Transpose(matrix));

        Console.WriteLine(" CAC DUONG CHEO ");
        PrintDiagonals(matrix);
    }
}