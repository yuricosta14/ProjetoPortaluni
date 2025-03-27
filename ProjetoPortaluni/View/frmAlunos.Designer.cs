namespace ProjetoPortaluni.View
{
    partial class frmAlunos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlunos));
            btnTurmaAluno = new Button();
            lblSupContato = new Label();
            lblAluno = new Label();
            btnFreqAluno = new Button();
            btnGernciaCadastro = new Button();
            btnBoletim = new Button();
            splitter1 = new Splitter();
            SuspendLayout();
            // 
            // btnTurmaAluno
            // 
            btnTurmaAluno.BackColor = Color.White;
            btnTurmaAluno.Location = new Point(15, 264);
            btnTurmaAluno.Name = "btnTurmaAluno";
            btnTurmaAluno.Size = new Size(199, 25);
            btnTurmaAluno.TabIndex = 15;
            btnTurmaAluno.Text = "Ver turma";
            btnTurmaAluno.UseVisualStyleBackColor = false;
            // 
            // lblSupContato
            // 
            lblSupContato.AutoSize = true;
            lblSupContato.BackColor = Color.Gainsboro;
            lblSupContato.Location = new Point(60, 542);
            lblSupContato.Name = "lblSupContato";
            lblSupContato.Size = new Size(103, 15);
            lblSupContato.TabIndex = 14;
            lblSupContato.Text = "Suporte e Contato";
            // 
            // lblAluno
            // 
            lblAluno.AutoSize = true;
            lblAluno.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAluno.Location = new Point(385, 37);
            lblAluno.Name = "lblAluno";
            lblAluno.Size = new Size(276, 40);
            lblAluno.TabIndex = 13;
            lblAluno.Text = "Portal do Aluno";
            // 
            // btnFreqAluno
            // 
            btnFreqAluno.BackColor = Color.White;
            btnFreqAluno.Location = new Point(15, 188);
            btnFreqAluno.Name = "btnFreqAluno";
            btnFreqAluno.Size = new Size(199, 25);
            btnFreqAluno.TabIndex = 11;
            btnFreqAluno.Text = "Frequência";
            btnFreqAluno.UseVisualStyleBackColor = false;
            // 
            // btnGernciaCadastro
            // 
            btnGernciaCadastro.BackColor = Color.Transparent;
            btnGernciaCadastro.ForeColor = SystemColors.ControlText;
            btnGernciaCadastro.Location = new Point(12, 53);
            btnGernciaCadastro.Name = "btnGernciaCadastro";
            btnGernciaCadastro.Size = new Size(202, 25);
            btnGernciaCadastro.TabIndex = 10;
            btnGernciaCadastro.Text = "Gerenciar cadastro";
            btnGernciaCadastro.UseVisualStyleBackColor = false;
            // 
            // btnBoletim
            // 
            btnBoletim.Location = new Point(15, 117);
            btnBoletim.Name = "btnBoletim";
            btnBoletim.Size = new Size(199, 25);
            btnBoletim.TabIndex = 9;
            btnBoletim.Text = "Boletim";
            btnBoletim.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            splitter1.BackColor = Color.FromArgb(224, 224, 224);
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(235, 575);
            splitter1.TabIndex = 12;
            splitter1.TabStop = false;
            // 
            // frmAlunos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(798, 575);
            Controls.Add(btnTurmaAluno);
            Controls.Add(lblSupContato);
            Controls.Add(lblAluno);
            Controls.Add(btnFreqAluno);
            Controls.Add(btnGernciaCadastro);
            Controls.Add(btnBoletim);
            Controls.Add(splitter1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAlunos";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTurmaAluno;
        private Label lblSupContato;
        private Label lblAluno;
        private Button btnFreqAluno;
        private Button btnGernciaCadastro;
        private Button btnBoletim;
        private Splitter splitter1;
    }
}