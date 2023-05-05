using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MatrixCalculator
{
    public partial class MatrixCalculator : Form
    {
 
        public MatrixCalculator()
        {
            InitializeComponent();
           
        }
     
        //Данный метод производит умножение матриц
        private void MatricesM_Click(object sender, System.EventArgs e)
        {
            try
            {
                
                matrixAB1.Text = ((Convert.ToDouble(matrixA1.Text) * Convert.ToDouble(matrixB1.Text)) + (Convert.ToDouble(matrixA4.Text) * Convert.ToDouble(matrixB2.Text)) + (Convert.ToDouble(matrixA7.Text) * Convert.ToDouble(matrixB3.Text))).ToString();
                matrixAB4.Text = ((Convert.ToDouble(matrixA1.Text) * Convert.ToDouble(matrixB4.Text)) + (Convert.ToDouble(matrixA4.Text) * Convert.ToDouble(matrixB5.Text)) + (Convert.ToDouble(matrixA7.Text) * Convert.ToDouble(matrixB6.Text))).ToString();
                matrixAB7.Text = ((Convert.ToDouble(matrixA1.Text) * Convert.ToDouble(matrixB7.Text)) + (Convert.ToDouble(matrixA4.Text) * Convert.ToDouble(matrixB8.Text)) + (Convert.ToDouble(matrixA7.Text) * Convert.ToDouble(matrixB9.Text))).ToString();
                matrixAB2.Text = ((Convert.ToDouble(matrixA2.Text) * Convert.ToDouble(matrixB1.Text)) + (Convert.ToDouble(matrixA5.Text) * Convert.ToDouble(matrixB2.Text)) + (Convert.ToDouble(matrixA8.Text) * Convert.ToDouble(matrixB3.Text))).ToString();
                matrixAB5.Text = ((Convert.ToDouble(matrixA2.Text) * Convert.ToDouble(matrixB4.Text)) + (Convert.ToDouble(matrixA5.Text) * Convert.ToDouble(matrixB5.Text)) + (Convert.ToDouble(matrixA8.Text) * Convert.ToDouble(matrixB6.Text))).ToString();
                matrixAB8.Text = ((Convert.ToDouble(matrixA2.Text) * Convert.ToDouble(matrixB7.Text)) + (Convert.ToDouble(matrixA5.Text) * Convert.ToDouble(matrixB8.Text)) + (Convert.ToDouble(matrixA8.Text) * Convert.ToDouble(matrixB9.Text))).ToString();
                matrixAB3.Text = ((Convert.ToDouble(matrixA3.Text) * Convert.ToDouble(matrixB1.Text)) + (Convert.ToDouble(matrixA6.Text) * Convert.ToDouble(matrixB2.Text)) + (Convert.ToDouble(matrixA9.Text) * Convert.ToDouble(matrixB3.Text))).ToString();
                matrixAB6.Text = ((Convert.ToDouble(matrixA3.Text) * Convert.ToDouble(matrixB4.Text)) + (Convert.ToDouble(matrixA6.Text) * Convert.ToDouble(matrixB5.Text)) + (Convert.ToDouble(matrixA9.Text) * Convert.ToDouble(matrixB6.Text))).ToString();
                matrixAB9.Text = ((Convert.ToDouble(matrixA3.Text) * Convert.ToDouble(matrixB7.Text)) + (Convert.ToDouble(matrixA6.Text) * Convert.ToDouble(matrixB8.Text)) + (Convert.ToDouble(matrixA9.Text) * Convert.ToDouble(matrixB9.Text))).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка" + ex);
            }
        }
        //Данный метод производит сложение матриц
        private void MatricesS_Click(object sender, System.EventArgs e)
        {
            try
            {
               
                matrixAB1.Text = (Convert.ToDouble(matrixA1.Text) + Convert.ToDouble(matrixB1.Text)).ToString();
                matrixAB2.Text = (Convert.ToDouble(matrixA2.Text) + Convert.ToDouble(matrixB2.Text)).ToString();
                matrixAB3.Text = (Convert.ToDouble(matrixA3.Text) + Convert.ToDouble(matrixB3.Text)).ToString();
                matrixAB4.Text = (Convert.ToDouble(matrixA4.Text) + Convert.ToDouble(matrixB4.Text)).ToString();
                matrixAB5.Text = (Convert.ToDouble(matrixA5.Text) + Convert.ToDouble(matrixB5.Text)).ToString();
                matrixAB6.Text = (Convert.ToDouble(matrixA6.Text) + Convert.ToDouble(matrixB6.Text)).ToString();
                matrixAB7.Text = (Convert.ToDouble(matrixA7.Text) + Convert.ToDouble(matrixB7.Text)).ToString();
                matrixAB8.Text = (Convert.ToDouble(matrixA8.Text) + Convert.ToDouble(matrixB8.Text)).ToString();
                matrixAB9.Text = (Convert.ToDouble(matrixA9.Text) + Convert.ToDouble(matrixB9.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка" + ex);
            }
        }
        //Данный метод производит разность матриц
        private void MatricesD_Click(object sender, System.EventArgs e)
        {
            try
            {
               
                matrixAB1.Text = (Convert.ToDouble(matrixA1.Text) - Convert.ToDouble(matrixB1.Text)).ToString();
                matrixAB2.Text = (Convert.ToDouble(matrixA2.Text) - Convert.ToDouble(matrixB2.Text)).ToString();
                matrixAB3.Text = (Convert.ToDouble(matrixA3.Text) - Convert.ToDouble(matrixB3.Text)).ToString();
                matrixAB4.Text = (Convert.ToDouble(matrixA4.Text) - Convert.ToDouble(matrixB4.Text)).ToString();
                matrixAB5.Text = (Convert.ToDouble(matrixA5.Text) - Convert.ToDouble(matrixB5.Text)).ToString();
                matrixAB6.Text = (Convert.ToDouble(matrixA6.Text) - Convert.ToDouble(matrixB6.Text)).ToString();
                matrixAB7.Text = (Convert.ToDouble(matrixA7.Text) - Convert.ToDouble(matrixB7.Text)).ToString();
                matrixAB8.Text = (Convert.ToDouble(matrixA8.Text) - Convert.ToDouble(matrixB8.Text)).ToString();
                matrixAB9.Text = (Convert.ToDouble(matrixA9.Text) - Convert.ToDouble(matrixB9.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка:" + ex);
            }

        }

        //Данный метод меняет местами две матрицы
        private void MatricesChange_Click(object sender, System.EventArgs e)
        {
            try
            {
                string buffer = String.Empty;
                buffer = matrixA1.Text;
                matrixA1.Text = matrixB1.Text;
                matrixB1.Text = buffer;
                buffer = matrixA4.Text;
                matrixA4.Text = matrixB4.Text;
                matrixB4.Text = buffer;
                buffer = matrixA7.Text;
                matrixA7.Text = matrixB7.Text;
                matrixB7.Text = buffer;
                buffer = matrixA2.Text;
                matrixA2.Text = matrixB2.Text;
                matrixB2.Text = buffer;
                buffer = matrixA5.Text;
                matrixA5.Text = matrixB5.Text;
                matrixB5.Text = buffer;
                buffer = matrixA8.Text;
                matrixA8.Text = matrixB8.Text;
                matrixB8.Text = buffer;
                buffer = matrixA3.Text;
                matrixA3.Text = matrixB3.Text;
                matrixB3.Text = buffer;
                buffer = matrixA6.Text;
                matrixA6.Text = matrixB6.Text;
                matrixB6.Text = buffer;
                buffer = matrixA9.Text;
                matrixA9.Text = matrixB9.Text;
                matrixB9.Text = buffer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка:" + ex);
            }
        }

        //Данный метод транспонирует матрицу 1
        private void TransposeMatricesA_Click(object sender, EventArgs e)
        {
            try
            {
                string buffer = String.Empty;
                buffer = matrixA1.Text;
                matrixA1.Text = matrixA1.Text;
                matrixA1.Text = buffer;
                buffer = matrixA2.Text;
                matrixA2.Text = matrixA4.Text;
                matrixA4.Text = buffer;
                buffer = matrixA3.Text;
                matrixA3.Text = matrixA7.Text;
                matrixA7.Text = buffer;
                buffer = matrixA5.Text;
                matrixA5.Text = matrixA5.Text;
                matrixA5.Text = buffer;
                buffer = matrixA6.Text;
                matrixA6.Text = matrixA8.Text;
                matrixA8.Text = buffer;
                buffer = matrixA9.Text;
                matrixA9.Text = matrixA9.Text;
                matrixA9.Text = buffer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка:" + ex);
            }
        }
        //Данный метод транспонирует матрицу 2
        private void TransposeMatricesB_Click(object sender, EventArgs e)
        {
            try
            {
                string buffer = "";
                buffer = matrixB1.Text;
                matrixB1.Text = matrixB1.Text;
                matrixB1.Text = buffer;
                buffer = matrixB2.Text;
                matrixB2.Text = matrixB4.Text;
                matrixB4.Text = buffer;
                buffer = matrixB3.Text;
                matrixB3.Text = matrixB7.Text;
                matrixB7.Text = buffer;
                buffer = matrixB5.Text;
                matrixB5.Text = matrixB5.Text;
                matrixB5.Text = buffer;
                buffer = matrixB6.Text;
                matrixB6.Text = matrixB8.Text;
                matrixB8.Text = buffer;
                buffer = matrixB9.Text;
                matrixB9.Text = matrixB9.Text;
                matrixB9.Text = buffer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка:" + ex);
            }
        }
    

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Данный метод находит определитель матрицы 1
        private void OpredelitelButton_Click(object sender, EventArgs e)
        {
            try
            {
                matrixAB5.Text = Convert.ToString((Convert.ToDouble(matrixA1.Text)
                                                   * Convert.ToDouble(matrixA5.Text)
                                                   * Convert.ToDouble(matrixA9.Text))
                                                  + (Convert.ToDouble(matrixA3.Text)
                                                     * Convert.ToDouble(matrixA4.Text)
                                                     * Convert.ToDouble(matrixA8.Text))
                                                  + (Convert.ToDouble(matrixA7.Text)
                                                     * Convert.ToDouble(matrixA2.Text)
                                                     * Convert.ToDouble(matrixA6.Text))
                                                  - (Convert.ToDouble(matrixA3.Text)
                                                     * Convert.ToDouble(matrixA5.Text)
                                                     * Convert.ToDouble(matrixA7.Text))
                                                  - (Convert.ToDouble(matrixA1.Text)
                                                     * Convert.ToDouble(matrixA6.Text)
                                                     * Convert.ToDouble(matrixA8.Text))
                                                  - (Convert.ToDouble(matrixA4.Text)
                                                     * Convert.ToDouble(matrixA2.Text)
                                                     * Convert.ToDouble(matrixA9.Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex);
            }

        }
        //Данный метод находит определитель матрицы 2
        private void OpredelitelButton1_Click(object sender, EventArgs e)
        {
            try
            {
                matrixAB5.Text = Convert.ToString((Convert.ToDouble(matrixB1.Text)
                                                   * Convert.ToDouble(matrixB5.Text)
                                                   * Convert.ToDouble(matrixB9.Text))
                                                  + (Convert.ToDouble(matrixB3.Text)
                                                     * Convert.ToDouble(matrixB4.Text)
                                                     * Convert.ToDouble(matrixB8.Text))
                                                  + (Convert.ToDouble(matrixB7.Text)
                                                     * Convert.ToDouble(matrixB2.Text)
                                                     * Convert.ToDouble(matrixB6.Text))
                                                  - (Convert.ToDouble(matrixB3.Text)
                                                     * Convert.ToDouble(matrixB5.Text)
                                                     * Convert.ToDouble(matrixB7.Text))
                                                  - (Convert.ToDouble(matrixB1.Text)
                                                     * Convert.ToDouble(matrixB6.Text)
                                                     * Convert.ToDouble(matrixB8.Text))
                                                  - (Convert.ToDouble(matrixB4.Text)
                                                     * Convert.ToDouble(matrixB2.Text)
                                                     * Convert.ToDouble(matrixB9.Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex);
            }
        }

        private void matrixAB5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}