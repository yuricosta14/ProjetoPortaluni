namespace ProjetoPortaluni.View.Alunos
{
    partial class frmBoletim
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            lblSupContato = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-57, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(824, 89);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(69, 34);
            label1.Name = "label1";
            label1.Size = new Size(87, 30);
            label1.TabIndex = 0;
            label1.Text = "Boletim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 145);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome Completo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(329, 145);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 3;
            label3.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(570, 145);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 4;
            label4.Text = "Serie";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 163);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(275, 23);
            textBox1.TabIndex = 5;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(329, 163);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(217, 23);
            maskedTextBox1.TabIndex = 6;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(570, 163);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(154, 23);
            maskedTextBox2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 226);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(717, 310);
            dataGridView1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(579, 197);
            button1.Name = "button1";
            button1.Size = new Size(134, 23);
            button1.TabIndex = 9;
            button1.Text = "Visualizar";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblSupContato
            // 
            lblSupContato.AutoSize = true;
            lblSupContato.BackColor = Color.Transparent;
            lblSupContato.Location = new Point(329, 541);
            lblSupContato.Name = "lblSupContato";
            lblSupContato.Size = new Size(103, 15);
            lblSupContato.TabIndex = 15;
            lblSupContato.Text = "Suporte e Contato";
            // 
            // frmBoletim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 571);
            Controls.Add(lblSupContato);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "frmBoletim";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private DataGridView dataGridView1;
        private Button button1;
        private Label lblSupContato;
    }
}