namespace ProjetoPortaluni.View.Alunos
{
    partial class frmFreq
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
            lblSupContato = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblSupContato
            // 
            lblSupContato.AutoSize = true;
            lblSupContato.BackColor = Color.Transparent;
            lblSupContato.Location = new Point(347, 556);
            lblSupContato.Name = "lblSupContato";
            lblSupContato.Size = new Size(103, 15);
            lblSupContato.TabIndex = 24;
            lblSupContato.Text = "Suporte e Contato";
            // 
            // button1
            // 
            button1.Location = new Point(597, 212);
            button1.Name = "button1";
            button1.Size = new Size(134, 23);
            button1.TabIndex = 23;
            button1.Text = "Visualizar";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(43, 241);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(717, 310);
            dataGridView1.TabIndex = 22;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(588, 178);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(154, 23);
            maskedTextBox2.TabIndex = 21;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(347, 178);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(217, 23);
            maskedTextBox1.TabIndex = 20;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(43, 178);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(275, 23);
            textBox1.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(588, 160);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 18;
            label4.Text = "Serie";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(347, 160);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 17;
            label3.Text = "CPF";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 160);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 16;
            label2.Text = "Nome Completo";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-6, -11);
            panel1.Name = "panel1";
            panel1.Size = new Size(824, 98);
            panel1.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 38);
            label1.Name = "label1";
            label1.Size = new Size(119, 30);
            label1.TabIndex = 0;
            label1.Text = "Frequência";
            // 
            // frmFreq
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 592);
            Controls.Add(panel1);
            Controls.Add(lblSupContato);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "frmFreq";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSupContato;
        private Button button1;
        private DataGridView dataGridView1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label1;
    }
}