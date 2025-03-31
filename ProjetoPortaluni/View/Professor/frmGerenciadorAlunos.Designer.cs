namespace ProjetoPortaluni.View.Professor
{
    partial class frmGerenciadorAlunos
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
            lblNomeCompleto = new Label();
            lblDataNascimento = new Label();
            lblSexo = new Label();
            lblCpf = new Label();
            lblEmail = new Label();
            lblTelefone = new Label();
            lblCep = new Label();
            panel1 = new Panel();
            label10 = new Label();
            txtNomeCompleto = new TextBox();
            txtEmail = new TextBox();
            mskdDataNascimento = new MaskedTextBox();
            mskdTelefone = new MaskedTextBox();
            mskdCep = new MaskedTextBox();
            btnBuscar = new Button();
            lblLogradouro = new Label();
            lblNumero = new Label();
            lblUf = new Label();
            lblMunicipio = new Label();
            lblBairro = new Label();
            txtLogradouro = new TextBox();
            txtNumero = new TextBox();
            txtbairro = new TextBox();
            txtMunicipio = new TextBox();
            txtUf = new TextBox();
            btnSalvar = new Button();
            rdbMasculino = new RadioButton();
            rdbFeminino = new RadioButton();
            rdbNaoDeclarar = new RadioButton();
            mskdCpf = new MaskedTextBox();
            lblSupContato = new Label();
            lblSerie = new Label();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Location = new Point(13, 154);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(96, 15);
            lblNomeCompleto.TabIndex = 0;
            lblNomeCompleto.Text = "Nome Completo";
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Location = new Point(307, 154);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(98, 15);
            lblDataNascimento.TabIndex = 1;
            lblDataNascimento.Text = "Data Nascimento";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(594, 154);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(32, 15);
            lblSexo.TabIndex = 2;
            lblSexo.Text = "Sexo";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(690, 154);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(28, 15);
            lblCpf.TabIndex = 3;
            lblCpf.Text = "CPF";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(13, 248);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "E-mail";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(307, 248);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 7;
            lblTelefone.Text = "Telefone";
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(18, 357);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(28, 15);
            lblCep.TabIndex = 8;
            lblCep.Text = "CEP";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(label10);
            panel1.Location = new Point(-5, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(949, 96);
            panel1.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(18, 40);
            label10.Name = "label10";
            label10.Size = new Size(159, 30);
            label10.TabIndex = 0;
            label10.Text = "NOTA ALUNOS";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(13, 184);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(228, 23);
            txtNomeCompleto.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(13, 286);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(228, 23);
            txtEmail.TabIndex = 11;
            // 
            // mskdDataNascimento
            // 
            mskdDataNascimento.Location = new Point(307, 184);
            mskdDataNascimento.Mask = "00/00/0000";
            mskdDataNascimento.Name = "mskdDataNascimento";
            mskdDataNascimento.Size = new Size(228, 23);
            mskdDataNascimento.TabIndex = 12;
            mskdDataNascimento.ValidatingType = typeof(DateTime);
            // 
            // mskdTelefone
            // 
            mskdTelefone.Location = new Point(307, 286);
            mskdTelefone.Mask = "(##) #####-####";
            mskdTelefone.Name = "mskdTelefone";
            mskdTelefone.Size = new Size(228, 23);
            mskdTelefone.TabIndex = 13;
            // 
            // mskdCep
            // 
            mskdCep.Location = new Point(13, 386);
            mskdCep.Mask = "#####-###";
            mskdCep.Name = "mskdCep";
            mskdCep.Size = new Size(228, 23);
            mskdCep.TabIndex = 16;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(114, 415);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(127, 23);
            btnBuscar.TabIndex = 17;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.Location = new Point(309, 369);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(69, 15);
            lblLogradouro.TabIndex = 18;
            lblLogradouro.Text = "Logradouro";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(594, 369);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 19;
            lblNumero.Text = "Número";
            // 
            // lblUf
            // 
            lblUf.AutoSize = true;
            lblUf.Location = new Point(307, 498);
            lblUf.Name = "lblUf";
            lblUf.Size = new Size(21, 15);
            lblUf.TabIndex = 20;
            lblUf.Text = "UF";
            // 
            // lblMunicipio
            // 
            lblMunicipio.AutoSize = true;
            lblMunicipio.Location = new Point(594, 438);
            lblMunicipio.Name = "lblMunicipio";
            lblMunicipio.Size = new Size(61, 15);
            lblMunicipio.TabIndex = 21;
            lblMunicipio.Text = "Municipio";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(309, 438);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 22;
            lblBairro.Text = "Bairro";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(307, 387);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(228, 23);
            txtLogradouro.TabIndex = 24;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(593, 387);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(228, 23);
            txtNumero.TabIndex = 25;
            // 
            // txtbairro
            // 
            txtbairro.Location = new Point(307, 458);
            txtbairro.Name = "txtbairro";
            txtbairro.Size = new Size(228, 23);
            txtbairro.TabIndex = 26;
            // 
            // txtMunicipio
            // 
            txtMunicipio.Location = new Point(593, 458);
            txtMunicipio.Name = "txtMunicipio";
            txtMunicipio.Size = new Size(228, 23);
            txtMunicipio.TabIndex = 27;
            // 
            // txtUf
            // 
            txtUf.Location = new Point(307, 531);
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(228, 23);
            txtUf.TabIndex = 28;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(600, 531);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(221, 23);
            btnSalvar.TabIndex = 30;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            rdbMasculino.AutoSize = true;
            rdbMasculino.Location = new Point(593, 172);
            rdbMasculino.Name = "rdbMasculino";
            rdbMasculino.Size = new Size(80, 19);
            rdbMasculino.TabIndex = 31;
            rdbMasculino.TabStop = true;
            rdbMasculino.Text = "Masculino";
            rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFeminino
            // 
            rdbFeminino.AutoSize = true;
            rdbFeminino.Location = new Point(594, 197);
            rdbFeminino.Name = "rdbFeminino";
            rdbFeminino.Size = new Size(75, 19);
            rdbFeminino.TabIndex = 32;
            rdbFeminino.TabStop = true;
            rdbFeminino.Text = "Feminino";
            rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // rdbNaoDeclarar
            // 
            rdbNaoDeclarar.AutoSize = true;
            rdbNaoDeclarar.Location = new Point(593, 222);
            rdbNaoDeclarar.Name = "rdbNaoDeclarar";
            rdbNaoDeclarar.Size = new Size(92, 19);
            rdbNaoDeclarar.TabIndex = 33;
            rdbNaoDeclarar.TabStop = true;
            rdbNaoDeclarar.Text = "Não declarar";
            rdbNaoDeclarar.UseVisualStyleBackColor = true;
            // 
            // mskdCpf
            // 
            mskdCpf.Location = new Point(690, 171);
            mskdCpf.Mask = "000.000.000-00";
            mskdCpf.Name = "mskdCpf";
            mskdCpf.Size = new Size(167, 23);
            mskdCpf.TabIndex = 34;
            // 
            // lblSupContato
            // 
            lblSupContato.AutoSize = true;
            lblSupContato.BackColor = Color.Transparent;
            lblSupContato.Location = new Point(662, 557);
            lblSupContato.Name = "lblSupContato";
            lblSupContato.Size = new Size(103, 15);
            lblSupContato.TabIndex = 35;
            lblSupContato.Text = "Suporte e Contato";
            // 
            // lblSerie
            // 
            lblSerie.AutoSize = true;
            lblSerie.Location = new Point(690, 268);
            lblSerie.Name = "lblSerie";
            lblSerie.Size = new Size(32, 15);
            lblSerie.TabIndex = 36;
            lblSerie.Text = "Serie";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(690, 286);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(103, 23);
            textBox1.TabIndex = 37;
            // 
            // frmGerenciadorAlunos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 626);
            Controls.Add(textBox1);
            Controls.Add(lblSerie);
            Controls.Add(lblSupContato);
            Controls.Add(mskdCpf);
            Controls.Add(rdbNaoDeclarar);
            Controls.Add(rdbFeminino);
            Controls.Add(rdbMasculino);
            Controls.Add(btnSalvar);
            Controls.Add(txtUf);
            Controls.Add(txtMunicipio);
            Controls.Add(txtbairro);
            Controls.Add(txtNumero);
            Controls.Add(txtLogradouro);
            Controls.Add(lblBairro);
            Controls.Add(lblMunicipio);
            Controls.Add(lblUf);
            Controls.Add(lblNumero);
            Controls.Add(lblLogradouro);
            Controls.Add(btnBuscar);
            Controls.Add(mskdCep);
            Controls.Add(mskdTelefone);
            Controls.Add(mskdDataNascimento);
            Controls.Add(txtEmail);
            Controls.Add(txtNomeCompleto);
            Controls.Add(panel1);
            Controls.Add(lblCep);
            Controls.Add(lblTelefone);
            Controls.Add(lblEmail);
            Controls.Add(lblCpf);
            Controls.Add(lblSexo);
            Controls.Add(lblDataNascimento);
            Controls.Add(lblNomeCompleto);
            Name = "frmGerenciadorAlunos";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeCompleto;
        private Label lblDataNascimento;
        private Label lblSexo;
        private Label lblCpf;
        private Label lblEmail;
        private Label lblTelefone;
        private Label lblCep;
        private Panel panel1;
        private Label label10;
        private TextBox txtNomeCompleto;
        private TextBox txtEmail;
        private MaskedTextBox mskdDataNascimento;
        private MaskedTextBox mskdTelefone;
        private MaskedTextBox mskdCep;
        private Button btnBuscar;
        private Label lblLogradouro;
        private Label lblNumero;
        private Label lblUf;
        private Label lblMunicipio;
        private Label lblBairro;
        private TextBox txtLogradouro;
        private TextBox txtNumero;
        private TextBox txtbairro;
        private TextBox txtMunicipio;
        private TextBox txtUf;
        private Button btnSalvar;
        private RadioButton rdbMasculino;
        private RadioButton rdbFeminino;
        private RadioButton rdbNaoDeclarar;
        private MaskedTextBox mskdCpf;
        private Label lblSupContato;
        private Label lblSerie;
        private TextBox textBox1;
    }
}