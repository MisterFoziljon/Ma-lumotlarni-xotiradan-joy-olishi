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
    public partial class Paint : Form
    {
        public string name;
        public string format;

        public Paint(string name,string format)
        {
            this.name = name;
            this.format = format;

            InitializeComponent();
            SetUlcham();
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 60;
            dataGridView1.Columns[2].Width = 60;
        }

        private class Nuqtalar_massivi
        {
            private int index = 0;
            private Point[] nuqtalar;

            public Nuqtalar_massivi(int ulcham)
            {
                if (ulcham <= 0)
                    ulcham = 2;
                nuqtalar = new Point[ulcham];
            }

            public void SetNuqta(int x, int y)
            {
                if (index >= nuqtalar.Length)
                    index = 0;

                nuqtalar[index] = new Point(x, y);
                index++;
            }

            public void ResetNuqtalar()
            {
                index = 0;
            }

            public int GetNuqtalarSoni()
            {
                return index;
            }

            public Point[] GetNuqtalar()
            {
                return nuqtalar;
            }

        }

        private bool sichqon = false;
        private Nuqtalar_massivi nuqtalar_massivi = new Nuqtalar_massivi(2);

        Bitmap map = new Bitmap(100, 100);
        Graphics grafika;

        Pen qalam = new Pen(Color.Black,3f);
        double xotira = 0;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            sichqon = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            sichqon = false;
            nuqtalar_massivi.ResetNuqtalar();
        }
        //private string get_color_code(Color color)
        //{
        //    int red = color.R;
        //    int green = color.G;
        //    int blue = color.B;
        //    int a = color.A;
        //    string color_code = "";
        //    int index_b = color.ToString().IndexOf('[');
        //    int index_e = color.ToString().IndexOf(']');
        //    for (int i = index_b + 1; i < index_e; i++)
        //        color_code += color.ToString()[i];
        //    return red + ";" + green + ";" + blue;
        //}

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!sichqon)
                return;
            

            nuqtalar_massivi.SetNuqta(e.X, e.Y);
            if (nuqtalar_massivi.GetNuqtalarSoni() >= 2)
            {
                grafika.DrawLines(qalam, nuqtalar_massivi.GetNuqtalar());
                pictureBox1.Image = map;
                nuqtalar_massivi.SetNuqta(e.X, e.Y);

                string coordinate = "( " + e.X + ";" + e.Y + " )";
                string color=qalam.Color.Name;

                dataGridView1.Rows.Add(coordinate, color, qalam.Width);
                xotira += qalam.Width;
            }
        }

        private void Gray_Click(object sender, EventArgs e)
        {
            qalam.Color = ((Button)sender).BackColor;
        }

        private void Palitra_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                qalam.Color = colorDialog1.Color;
                ((Button)sender).BackColor = colorDialog1.Color;
            }
        }

        private void Tozalash_Click(object sender, EventArgs e)
        {
            grafika.Clear(pictureBox1.BackColor);
            dataGridView1.Rows.Clear();
            pictureBox1.Image = map;
        }

        private void Saqlash_Click(object sender, EventArgs e)
        {
            Form2 form2=new Form2(name,format,xotira);
            form2.ShowDialog();
        }

        private void SetUlcham()
        {
            Rectangle turtburchak = Screen.PrimaryScreen.Bounds;
            map = new Bitmap(turtburchak.Width, turtburchak.Height);
            grafika = Graphics.FromImage(map);
            qalam.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            qalam.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        //private int color_adres(string color_code)
        //{
        //    int xotira = 0;
        //    if (color_code == "0;0;0" || color_code == "255;255;255")
        //        xotira = 8;
        //    else if (color_code == "128;128;128")
        //        xotira = 16;
        //    else
        //        xotira = 24;
        //    return xotira;
        //}
        //private string Color_hex_code(string color)
        //{
        //    int r = Convert.ToInt32(color.Split(';')[0]);
        //    int g = Convert.ToInt32(color.Split(';')[1]);
        //    int b = Convert.ToInt32(color.Split(';')[2]);
        //    Format format = new Format();
        //    string red = format.dec_to_hex(r);
        //    string green = format.dec_to_hex(g);
        //    string blue = format.dec_to_hex(b);

        //    return "#" + red + "" + green + "" + blue;
        //    //return r + "" + g + "" + b;
        //}

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            qalam.Width = trackBar1.Value;
        }
    }
}
