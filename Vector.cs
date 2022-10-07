using System;

namespace LabWork3
{
    internal class Vector
    {
        public int lines;
        public int[] vector;
        //Деструктор
        ~Vector()
        {
            Console.WriteLine("Визваний деструктор класу вектор");
        }
        public int this[int i]
        {
            get
            {
                if (i == 1) return lines;
                else return 0;
            }
            set
            {
                if (i == 1) lines = value;
            }
        }
        //Ініціалізація вектора
        public Vector(int lines)
        {
            this.lines = lines;
            Random R = new Random();
            vector = new int[lines];
            for (int i = 0; i < lines; i++)
            {
                vector[i] = R.Next(10);
            }
        }
        public override string ToString()
        {
            string st = "";
            for (int i = 0; i < lines; i++)
            {
                st += vector[i].ToString() + "\t";
            }
            return st;
        }
        //Множення вектора на матрицю
        public static Vector operator *(Vector vector, Matrix Matrix1)
        {
            Vector SumVector = new Vector(vector.lines);
            SumVector.lines = Matrix1.lines;
            for (int k = 0; k < vector.lines; k++)
            {
                SumVector.vector[k] = 0;
            }
            if (vector.lines != Matrix1.columns)
            {
                Console.WriteLine("Помилка!");
                Console.WriteLine("Кiлькiсть рядкiв вектора має спiвпадати iз кiлькiстю стовпцiв матрицi!!!\n");
                Environment.Exit(0);
            }
            else
            {

                for (int i = 0; i < Matrix1.lines; i++)
                {
                    for (int j = 0; j < Matrix1.columns; j++)
                    {
                        SumVector.vector[i] = (Matrix1.matrix[j, i] * vector.vector[j]) + SumVector.vector[i];
                    }
                }
                return SumVector;
            }
            return SumVector;
        }
        //Множення матриці на вектор
        public static Vector operator *(Matrix Matrix1, Vector vector)
        {
            Vector SumVector = new Vector(vector.lines);
            SumVector.lines = Matrix1.lines;
            for (int k = 0; k < vector.lines; k++)
            {
                SumVector.vector[k] = 0;
            }
            if (vector.lines != Matrix1.columns)
            {
                Console.WriteLine("Помилка!");
                Console.WriteLine("Кiлькiсть рядкiв вектора має спiвпадати iз кiлькiстю стовпцiв матрицi!!!\n");
                Environment.Exit(0);
            }
            else
            {
                for (int i = 0; i < Matrix1.lines; i++)
                {
                    for (int j = 0; j < Matrix1.columns; j++)
                    {
                        SumVector.vector[i] = (Matrix1.matrix[j, i] * vector.vector[j]) + SumVector.vector[i];
                    }
                }
                return SumVector;
            }
            return SumVector;
        }
        //Множення вектора на число
        public static Vector operator *(Vector vector, int n)
        {
            Vector SumVector1 = new Vector(vector.lines);
            SumVector1.lines = vector.lines;
            for (int j = 0; j < vector.lines; j++)
            {
                SumVector1.vector[j] = 0;
            }
            for (int i = 0; i < vector.lines; i++)
            {
                SumVector1.vector[i] = vector.vector[i] * n;
            }
            return SumVector1;
        }
        //Множення числа на вектор
        public static Vector operator *(int n, Vector vector)
        {
            Vector SumVector1 = new Vector(vector.lines);
            SumVector1.lines = vector.lines;
            for (int j = 0; j < vector.lines; j++)
            {
                SumVector1.vector[j] = 0;
            }
            for (int i = 0; i < vector.lines; i++)
            {
                SumVector1.vector[i] = vector.vector[i] * n;
            }
            return SumVector1;
        }
        //Множення вектора на вектор
        public static Vector operator *(Vector vector1, Vector vector2)
        {
            Vector SumVector1 = new Vector(vector1.lines);
            SumVector1.lines = vector1.lines;
            for (int j = 0; j < vector1.lines; j++)
            {
                SumVector1.vector[j] = 0;
            }
            for (int i = 0; i < vector1.lines; i++)
            {
                SumVector1.vector[i] = vector1.vector[i] * vector2.vector[i];
            }
            return SumVector1;
        }
    }
}
