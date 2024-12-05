namespace ControleDeEstoque
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bradley Hand ITC", 12F, FontStyle.Bold);
            label1.Location = new Point(65, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 0;
            label1.Text = "PRODUTO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bradley Hand ITC", 12F, FontStyle.Bold);
            label2.Location = new Point(65, 86);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(152, 25);
            label2.TabIndex = 1;
            label2.Text = "QUANTIDADE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bradley Hand ITC", 12F, FontStyle.Bold);
            label3.Location = new Point(70, 146);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 2;
            label3.Text = "PREÇO:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(266, 30);
            textBox1.Margin = new Padding(4, 2, 4, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 26);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(266, 84);
            textBox2.Margin = new Padding(4, 2, 4, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 26);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(266, 144);
            textBox3.Margin = new Padding(4, 2, 4, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(155, 26);
            textBox3.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Bradley Hand ITC", 9F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(65, 218);
            button1.Margin = new Padding(4, 2, 4, 2);
            button1.Name = "button1";
            button1.Size = new Size(146, 46);
            button1.TabIndex = 6;
            button1.Text = "adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Bradley Hand ITC", 9F, FontStyle.Bold | FontStyle.Italic);
            button2.Location = new Point(245, 218);
            button2.Margin = new Padding(4, 2, 4, 2);
            button2.Name = "button2";
            button2.Size = new Size(146, 46);
            button2.TabIndex = 7;
            button2.Text = "editar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Bradley Hand ITC", 9F, FontStyle.Bold | FontStyle.Italic);
            button3.Location = new Point(410, 218);
            button3.Margin = new Padding(4, 2, 4, 2);
            button3.Name = "button3";
            button3.Size = new Size(146, 46);
            button3.TabIndex = 8;
            button3.Text = "remover";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Bradley Hand ITC", 9F, FontStyle.Bold | FontStyle.Italic);
            button4.Location = new Point(581, 218);
            button4.Margin = new Padding(4, 2, 4, 2);
            button4.Name = "button4";
            button4.Size = new Size(146, 46);
            button4.TabIndex = 9;
            button4.Text = "pesquisar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Bradley Hand ITC", 9F, FontStyle.Bold | FontStyle.Italic);
            button5.Location = new Point(778, 218);
            button5.Margin = new Padding(4, 2, 4, 2);
            button5.Name = "button5";
            button5.Size = new Size(146, 46);
            button5.TabIndex = 10;
            button5.Text = "limpar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 388);
            dataGridView1.Margin = new Padding(4, 2, 4, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(978, 179);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bradley Hand ITC", 24F);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(530, 30);
            label4.Name = "label4";
            label4.Size = new Size(234, 50);
            label4.TabIndex = 12;
            label4.Text = "CONTROLE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bradley Hand ITC", 24F);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(656, 80);
            label5.Name = "label5";
            label5.Size = new Size(71, 50);
            label5.TabIndex = 13;
            label5.Text = "DE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bradley Hand ITC", 24F);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(694, 130);
            label6.Name = "label6";
            label6.Size = new Size(209, 50);
            label6.TabIndex = 14;
            label6.Text = "ESTOQUE";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 598);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Bradley Hand ITC", 9F, FontStyle.Bold | FontStyle.Italic);
            ForeColor = Color.Blue;
            Margin = new Padding(4, 2, 4, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
