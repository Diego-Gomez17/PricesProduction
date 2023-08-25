namespace Prices
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            Neto = new DataGridViewTextBoxColumn();
            desc1 = new DataGridViewTextBoxColumn();
            desc2 = new DataGridViewTextBoxColumn();
            desc3 = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            clear = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(116, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(221, 229);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(116, 142);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(116, 171);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(180, 23);
            textBox3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 113);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 4;
            label1.Text = "Insumos";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 142);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 5;
            label2.Text = "Valor Hora";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 174);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 6;
            label3.Text = "Cantidad de Horas";
            label3.Click += label3_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(116, 200);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(180, 23);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 200);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 8;
            label4.Text = "Otros costos";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Neto, desc1, desc2, desc3 });
            dataGridView1.Location = new Point(314, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(443, 139);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Neto
            // 
            Neto.HeaderText = "neto";
            Neto.Name = "Neto";
            Neto.ReadOnly = true;
            // 
            // desc1
            // 
            desc1.HeaderText = "Desc1 15%";
            desc1.Name = "desc1";
            desc1.ReadOnly = true;
            // 
            // desc2
            // 
            desc2.HeaderText = "Desc2 %30";
            desc2.Name = "desc2";
            desc2.ReadOnly = true;
            // 
            // desc3
            // 
            desc3.HeaderText = "Desc3 45%";
            desc3.Name = "desc3";
            desc3.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // clear
            // 
            clear.Location = new Point(116, 229);
            clear.Name = "clear";
            clear.Size = new Size(75, 23);
            clear.TabIndex = 10;
            clear.Text = "Limpiar";
            clear.UseVisualStyleBackColor = true;
            clear.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(clear);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip1;
        private DataGridViewTextBoxColumn Neto;
        private DataGridViewTextBoxColumn desc1;
        private DataGridViewTextBoxColumn desc2;
        private DataGridViewTextBoxColumn desc3;
        private Button clear;
    }
}