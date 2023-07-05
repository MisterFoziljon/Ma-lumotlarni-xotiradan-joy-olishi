namespace _3_project
{
    partial class Paint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Red = new System.Windows.Forms.Button();
            this.Green = new System.Windows.Forms.Button();
            this.Blue = new System.Windows.Forms.Button();
            this.Black = new System.Windows.Forms.Button();
            this.Palitra = new System.Windows.Forms.Button();
            this.Gray = new System.Windows.Forms.Button();
            this.Brown = new System.Windows.Forms.Button();
            this.Yellow = new System.Windows.Forms.Button();
            this.Tozalash = new System.Windows.Forms.Button();
            this.Saqlash = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(897, 692);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.Location = new System.Drawing.Point(916, 395);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(50, 50);
            this.Red.TabIndex = 1;
            this.Red.UseVisualStyleBackColor = false;
            this.Red.Click += new System.EventHandler(this.Gray_Click);
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.Green;
            this.Green.Location = new System.Drawing.Point(972, 395);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(50, 50);
            this.Green.TabIndex = 2;
            this.Green.UseVisualStyleBackColor = false;
            this.Green.Click += new System.EventHandler(this.Gray_Click);
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.Blue;
            this.Blue.Location = new System.Drawing.Point(1028, 395);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(50, 50);
            this.Blue.TabIndex = 3;
            this.Blue.UseVisualStyleBackColor = false;
            this.Blue.Click += new System.EventHandler(this.Gray_Click);
            // 
            // Black
            // 
            this.Black.BackColor = System.Drawing.Color.Black;
            this.Black.Location = new System.Drawing.Point(1084, 395);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(50, 50);
            this.Black.TabIndex = 4;
            this.Black.UseVisualStyleBackColor = false;
            this.Black.Click += new System.EventHandler(this.Gray_Click);
            // 
            // Palitra
            // 
            this.Palitra.BackColor = System.Drawing.Color.White;
            this.Palitra.Location = new System.Drawing.Point(1084, 451);
            this.Palitra.Name = "Palitra";
            this.Palitra.Size = new System.Drawing.Size(50, 50);
            this.Palitra.TabIndex = 8;
            this.Palitra.Text = "P";
            this.Palitra.UseVisualStyleBackColor = false;
            this.Palitra.Click += new System.EventHandler(this.Palitra_Click);
            // 
            // Gray
            // 
            this.Gray.BackColor = System.Drawing.Color.Gray;
            this.Gray.Location = new System.Drawing.Point(1028, 451);
            this.Gray.Name = "Gray";
            this.Gray.Size = new System.Drawing.Size(50, 50);
            this.Gray.TabIndex = 7;
            this.Gray.UseVisualStyleBackColor = false;
            this.Gray.Click += new System.EventHandler(this.Gray_Click);
            // 
            // Brown
            // 
            this.Brown.BackColor = System.Drawing.Color.Brown;
            this.Brown.Location = new System.Drawing.Point(972, 451);
            this.Brown.Name = "Brown";
            this.Brown.Size = new System.Drawing.Size(50, 50);
            this.Brown.TabIndex = 6;
            this.Brown.UseVisualStyleBackColor = false;
            this.Brown.Click += new System.EventHandler(this.Gray_Click);
            // 
            // Yellow
            // 
            this.Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Yellow.Location = new System.Drawing.Point(916, 451);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(50, 50);
            this.Yellow.TabIndex = 5;
            this.Yellow.UseVisualStyleBackColor = false;
            this.Yellow.Click += new System.EventHandler(this.Gray_Click);
            // 
            // Tozalash
            // 
            this.Tozalash.Location = new System.Drawing.Point(916, 598);
            this.Tozalash.Name = "Tozalash";
            this.Tozalash.Size = new System.Drawing.Size(218, 40);
            this.Tozalash.TabIndex = 9;
            this.Tozalash.Text = "Tozalash";
            this.Tozalash.UseVisualStyleBackColor = true;
            this.Tozalash.Click += new System.EventHandler(this.Tozalash_Click);
            // 
            // Saqlash
            // 
            this.Saqlash.Location = new System.Drawing.Point(916, 644);
            this.Saqlash.Name = "Saqlash";
            this.Saqlash.Size = new System.Drawing.Size(218, 40);
            this.Saqlash.TabIndex = 10;
            this.Saqlash.Text = "Saqlash";
            this.Saqlash.UseVisualStyleBackColor = true;
            this.Saqlash.Click += new System.EventHandler(this.Saqlash_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(895, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(256, 378);
            this.dataGridView1.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Koordinata";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Rang";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Qalinlik";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(916, 522);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(218, 56);
            this.trackBar1.TabIndex = 12;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 696);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Saqlash);
            this.Controls.Add(this.Tozalash);
            this.Controls.Add(this.Palitra);
            this.Controls.Add(this.Gray);
            this.Controls.Add(this.Brown);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.Black);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Paint";
            this.Text = "Paint";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Button Green;
        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Button Black;
        private System.Windows.Forms.Button Palitra;
        private System.Windows.Forms.Button Gray;
        private System.Windows.Forms.Button Brown;
        private System.Windows.Forms.Button Yellow;
        private System.Windows.Forms.Button Tozalash;
        private System.Windows.Forms.Button Saqlash;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}