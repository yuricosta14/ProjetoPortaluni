namespace ProjetoPortaluni.View
{
    partial class frmSuporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuporte));
            lblFale = new Label();
            pictureBox1 = new PictureBox();
            lblNumero = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblFale
            // 
            lblFale.AutoSize = true;
            lblFale.Font = new Font("Segoe UI", 26F);
            lblFale.ForeColor = SystemColors.ControlText;
            lblFale.Location = new Point(268, 40);
            lblFale.Name = "lblFale";
            lblFale.Size = new Size(230, 47);
            lblFale.TabIndex = 0;
            lblFale.Text = "Fale conosco!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(215, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(334, 368);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 17F);
            lblNumero.Location = new Point(310, 481);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(157, 31);
            lblNumero.TabIndex = 2;
            lblNumero.Text = "(43)4002-8922";
            // 
            // frmSuporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(772, 576);
            Controls.Add(lblNumero);
            Controls.Add(pictureBox1);
            Controls.Add(lblFale);
            Name = "frmSuporte";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFale;
        private PictureBox pictureBox1;
        private Label lblNumero;
    }
}