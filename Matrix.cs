using System;

namespace LabWork3
{
    internal class Matrix
    {
        public int lines;
        public int columns;
        public int[,] matrix;
        //Деструктор
        ~Matrix()
        {
            Console.WriteLine("Визваний деструктор класу матриця");
        }
        public int this[int i]
        {
            get
            {
                if (i == 1) return lines;
                else if (i == 2) return columns;
                else return 0;
            }
            set
            {
                if (i == 1) lines = value;
                else if (i == 2) columns = value;
            }
        }
        public override string ToString()
        {
            string st = "";
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    st += matrix[i, j].ToString() + "\t";
                }
                st += "\n\n";
            }
            return st;
        }
        //Ініціалізація матриці
        public Matrix(int lines, int columns)
        {
            this.lines = lines;
            this.columns = columns;
            Random R = new Random();
            matrix = new int[lines, columns];
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = R.Next(10);
                }
            }
        }
        //Множення матриці на матрицю
        public static Matrix operator *(Matrix Matrix1, Matrix Matrix2)
        {
            Matrix Matrix3 = new Matrix(Matrix1.lines, Matrix1.columns);
            Matrix3.lines = Matrix1.lines;
            Matrix3.columns = Matrix1.columns;
            for (int i = 0; i < Matrix3.lines; i++)
            {
                for (int j = 0; j < Matrix3.columns; j++)
                {
                    Matrix3.matrix[i, j] = 0;
                }
            }
            for (int i = 0; i < Matrix1.lines; i++)
            {
                for (int j = 0; j < Matrix2.columns; j++)
                {
                    Matrix3.matrix[i, j] += Matrix1.matrix[i, j] * Matrix2.matrix[i, j];
                }
            }
            return Matrix3;
        }
        //Множення матриці на число
        public static Matrix operator *(Matrix Matrix1, int n)
        {
            Matrix Matrix3 = new Matrix(Matrix1.lines, Matrix1.columns);
            Matrix3.lines = Matrix1.lines;
            Matrix3.columns = Matrix1.columns;
            for (int i = 0; i < Matrix3.lines; i++)
            {
                for (int j = 0; j < Matrix3.columns; j++)
                {
                    Matrix3.matrix[i, j] = 0;
                }
            }
            for (int i = 0; i < Matrix1.lines; i++)
            {
                for (int j = 0; j < Matrix1.columns; j++)
                {
                    Matrix3.matrix[i, j] += Matrix1.matrix[i, j] * n;
                }
            }
            return Matrix3;
        }
        //Множення числа на матрицю
        public static Matrix operator *(int n, Matrix Matrix1)
        {
            Matrix Matrix3 = new Matrix(Matrix1.lines, Matrix1.columns);
            Matrix3.lines = Matrix1.lines;
            Matrix3.columns = Matrix1.columns;
            for (int i = 0; i < Matrix3.lines; i++)
            {
                for (int j = 0; j < Matrix3.columns; j++)
                {
                    Matrix3.matrix[i, j] = 0;
                }
            }
            for (int i = 0; i < Matrix1.lines; i++)
            {
                for (int j = 0; j < Matrix1.columns; j++)
                {
                    Matrix3.matrix[i, j] += n * Matrix1.matrix[i, j];
                }
            }
            return Matrix3;
        }
    }
}
