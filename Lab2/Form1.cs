using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Accord.Math;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;

namespace Lab2
{
    public partial class Form1 : Form
    {
        /*static char[] alphabet = {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
            'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
        };*/
        static char[] alphabet = {
            'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м',
            'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ',
            'ы', 'ь', 'э', 'ю', 'я',
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
            '!', '@', '#', '$', '%', '^', '&', '*', '(', ')',' '
        };
        static bool flagrandom = true;
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 2; i++)
            {
                Matrixdg.Columns.Add("col" + i, "");
                Matrixdg.Columns[i].Width = 50;
            }
            for (int i = 0; i < 2 - 1; i++)
            {
                Matrixdg.Rows.Add();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int selectedValue = Convert.ToInt32(numericUpDown1.Value);

            Matrixdg.Rows.Clear();
            Matrixdg.Columns.Clear();

            for (int i = 0; i < selectedValue; i++)
            {
                Matrixdg.Columns.Add("col" + i, "");
                Matrixdg.Columns[i].Width = 50;
            }
            for (int i = 0; i < selectedValue-1; i++)
            {
                Matrixdg.Rows.Add();
            }
        }
        private Matrix<double> ConvertToMatrix(int[,] arrayMatrix)
        {
            var rows = arrayMatrix.GetLength(0);
            var columns = arrayMatrix.GetLength(1);
            var matrix = Matrix<double>.Build.Dense(rows, columns);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = arrayMatrix[i, j];
                }
            }
            return matrix;
        }
        private void RandomKeybutton_Click(object sender, EventArgs e)
        {
            int selectedValue = Convert.ToInt32(numericUpDown1.Value);
            flagrandom = true;
            Matrixdg.Rows.Clear();
            Matrixdg.Columns.Clear();

            for (int i = 0; i < selectedValue; i++)
            {
                Matrixdg.Columns.Add("col" + i, "");
                Matrixdg.Columns[i].Width = 50;
            }
            for (int i = 0; i < selectedValue - 1; i++)
            {
                Matrixdg.Rows.Add();
            }       
            Random random = new Random();

            int[,] matrix = new int[selectedValue, selectedValue];
            Matrix<double> matrixObject = Matrix<double>.Build.Dense(1, 1);
            int determinant = 0;
            while (true)
            {
                for (int i = 0; i < selectedValue; i++)
                {
                    for (int j = 0; j < selectedValue; j++)
                    {
                        matrix[i, j] = random.Next(1, alphabet.Length);
                    }
                }
                matrixObject = ConvertToMatrix(matrix);
                if (MatrixWork.CheckConstraints(matrixObject, alphabet))
                {
                    break;
                }
            }
            MatrixToDg(matrixObject, selectedValue);
        }
        public void MatrixToDg(Matrix<double> matrix,int selectedValue)
        {
            for (int i = 0; i < selectedValue; i++)
            {
                if (i >= Matrixdg.Rows.Count)
                {
                    Matrixdg.Rows.Add();
                }
                for (int j = 0; j < selectedValue; j++)
                {
                    Matrixdg.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }
        
        private void ClearMatrix_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in Matrixdg.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Value = null;
                }
            }
        }
        static Matrix<double> DataGridViewToMatrix(DataGridView dataGridView,int rowToRemove)
        {
            int rowCount = dataGridView.Rows.Count;
            int columnCount = dataGridView.Columns.Count;
            double[,] result = new double[rowCount - (flagrandom ? 0 : 1), columnCount];

            int resultRow = 0; 

            for (int i = 0; i < rowCount; i++)
            {
                if (i == rowToRemove && !flagrandom) continue;
                for (int j = 0; j < columnCount; j++)
                {
                    if (dataGridView.Rows[i].Cells[j].Value != null)
                    {
                        double value;
                        if (double.TryParse(dataGridView.Rows[i].Cells[j].Value.ToString(), out value))
                        {
                            result[resultRow, j] = value;
                        }
                        else
                        {
                            
                        }
                    }
                    else
                    {
                        
                    }
                }
                resultRow++; 
            }

            return Matrix<double>.Build.DenseOfArray(result);
        }
        private void CodeTextbutton_Click(object sender, EventArgs e)
        {
            int selectedValue = Convert.ToInt32(numericUpDown1.Value);
            Matrix<double> keyMatrix = DataGridViewToMatrix(Matrixdg, selectedValue);

            if (!MatrixWork.CheckConstraints(keyMatrix, alphabet))
            {
                MessageBox.Show("Invalid key matrix. Determinant must be non-zero and coprime with the length of the alphabet.");
                return;
            }

            CodeTextbox.Text = HillCipher.Encrypt(DecodeTextbox.Text, keyMatrix, alphabet);
        }

        private void DecodeTextbutton_Click(object sender, EventArgs e)
        {
            int selectedValue = Convert.ToInt32(numericUpDown1.Value);
            Matrix<double> keyMatrix = DataGridViewToMatrix(Matrixdg, selectedValue);
            DecodeTextbox.Text = HillCipher.Decrypt(CodeTextbox.Text, keyMatrix,alphabet);
        }

        private void ClearCodeText_Click(object sender, EventArgs e)
        {
            DecodeTextbox.Clear();
        }

        private void ClearDecodeText_Click(object sender, EventArgs e)
        {
            CodeTextbox.Clear();
        }

        private void Analysis_Click(object sender, EventArgs e)
        {
            ShowStat();
        }
        private void ShowStat()
        {
            chart1.Series.Clear();
            int i = 1;
            var dataSource = Analysis.countAppearencesOfLetter(CodeTextbox.Text);
            var encryptedMessageFrequency = (from pair in dataSource
                                             orderby pair.Value descending
                                             select new
                                             {
                                                 Num = i++,
                                                 letterColumn = pair.Key,
                                                 countColumn = Math.Round(pair.Value, 2)
                                             }).ToList();
            EncryptedTextFrequency.DataSource = encryptedMessageFrequency;

            i = 1;
            var russianFrequency = (from pair in Analysis.RUSSIANDICT
                                    orderby pair.Value descending
                                    select new
                                    {
                                        Num = i++,
                                        letterColumn = pair.Key,
                                        countColumn = pair.Value
                                    }).ToList();
            RussianFrequency.DataSource = russianFrequency;

            i = 1;
            dataSource = Analysis.countAppearencesOfLetter(DecodeTextbox.Text);
            var orgiginalTextFrequency = (from pair in dataSource
                                          orderby pair.Value descending
                                          select new
                                          {
                                              Num = i++,
                                              letterColumn = pair.Key,
                                              countColumn = Math.Round(pair.Value, 2)
                                          }).ToList();
            OriginalTextFrequency.DataSource = orgiginalTextFrequency;

            EncryptedTextFrequency.Columns[0].HeaderText = "№";
            EncryptedTextFrequency.Columns[1].HeaderText = "EL";
            EncryptedTextFrequency.Columns[2].HeaderText = "%";

            RussianFrequency.Columns[0].HeaderText = "№";
            RussianFrequency.Columns[1].HeaderText = "RL";
            RussianFrequency.Columns[2].HeaderText = "%";

            OriginalTextFrequency.Columns[0].HeaderText = "№";
            OriginalTextFrequency.Columns[1].HeaderText = "OL";
            OriginalTextFrequency.Columns[2].HeaderText = "%";

            var russianFrequencySeries = new System.Windows.Forms.DataVisualization.Charting.Series("Русский язык");
            var encryptedMessageFrequencySeries = new System.Windows.Forms.DataVisualization.Charting.Series("Зашифрованное сообщение");
            var originalTextSeries = new System.Windows.Forms.DataVisualization.Charting.Series("Оригинальный текст");

            foreach (var pair in russianFrequency)
            {
                russianFrequencySeries.Points.AddXY(pair.Num.ToString(), pair.countColumn);
            }

            foreach (var pair in encryptedMessageFrequency)
            {
                if (Analysis.RUSSIANDICT.ContainsKey(pair.letterColumn))
                {
                    encryptedMessageFrequencySeries.Points.AddXY(pair.Num.ToString(), pair.countColumn);
                }
            }

            foreach (var pair in orgiginalTextFrequency)
            {
                if (Analysis.RUSSIANDICT.ContainsKey(pair.letterColumn))
                {
                    originalTextSeries.Points.AddXY(pair.Num.ToString(), pair.countColumn);
                }
            }

            chart1.Series.Add(russianFrequencySeries);
            chart1.Series.Add(encryptedMessageFrequencySeries);
            chart1.Series.Add(originalTextSeries);

            chart1.Series["Русский язык"].ChartType = SeriesChartType.Line;
            chart1.Series["Зашифрованное сообщение"].ChartType = SeriesChartType.Line;
            chart1.Series["Оригинальный текст"].ChartType = SeriesChartType.Line;

            chart1.Series["Русский язык"].MarkerStyle = MarkerStyle.Circle;
            chart1.Series["Зашифрованное сообщение"].MarkerStyle = MarkerStyle.Circle;
            chart1.Series["Оригинальный текст"].MarkerStyle = MarkerStyle.Circle;

            chart1.Series["Русский язык"].BorderWidth = 2;
            chart1.Series["Зашифрованное сообщение"].BorderWidth = 2;
            chart1.Series["Оригинальный текст"].BorderWidth = 2;

            chart1.ChartAreas[0].AxisX.Title = "Буква";
            chart1.ChartAreas[0].AxisY.Title = "Частота появления";

            chart1.DataBind();
        }

        private void Matrixdg_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            flagrandom = false;
        }

        private void SavaFilebutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CodeTextbox.Text)) return;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFileDialog.FileName;
                    try
                    {
                        File.WriteAllText(path, CodeTextbox.Text);
                        MessageBox.Show("Файл успешно сохранен");
                    }
                    catch
                    {
                        MessageBox.Show("Файл не сохранился");
                    }
                }
            }
        }

        private void ChooseFilebutton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = File.ReadAllText(filename);
            DecodeTextbox.Text = fileText;
        }
        static void AddMatrixToDataGridView(DataGridView dataGridView, Matrix<double> matrix)
        {
            dataGridView.ColumnCount = matrix.RowCount;
            dataGridView.RowCount = matrix.RowCount;

            for (int i = 0; i < matrix.RowCount; i++)
            {
                for (int j = 0; j < matrix.RowCount; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = matrix[j, i];
                }
                dataGridView.Columns[i].Width = 50;
            }
        }
        private void FindKeyButton_Click(object sender, EventArgs e)
        {
            int keySize = Convert.ToInt32(numericUpDown1.Value);
            var keyMatrix = HillCipher.FindKeyMatrix(DecodeTextbox.Text,CodeTextbox.Text,keySize,alphabet);
            AddMatrixToDataGridView(FoundedKeyDg, keyMatrix);
        }

        private void FoundKeyDicrp_Click(object sender, EventArgs e)
        {
            int selectedValue = Convert.ToInt32(numericUpDown1.Value);
            Matrix<double> keyMatrix = DataGridViewToMatrix(FoundedKeyDg, selectedValue);
            DecodeTextbox.Text = HillCipher.Decrypt(CodeTextbox.Text, keyMatrix, alphabet);
        }

        private void ClearFoundedKey_Click(object sender, EventArgs e)
        {
            FoundedKeyDg.Rows.Clear();
            FoundedKeyDg.Columns.Clear();
        }

        private void ChooseDecodeFilebutton_Click(object sender, EventArgs e)
        {

        }
    }
}
