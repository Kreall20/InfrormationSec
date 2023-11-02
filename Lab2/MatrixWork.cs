using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    static class MatrixWork
    {
        public static int CommonDivisorExtended(int a, int b, ref int x, ref int y)
        {
            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }

            int x1 = 1, y1 = 1;
            int gcd = CommonDivisorExtended(b % a, a, ref x1, ref y1);

            x = y1 - (b / a) * x1;
            y = x1;

            return gcd;
        }
        public static Matrix<double> Inverse(Matrix<double> key, char[] alphabet)
        {
            int alphabetLength = alphabet.Length;
            Matrix<double> adjugateKey = key.Adjugate() % alphabetLength;
            NormalizeMatrix(adjugateKey, alphabet);

            double keyDeterminant = Math.Round(key.Determinant()) % alphabetLength;
            if (keyDeterminant < 0)
                keyDeterminant += alphabetLength;

            int inverseDeterminant = 0;
            int inverseAlphabet = 0;
            CommonDivisorExtended((int)keyDeterminant, alphabetLength, ref inverseDeterminant, ref inverseAlphabet);
            if (inverseDeterminant < 0)
                inverseDeterminant += alphabetLength;

            return inverseDeterminant * adjugateKey % alphabetLength;
        }

        static void NormalizeMatrix(Matrix<double> matrix, char[] alphabet)
        {
            for (int i = 0; i < matrix.RowCount; i++)
            {
                for (int j = 0; j < matrix.ColumnCount; j++)
                {
                    matrix[i, j] = Math.Round(matrix[i, j]);
                    if (matrix[i, j] < 0)
                        matrix[i, j] += alphabet.Length;
                }
            }
        }
        static Matrix<double> Adjugate(this Matrix<double> matrix)
        {
            MatrixBuilder<double> builder = Matrix<double>.Build;
            if (matrix.RowCount != matrix.ColumnCount)
                throw new ArgumentException("Matrix ought to be square.");

            int dimension = matrix.RowCount;
            LinkedList<double> adjugateValues = new LinkedList<double>();
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    adjugateValues.AddLast(Math.Pow(-1, i + j) * matrix.Cofactor(i, j).Determinant());
                }
            }

            return builder.DenseOfRowMajor(dimension, dimension, adjugateValues).Transpose();
        }

        static Matrix<double> Cofactor(this Matrix<double> matrix, int row, int column)
        {
            MatrixBuilder<double> builder = Matrix<double>.Build;
            int dimension = matrix.RowCount;
            LinkedList<double> cofactorValues = new LinkedList<double>();
            for (int k = 0; k < dimension; k++)
            {
                if (k == row)
                    continue;

                for (int l = 0; l < dimension; l++)
                {
                    if (l == column)
                        continue;

                    cofactorValues.AddLast(matrix[k, l]);
                }
            }

            int lowerDimension = dimension - 1;
            return builder.DenseOfRowMajor(lowerDimension, lowerDimension, cofactorValues);
        }
        public static bool CheckConstraints(Matrix<double> matrix, char[] alphabet)
        {
            var determinant = (long)Math.Round(matrix.Determinant(), 0);

            var firstCondition = determinant != 0;
            var secondCondition = Euclid.GreatestCommonDivisor(determinant, alphabet.Length) == 1;

            return firstCondition && secondCondition;
        }
    }
}
