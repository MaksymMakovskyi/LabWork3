using System;

namespace LabWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть кiлькiсть рядкiв матрицi: ");
            int lines = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введiть кiлькiсть колонок матрицi: ");
            int columns = Convert.ToInt16(Console.ReadLine());
            Matrix NewMatrix1 = new Matrix(lines, columns);
            Matrix NewMatrix2 = new Matrix(lines, columns);

            Console.WriteLine("Матриця №1: ");
            Console.WriteLine(NewMatrix1);
            Console.WriteLine("Матриця №2: ");
            Console.WriteLine(NewMatrix2);
            Console.WriteLine("Введiть кiлькiсть елементiв вектора: ");

            int linesvector = Convert.ToInt16(Console.ReadLine());
            Vector vector1 = new Vector(linesvector);
            Vector vector2 = new Vector(linesvector);
            Console.WriteLine("Вектор №1: ");
            Console.WriteLine(vector1 + "\n");
            Console.WriteLine("Вектор №2: ");
            Console.WriteLine(vector2 + "\n");
            Line(columns);

            //Множення вектора на матрицю і навпаки
            Console.WriteLine("\nВектор х Матрицю : ");
            Console.WriteLine(vector1 * NewMatrix1);
            Console.WriteLine("\nМатриця х Вектор : ");
            Console.WriteLine(NewMatrix1 * vector1);
            Line(columns);

            //Множення вектора на вектор
            Console.WriteLine("\n Вектор х Вектор : ");
            Console.WriteLine(vector1 * vector2);
            Line(columns);

            //Множення матриці на матрицю
            Console.WriteLine("\n Матриця х Матрицю : ");
            Console.WriteLine(NewMatrix1 * NewMatrix2);
            Line(columns);

            //Множення вектора на число і навпаки
            Console.WriteLine("Введiть число, на яке ви хочете помножити вектор");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Вектор х Число : ");
            Console.WriteLine(vector1 * n);
            Line(columns);
            Console.WriteLine("\n Число х Вектор : ");
            Console.WriteLine(n * vector2);
            Line(columns);

            //Множення матриці на число і навпаки
            Console.WriteLine("Введiть число, на яке ви хочете помножити матрицю");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Число х Матрицю : ");
            Console.WriteLine(m * NewMatrix1);
            Line(columns);
            Console.WriteLine("\n Матриця х Число: ");
            Console.WriteLine(NewMatrix1 * m);
            Line(columns);
            Console.ReadKey();
        }
        //Метод,що виводить в консоль роздільну лінію
        static void Line(int columns)
        {
            int count = columns * 8;
            Console.WriteLine();
            for (int i = 0; i < count; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine("\n");
        }
    }
}
