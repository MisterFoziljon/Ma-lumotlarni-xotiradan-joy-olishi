using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _3_project
{ 
    public partial class Form1 : Form
    {
        private string[,] data;
        public static string path=@"C:\Users\Azure AI\Desktop\Foziljon\Dasturlash asoslari\Dasturlar\Tizimli\3_project\textpad.txt";
        public Form1()
        {
            InitializeComponent();
        }
        public int indexOfdata(string name)
        {
            List<string> nomlar = new List<string>();
            data = dataset(path);

            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i, 0].StartsWith(name))
                {
                    nomlar.Add(data[i, 0]);
                }
            }
            nomlar.Sort();

            string[] nom = nomlar.ToArray();

            for (int i = 1; i <=nomlar.Count; i++)
            {
                string x = name + i.ToString();

                if (!nomlar.Contains(x))
                {
                    return i;
                }
            }
            return nom.Length + 1;
        }

        public string[,] dataset(string path)
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
        private void txt_Click(object sender, EventArgs e)
        {
            int index = indexOfdata("textpad");
            File.AppendAllText(path, "textpad" + index + "-*.txt-0-0"+"\n");
            data = dataset(path);
            dataGridView1.RowCount=data.GetLength(0);
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = data[i, j];
                }
            }

            textbox text = new textbox("textpad"+index,"*.txt","");
            text.Show();
        }
        private void apk_Click(object sender, EventArgs e)
        {
            int index = indexOfdata("untitled");
            
            Paint paint = new Paint("untitled"+index,"*.jpg");
            paint.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            data = dataset(path);
            dataGridView1.Rows.Clear();
            dataGridView1.RowCount = data.GetLength(0);
            for (int i = 0; i < data.GetLength(0); i++)
                for (int j = 0; j < data.GetLength(1); j++)
                    dataGridView1.Rows[i].Cells[j].Value = data[i, j];
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            button2.BackgroundImage = Image.FromFile(@"C:\Users\Azure AI\Desktop\Foziljon\Dasturlash asoslari\Dasturlar\Tizimli\Last_project\empty.png");
            if (File.Exists(path))
                File.Delete(path);

            File.AppendAllText(path, "");

            data = dataset(path);
            dataGridView1.Rows.Clear ();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].Cells[0].Value.ToString() != "")
            {
                dataGridView1.SelectedRows[0].Cells[0].Value = "";
                dataGridView1.SelectedRows[0].Cells[1].Value = "";
                dataGridView1.SelectedRows[0].Cells[2].Value = "";
                dataGridView1.SelectedRows[0].Cells[3].Value = "";

                button2.BackgroundImage = Image.FromFile(@"C:\Users\Azure AI\Desktop\Foziljon\Dasturlash asoslari\Dasturlar\Tizimli\Last_project\trash.png");
                data = new string[dataGridView1.RowCount - 1, 4];
                int iter = 0;
                for(int i=0;i<dataGridView1.RowCount;i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value == "")
                        continue;
                    data[iter,0]=dataGridView1.Rows[i].Cells[0].Value.ToString();
                    data[iter, 1] = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    data[iter, 2] = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    data[iter, 3] = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    iter++;
                }

                dataGridView1.Rows.Clear();
                dataGridView1.RowCount = data.GetLength(0);

                if (File.Exists(path))
                    File.Delete(path);

                for (int i=0;i<data.GetLength(0);i++)
                {
                    File.AppendAllText(path, data[i,0]+"-"+data[i,1]+"-"+data[i,2]+"-"+data[i,3] + "\n");
                    dataGridView1.Rows[i].Cells[0].Value = data[i, 0];
                    dataGridView1.Rows[i].Cells[1].Value = data[i, 1];
                    dataGridView1.Rows[i].Cells[2].Value = data[i, 2];
                    dataGridView1.Rows[i].Cells[3].Value = data[i, 3];
                }
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()=="*.txt")
            {
                textbox text = new textbox(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), "*.txt", dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                text.Show();
            }
        }
    }
}
