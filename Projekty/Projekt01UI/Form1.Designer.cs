﻿namespace Projekt01UI
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
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            textBox5 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            openFileDialog1 = new OpenFileDialog();
            dataGridView1 = new DataGridView();
            zapisBinarny = new DataGridViewTextBoxColumn();
            zapisDziesietny = new DataGridViewTextBoxColumn();
            symbol = new DataGridViewTextBoxColumn();
            czestosc = new DataGridViewTextBoxColumn();
            prawdopodobienstwo = new DataGridViewTextBoxColumn();
            iloscInformacji = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(163, 28);
            label1.TabIndex = 0;
            label1.Text = "Tekst wejciowy";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(634, 43);
            label2.Name = "label2";
            label2.Size = new Size(145, 15);
            label2.TabIndex = 1;
            label2.Text = "Liczba wszystkich znaków:";
            label2.UseWaitCursor = true;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(634, 103);
            label3.Name = "label3";
            label3.Size = new Size(157, 15);
            label3.TabIndex = 2;
            label3.Text = "Liczba unikatowych znaków:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(634, 157);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Entropia:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(634, 214);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(634, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(634, 121);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(154, 23);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(634, 175);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(154, 23);
            textBox3.TabIndex = 7;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 40);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(616, 78);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.OrangeRed;
            button1.Location = new Point(634, 356);
            button1.Name = "button1";
            button1.Size = new Size(154, 82);
            button1.TabIndex = 10;
            button1.Text = "PRZEPROWADŹ ANALIZĘ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(634, 327);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(154, 23);
            textBox5.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(634, 309);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 12;
            label6.Text = "Czas wykonania";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 121);
            label7.Name = "label7";
            label7.Size = new Size(121, 28);
            label7.TabIndex = 13;
            label7.Text = "Statystyka:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { zapisBinarny, zapisDziesietny, symbol, czestosc, prawdopodobienstwo, iloscInformacji });
            dataGridView1.Location = new Point(12, 152);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(616, 286);
            dataGridView1.TabIndex = 14;
            // 
            // zapisBinarny
            // 
            zapisBinarny.HeaderText = "Zapis binarny";
            zapisBinarny.Name = "zapisBinarny";
            // 
            // zapisDziesietny
            // 
            zapisDziesietny.HeaderText = "Zapis dziesiętny";
            zapisDziesietny.Name = "zapisDziesietny";
            // 
            // symbol
            // 
            symbol.HeaderText = "Symbol";
            symbol.Name = "symbol";
            // 
            // czestosc
            // 
            czestosc.HeaderText = "Częstość";
            czestosc.Name = "czestosc";
            // 
            // prawdopodobienstwo
            // 
            prawdopodobienstwo.HeaderText = "Prawdopodobieństwo";
            prawdopodobienstwo.Name = "prawdopodobienstwo";
            // 
            // iloscInformacji
            // 
            iloscInformacji.HeaderText = "Ilość informacji";
            iloscInformacji.Name = "iloscInformacji";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private RichTextBox richTextBox1;
        private Button button1;
        private TextBox textBox5;
        private Label label6;
        private Label label7;
        private OpenFileDialog openFileDialog1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn zapisBinarny;
        private DataGridViewTextBoxColumn zapisDziesietny;
        private DataGridViewTextBoxColumn symbol;
        private DataGridViewTextBoxColumn czestosc;
        private DataGridViewTextBoxColumn prawdopodobienstwo;
        private DataGridViewTextBoxColumn iloscInformacji;
    }
}