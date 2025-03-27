namespace ProjetoPortaluni.View
{
    partial class frmRecuperarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecuperarSenha));
            txtSenha = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            btnEntrar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(28, 213);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(425, 23);
            txtSenha.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(28, 182);
            label2.Name = "label2";
            label2.Size = new Size(114, 28);
            label2.TabIndex = 10;
            label2.Text = "Nova senha";
            // 
            // txtEmail
            // 
            txtEmail.AccessibleRole = AccessibleRole.None;
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(28, 125);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(425, 23);
            txtEmail.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(28, 94);
            label1.Name = "label1";
            label1.Size = new Size(67, 28);
            label1.TabIndex = 8;
            label1.Text = "E-mail";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.Gainsboro;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Location = new Point(134, 311);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(191, 31);
            btnEntrar.TabIndex = 7;
            btnEntrar.Text = "Confirmar";
            btnEntrar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources._10983643;
            pictureBox1.Location = new Point(503, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(301, 271);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // frmRecuperarSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(816, 423);
            Controls.Add(pictureBox1);
            Controls.Add(txtSenha);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(btnEntrar);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmRecuperarSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recuperar senha";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSenha;
        private Label label2;
        private TextBox txtEmail;
        private Label label1;
        private Button btnEntrar;
        private PictureBox pictureBox1;
    }
}