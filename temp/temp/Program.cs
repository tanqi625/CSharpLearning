using System;

struct Matrix
{
    private int[,] data; // 矩阵数据
    public int Rows { get; } // 行数
    public int Cols { get; } // 列数

    // 构造函数
    public Matrix(int rows, int cols)
    {
        Rows = rows;
        Cols = cols;
        data = new int[rows, cols];
    }

    // 索引器，用于访问矩阵元素
    public int this[int row, int col]
    {
        get { return data[row, col]; }
        set { data[row, col] = value; }
    }

    // 矩阵加法
    public static Matrix operator +(Matrix a, Matrix b)
    {
        if (a.Rows != b.Rows || a.Cols != b.Cols)
            throw new InvalidOperationException("矩阵的行列数必须相同才能相加。");

        Matrix result = new Matrix(a.Rows, a.Cols);
        for (int i = 0; i < a.Rows; i++)
        {
            for (int j = 0; j < a.Cols; j++)
            {
                result[i, j] = a[i, j] + b[i, j];
            }
        }
        return result;
    }

    // 矩阵减法
    public static Matrix operator -(Matrix a, Matrix b)
    {
        if (a.Rows != b.Rows || a.Cols != b.Cols)
            throw new InvalidOperationException("矩阵的行列数必须相同才能相减。");

        Matrix result = new Matrix(a.Rows, a.Cols);
        for (int i = 0; i < a.Rows; i++)
        {
            for (int j = 0; j < a.Cols; j++)
            {
                result[i, j] = a[i, j] - b[i, j];
            }
        }
        return result;
    }

    // 矩阵乘法
    public static Matrix operator *(Matrix a, Matrix b)
    {
        if (a.Cols != b.Rows)
            throw new InvalidOperationException("矩阵A的列数必须等于矩阵B的行数才能相乘。");

        Matrix result = new Matrix(a.Rows, b.Cols);
        for (int i = 0; i < a.Rows; i++)
        {
            for (int j = 0; j < b.Cols; j++)
            {
                for (int k = 0; k < a.Cols; k++)
                {
                    result[i, j] += a[i, k] * b[k, j];
                }
            }
        }
        return result;
    }

    // 打印矩阵
    public void Print()
    {
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                Console.Write(data[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        // 定义两个矩阵
        Matrix a = new Matrix(2, 2);
        a[0, 0] = 1; a[0, 1] = 2;
        a[1, 0] = 3; a[1, 1] = 4;

        Matrix b = new Matrix(2, 2);
        b[0, 0] = 5; b[0, 1] = 6;
        b[1, 0] = 7; b[1, 1] = 8;

        // 矩阵加法
        Console.WriteLine("矩阵加法结果：");
        Matrix c = a + b;
        c.Print();

        // 矩阵减法
        Console.WriteLine("矩阵减法结果：");
        Matrix d = a - b;
        d.Print();

        // 矩阵乘法
        Console.WriteLine("矩阵乘法结果：");
        Matrix e = a * b;
        e.Print();
        Console.ReadKey();
    }
}
