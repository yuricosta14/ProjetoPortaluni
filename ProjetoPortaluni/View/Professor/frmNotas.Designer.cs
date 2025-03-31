namespace ProjetoPortaluni.View.Professor
{
    partial class frmNotas
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
            lblSupContato = new Label();
            button1 = new Button();
            lblJustificativa = new Label();
            txtJustificativa = new TextBox();
            txtNota = new TextBox();
            txtSerie = new TextBox();
            txtNomeAluno = new TextBox();
            lblNota = new Label();
            lblSerie = new Label();
            lblNomeAluno = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-4, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(873, 103);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 40);
            label1.Name = "label1";
            label1.Size = new Size(159, 30);
            label1.TabIndex = 0;
            label1.Text = "NOTA ALUNOS";
            // 
            // lblSupContato
            // 
            lblSupContato.AutoSize = true;
            lblSupContato.BackColor = Color.Transparent;
            lblSupContato.Location = new Point(356, 579);
            lblSupContato.Name = "lblSupContato";
            lblSupContato.Size = new Size(103, 15);
            lblSupContato.TabIndex = 27;
            lblSupContato.Text = "Suporte e Contato";
            // 
            // button1
            // 
            button1.Location = new Point(312, 553);
            button1.Name = "button1";
            button1.Size = new Size(186, 23);
            button1.TabIndex = 24;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblJustificativa
            // 
            lblJustificativa.AutoSize = true;
            lblJustificativa.Location = new Point(378, 406);
            lblJustificativa.Name = "lblJustificativa";
            lblJustificativa.Size = new Size(68, 15);
            lblJustificativa.TabIndex = 23;
            lblJustificativa.Text = "Justificativa";
            // 
            // txtJustificativa
            // 
            txtJustificativa.Location = new Point(145, 424);
            txtJustificativa.Name = "txtJustificativa";
            txtJustificativa.Size = new Size(519, 23);
            txtJustificativa.TabIndex = 22;
            // 
            // txtNota
            // 
            txtNota.Location = new Point(145, 356);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(519, 23);
            txtNota.TabIndex = 21;
            // 
            // txtSerie
            // 
            txtSerie.Location = new Point(145, 289);
            txtSerie.Name = "txtSerie";
            txtSerie.Size = new Size(519, 23);
            txtSerie.TabIndex = 20;
            // 
            // txtNomeAluno
            // 
            txtNomeAluno.Location = new Point(145, 213);
            txtNomeAluno.Name = "txtNomeAluno";
            txtNomeAluno.Size = new Size(519, 23);
            txtNomeAluno.TabIndex = 19;
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Location = new Point(393, 338);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(33, 15);
            lblNota.TabIndex = 18;
            lblNota.Text = "Nota";
            // 
            // lblSerie
            // 
            lblSerie.AutoSize = true;
            lblSerie.Location = new Point(394, 271);
            lblSerie.Name = "lblSerie";
            lblSerie.Size = new Size(32, 15);
            lblSerie.TabIndex = 17;
            lblSerie.Text = "Serie";
            // 
            // lblNomeAluno
            // 
            lblNomeAluno.AutoSize = true;
            lblNomeAluno.Location = new Point(369, 186);
            lblNomeAluno.Name = "lblNomeAluno";
            lblNomeAluno.Size = new Size(90, 15);
            lblNomeAluno.TabIndex = 16;
            lblNomeAluno.Text = "Nome do aluno";
            // 
            // frmNotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 629);
            Controls.Add(lblSupContato);
            Controls.Add(button1);
            Controls.Add(lblJustificativa);
            Controls.Add(txtJustificativa);
            Controls.Add(txtNota);
            Controls.Add(txtSerie);
            Controls.Add(txtNomeAluno);
            Controls.Add(lblNota);
            Controls.Add(lblSerie);
            Controls.Add(lblNomeAluno);
            Controls.Add(panel1);
            Name = "frmNotas";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label lblSupContato;
        private Button button1;
        private Label lblJustificativa;
        private TextBox txtJustificativa;
        private TextBox txtNota;
        private TextBox txtSerie;
        private TextBox txtNomeAluno;
        private Label lblNota;
        private Label lblSerie;
        private Label lblNomeAluno;
    }
}