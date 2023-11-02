using Lab2.Properties;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Lab2
{
    public static class HillCipher
    {
        public static string Encrypt(string plaintext, Matrix<double> keyMatrix, char[] alphabet)
        {
            int n = plaintext.Length;
            int keySize = keyMatrix.ColumnCount;
            double[] plainVector = new double[keySize];

            string encryptedText = "";
            for (int i = 0; i < n; i += keySize)
            {
                for (int j = 0; j < keySize; j++)
                {
                    if (i + j < n)
                    {
                        plainVector[j] = Array.IndexOf(alphabet, char.ToLower(plaintext[i + j]));
                    }
                    else
                    {
                        plainVector[j] = Array.IndexOf(alphabet, ' ');
                    }
                }
                Vector<double> resultVector = keyMatrix.Multiply(Vector<double>.Build.DenseOfArray(plainVector));
                for (int j = 0; j < keySize; j++)
                {
                    int encryptedIndex = Convert.ToInt32(Math.Round(resultVector[j])) % alphabet.Length;
                    if (encryptedIndex < 0)
                    {
                        encryptedIndex += alphabet.Length;
                    }
                    encryptedText += alphabet[encryptedIndex];
                }
            }
            return encryptedText;
        }

        public static string Decrypt(string encryptedText, Matrix<double> keyMatrix, char[] alphabet)
        {
            int n = encryptedText.Length;
            int keySize = keyMatrix.ColumnCount;
            double[] encryptedVector = new double[keySize];

            string decryptedText = "";
            var inverseMatrix = MatrixWork.Inverse(keyMatrix, alphabet);
            for (int i = 0; i < n; i += keySize)
            {
                for (int j = 0; j < keySize; j++)
                {
                    if (i + j < n)
                    {
                        encryptedVector[j] = Array.IndexOf(alphabet, encryptedText[i + j]);
                    }
                    else
                    {
                        encryptedVector[j] = Array.IndexOf(alphabet, ' ');
                    }
                }
                Vector<double> resultVector = inverseMatrix.Multiply(Vector<double>.Build.DenseOfArray(encryptedVector));
                for (int j = 0; j < keySize; j++)
                {
                    int decryptedIndex = (int)Math.Round(resultVector[j]) % alphabet.Length;
                    if (decryptedIndex < 0)
                    {
                        decryptedIndex += alphabet.Length;
                    }
                    decryptedText += alphabet[decryptedIndex];
                }
            }
            return decryptedText;
        }
        public static Matrix<double> FindKeyMatrix(string originalText, string encryptedText, int size, char[] alphabet)
        {
            Matrix<double> matrixX, matrixY;
            string originalTextPortion, encryptedTextPortion;
            var i = 0;
            do
            {
                originalTextPortion = PrepareTextToEncrypting(originalText, size * size, alphabet, i);
                encryptedTextPortion = PrepareTextToEncrypting(encryptedText, size * size, alphabet, i);

                matrixX = GetMatrixFromString(originalTextPortion, alphabet);
                matrixY = GetMatrixFromString(encryptedTextPortion, alphabet);

                i += size;
            } while (!MatrixWork.CheckConstraints(matrixX, alphabet));

            return MatrixWork.Inverse(matrixX, alphabet) * matrixY % alphabet.Length;
        }

        private static string PrepareTextToEncrypting(string original, int length, char[] alphabet, int startIndex = 0)
        {
            var text = "";
            var symbolsInAlphabet = original.Where(x => alphabet.Contains(x)).ToArray();
            for (var i = startIndex; i < Math.Min(length + startIndex, symbolsInAlphabet.Length); i++)
            {
                text += symbolsInAlphabet[i];
            }
            return text;
        }

        public static Matrix<double> GetMatrixFromString(string text, char[] alphabet)
        {
            var matrix = DenseMatrix.Build.DenseDiagonal(1, 1, 0);
                var size = int.Parse(Math.Sqrt(text.Length).ToString());
                matrix = DenseMatrix.Build.DenseDiagonal(size, size, 0);
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        matrix.At(i, j, Array.IndexOf(alphabet, text[i * size + j]));
                    }
                }
            return matrix;
        }
    }
}
