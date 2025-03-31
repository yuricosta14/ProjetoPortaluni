namespace ProjetoPortaluni.View.Professor
{
    partial class frmFrequencia
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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblData = new Label();
            maskedDataFreq = new MaskedTextBox();
            lblSupContato = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-6, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(861, 96);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 40);
            label1.Name = "label1";
            label1.Size = new Size(231, 30);
            label1.TabIndex = 0;
            label1.Text = "FREQUÊNCIA ALUNOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(380, 169);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome do aluno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(402, 247);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 2;
            label3.Text = "Serie";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(402, 379);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 3;
            label4.Text = "Falta";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(156, 198);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(519, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(156, 274);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(519, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(156, 397);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(519, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(156, 465);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(519, 23);
            textBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(380, 447);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 8;
            label5.Text = "Justificativa";
            // 
            // button1
            // 
            button1.Location = new Point(323, 557);
            button1.Name = "button1";
            button1.Size = new Size(186, 23);
            button1.TabIndex = 9;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(403, 317);
            lblData.Name = "lblData";
            lblData.Size = new Size(31, 15);
            lblData.TabIndex = 10;
            lblData.Text = "Data";
            // 
            // maskedDataFreq
            // 
            maskedDataFreq.Location = new Point(156, 335);
            maskedDataFreq.Mask = "00/00/0000";
            maskedDataFreq.Name = "maskedDataFreq";
            maskedDataFreq.Size = new Size(519, 23);
            maskedDataFreq.TabIndex = 12;
            maskedDataFreq.TextAlign = HorizontalAlignment.Center;
            maskedDataFreq.ValidatingType = typeof(DateTime);
            // 
            // lblSupContato
            // 
            lblSupContato.AutoSize = true;
            lblSupContato.BackColor = Color.Transparent;
            lblSupContato.Location = new Point(367, 583);
            lblSupContato.Name = "lblSupContato";
            lblSupContato.Size = new Size(103, 15);
            lblSupContato.TabIndex = 15;
            lblSupContato.Text = "Suporte e Contato";
            // 
            // frmFrequencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 627);
            Controls.Add(lblSupContato);
            Controls.Add(maskedDataFreq);
            Controls.Add(lblData);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "frmFrequencia";
            Text = "Form4";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblData;
        private TextBox textBox5;
        private MaskedTextBox maskedDataFreq;
        private Label lblSupContato;
    }
}