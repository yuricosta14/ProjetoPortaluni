namespace ProjetoPortaluni.View
{
    partial class frmProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfessor));
            btnNotas = new Button();
            btnGernciaAluno = new Button();
            btnFreq = new Button();
            lblProfessor = new Label();
            lblSupContato = new Label();
            splitter1 = new Splitter();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnNotas
            // 
            btnNotas.Location = new Point(12, 122);
            btnNotas.Name = "btnNotas";
            btnNotas.Size = new Size(199, 25);
            btnNotas.TabIndex = 1;
            btnNotas.Text = "Notas";
            btnNotas.UseVisualStyleBackColor = true;
            btnNotas.Click += btnNotas_Click;
            // 
            // btnGernciaAluno
            // 
            btnGernciaAluno.BackColor = Color.Transparent;
            btnGernciaAluno.ForeColor = SystemColors.ControlText;
            btnGernciaAluno.Location = new Point(12, 52);
            btnGernciaAluno.Name = "btnGernciaAluno";
            btnGernciaAluno.Size = new Size(202, 25);
            btnGernciaAluno.TabIndex = 2;
            btnGernciaAluno.Text = "Gerenciador de alunos";
            btnGernciaAluno.UseVisualStyleBackColor = false;
            btnGernciaAluno.Click += btnGernciaAluno_Click;
            // 
            // btnFreq
            // 
            btnFreq.BackColor = Color.White;
            btnFreq.Location = new Point(12, 196);
            btnFreq.Name = "btnFreq";
            btnFreq.Size = new Size(199, 25);
            btnFreq.TabIndex = 3;
            btnFreq.Text = "Frequência";
            btnFreq.UseVisualStyleBackColor = false;
            btnFreq.Click += btnFreq_Click;
            // 
            // lblProfessor
            // 
            lblProfessor.AutoSize = true;
            lblProfessor.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProfessor.Location = new Point(365, 37);
            lblProfessor.Name = "lblProfessor";
            lblProfessor.Size = new Size(345, 40);
            lblProfessor.TabIndex = 5;
            lblProfessor.Text = "Portal do Professor";
            // 
            // lblSupContato
            // 
            lblSupContato.AutoSize = true;
            lblSupContato.BackColor = Color.Gainsboro;
            lblSupContato.Cursor = Cursors.Help;
            lblSupContato.Location = new Point(54, 534);
            lblSupContato.Name = "lblSupContato";
            lblSupContato.Size = new Size(103, 15);
            lblSupContato.TabIndex = 6;
            lblSupContato.Text = "Suporte e Contato";
            lblSupContato.Click += lblSupContato_Click;
            // 
            // splitter1
            // 
            splitter1.BackColor = Color.FromArgb(224, 224, 224);
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(234, 558);
            splitter1.TabIndex = 4;
            splitter1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(15, 298);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 184);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // frmProfessor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(801, 558);
            Controls.Add(lblSupContato);
            Controls.Add(lblProfessor);
            Controls.Add(btnFreq);
            Controls.Add(btnGernciaAluno);
            Controls.Add(btnNotas);
            Controls.Add(splitter1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmProfessor";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnNotas;
        private Button btnGernciaAluno;
        private Button btnFreq;
        private Label lblProfessor;
        private Label lblSupContato;
        private Splitter splitter1;
        private PictureBox pictureBox1;
    }
}