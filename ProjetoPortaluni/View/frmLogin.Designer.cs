﻿namespace ProjetoPortaluni
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pictureBox1 = new PictureBox();
            btnEntrar = new Button();
            label1 = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            label2 = new Label();
            lblEsqueciSenha = new Label();
            rdbAluno = new RadioButton();
            rdbProfessor = new RadioButton();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(255, 128, 0);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(598, 135);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.Gainsboro;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Location = new Point(237, 479);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(191, 31);
            btnEntrar.TabIndex = 1;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(131, 262);
            label1.Name = "label1";
            label1.Size = new Size(67, 28);
            label1.TabIndex = 2;
            label1.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.AccessibleRole = AccessibleRole.None;
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(131, 293);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(425, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(131, 381);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(425, 23);
            txtSenha.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(131, 350);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // lblEsqueciSenha
            // 
            lblEsqueciSenha.AutoSize = true;
            lblEsqueciSenha.FlatStyle = FlatStyle.System;
            lblEsqueciSenha.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            lblEsqueciSenha.Location = new Point(466, 407);
            lblEsqueciSenha.Name = "lblEsqueciSenha";
            lblEsqueciSenha.Size = new Size(90, 18);
            lblEsqueciSenha.TabIndex = 6;
            lblEsqueciSenha.Text = "Esqueci a senha";
            lblEsqueciSenha.UseCompatibleTextRendering = true;
            lblEsqueciSenha.Click += lblEsqueciSenha_Click;
            // 
            // rdbAluno
            // 
            rdbAluno.AutoSize = true;
            rdbAluno.Location = new Point(131, 410);
            rdbAluno.Name = "rdbAluno";
            rdbAluno.Size = new Size(57, 19);
            rdbAluno.TabIndex = 7;
            rdbAluno.TabStop = true;
            rdbAluno.Text = "Aluno";
            rdbAluno.UseVisualStyleBackColor = true;
            // 
            // rdbProfessor
            // 
            rdbProfessor.AutoSize = true;
            rdbProfessor.Location = new Point(194, 410);
            rdbProfessor.Name = "rdbProfessor";
            rdbProfessor.Size = new Size(74, 19);
            rdbProfessor.TabIndex = 8;
            rdbProfessor.TabStop = true;
            rdbProfessor.Text = "Professor";
            rdbProfessor.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(704, 570);
            Controls.Add(rdbProfessor);
            Controls.Add(rdbAluno);
            Controls.Add(lblEsqueciSenha);
            Controls.Add(txtSenha);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(btnEntrar);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnEntrar;
        private Label label1;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Label label2;
        private Label lblEsqueciSenha;
        private RadioButton rdbAluno;
        private RadioButton rdbProfessor;
        private ErrorProvider errorProvider1;
    }
}
