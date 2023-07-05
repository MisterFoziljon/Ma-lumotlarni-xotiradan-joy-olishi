using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace _3_project
{
    public partial class Form2 : Form
    {
        private static string path = @"C:\Users\Azure AI\Desktop\Foziljon\Dasturlash asoslari\Dasturlar\Tizimli\3_project\textpad.txt";
        private string text;
        private string name;
        private string format;
        private double xotira;
        
        public Form2(string text,string name,string format)
        {
            InitializeComponent();

            this.text=text;
            this.name=name; 
            this.format=format;

            comboBox1.Items.Insert(0, "*.txt");

            textBox1.Text = name;
            comboBox1.Text = format;
            string[,] matrix = dataset();

            dataGridView1.RowCount = matrix.GetLength(0);

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    dataGridView1.Rows[i].Cells[j].Value = matrix[i, j];
        }

        public Form2(string name, string format,double xotira)
        {
            InitializeComponent();

            this.name = name;
            this.format = format;
            this.xotira = xotira;

            comboBox1.Items.Insert(0, "*.jpg");
            comboBox1.Items.Insert(0, "*.png");

            textBox1.Text = name;
            comboBox1.Text = format;
            string[,] matrix = dataset();

            if(matrix.GetLength(0)!=0)
            {
                dataGridView1.RowCount = matrix.GetLength(0);
                for (int i = 0; i < matrix.GetLength(0); i++)
                    for (int j = 0; j < matrix.GetLength(1); j++)
                        dataGridView1.Rows[i].Cells[j].Value = matrix[i, j];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[,] matrix = dataset();
            string faylnomi = textBox1.Text;
            string faylkengaytmasi = comboBox1.Text;

            if (matrix.GetLength(0) == 0)
                File.AppendAllText(path, name + "-" + format + "-" + xotira + "-0\n");

            else if (faylnomi.Length == 0)
                MessageBox.Show("Fayl nomi kiritilmadi!");

            else if (faylkengaytmasi == "")
                MessageBox.Show("Fayl kengaytmasi tanlanmadi!");

            else
            {
                if (faylkengaytmasi == "*.txt")
                {
                    bool uzgardi = true;
                    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
                    {
                        if (matrix[i, 0] == faylnomi && matrix[i, 1] == faylkengaytmasi)
                        {
                            MessageBox.Show(matrix[i, 0] + "-" + faylnomi + "\t" + matrix[i, 1] + "-" + faylkengaytmasi);
                            string message = "Bunday fayl mavjud.Qayta tahrirlansinmi?";
                            string caption = "Ogohlantirish!!!";
                            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                            DialogResult result;

                            result = MessageBox.Show(this, message, caption, buttons,
                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RightAlign);

                            if (result == DialogResult.OK)
                            {
                                uzgardi = false;
                                matrix[i, 0] = faylnomi;
                                matrix[i, 1] = faylkengaytmasi;
                                matrix[i, 2] = text.Length.ToString();
                                matrix[i, 3] = text;

                                matrix[matrix.GetLength(0) - 1, 2] = "0";
                                matrix[matrix.GetLength(0) - 1, 3] = "";

                                if (File.Exists(path))
                                {
                                    File.Delete(path);
                                }

                                for (int i1 = 0; i1 < matrix.GetLength(0); i1++)
                                    File.AppendAllText(path, matrix[i1, 0] + "-" + matrix[i1, 1] + "-" + matrix[i1, 2] + "-" + matrix[i1, 3] + "\n");

                                dataGridView1.Rows.Clear();
                                dataGridView1.RowCount = matrix.GetLength(0);

                                for (int i1 = 0; i1 < matrix.GetLength(0); i1++)
                                    for (int j = 0; j < matrix.GetLength(1); j++)
                                        dataGridView1.Rows[i1].Cells[j].Value = matrix[i1, j];

                                matrix = new string[dataGridView1.Rows.Count, 4];

                                for (int j = 0; j < matrix.GetLength(0); j++)
                                {
                                    matrix[j, 0] = dataGridView1.Rows[j].Cells[0].Value.ToString();
                                    matrix[j, 1] = dataGridView1.Rows[j].Cells[1].Value.ToString();
                                    matrix[j, 2] = dataGridView1.Rows[j].Cells[2].Value.ToString();
                                    matrix[j, 3] = dataGridView1.Rows[j].Cells[3].Value.ToString();
                                }
                                break;
                            }

                            if (result == DialogResult.Cancel)
                                uzgardi = false;
                        }
                    }

                    if (uzgardi)
                    {
                        if (File.Exists(path))
                            File.Delete(path);

                        int rows = matrix.GetLength(0);

                        for (int i = 0; i < rows; i++)
                            if (matrix[i, 0] == name && matrix[i, 1] == format)
                            {
                                matrix[i, 0] = faylnomi;
                                matrix[i, 1] = faylkengaytmasi;
                                if (faylkengaytmasi == "*.txt")
                                {
                                    matrix[i, 2] = text.Length.ToString();
                                    matrix[i, 3] = text;
                                }

                                else
                                {
                                    matrix[i, 3] = "";
                                }
                            }

                        dataGridView1.Rows.Clear();
                        dataGridView1.RowCount = rows;
                        for (int i = 0; i < rows; i++)
                            File.AppendAllText(path, matrix[i, 0] + "-" + matrix[i, 1] + "-" + matrix[i, 2] + "-" + matrix[i, 3] + "\n");

                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                dataGridView1.Rows[i].Cells[j].Value = matrix[i, j];
                            }
                        }
                        this.Close();
                    }
                }

                else
                {
                    File.AppendAllText(path, faylnomi + "-" + faylkengaytmasi + "-" + xotira + "-0\n");
                   /**/
                    this.Close();
                }
            }
        }
        public string [,] dataset()
        {
            string[] lines = File.ReadAllLines(path);
            string[] liner = new string[lines.Length];

            string[,] matrix = new string[liner.Length, 4];
            int iter = 0;
            foreach (string line in lines)
            {
                string[] line_data = line.Split('-');
                for (int i = 0; i < 4; i++)
                {
                    matrix[iter, i] = line_data[i];
                }
                iter++;
            }
            return matrix;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text=dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
