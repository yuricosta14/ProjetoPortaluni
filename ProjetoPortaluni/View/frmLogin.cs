using ProjetoPortaluni.Model.Validators;
using ProjetoPortaluni.View;
using System;
using System.Runtime.Intrinsics.X86;
using System.Windows.Forms;

namespace ProjetoPortaluni
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblEsqueciSenha_Click(object sender, EventArgs e)
        {
            var form = new frmRecuperarSenha();
            form.ShowDialog();
 
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var emailEhValido = Validadores.EmailEValido(txtEmail.Text);
                if(emailEhValido is false)
            {
                errorProvider1.SetError(txtEmail, "Seu e-mail está incorreto, tentar novamente");
                txtEmail.Focus();
                return;
            }
            if (rdbAluno.Checked)
            {
                frmAlunos frmAlunos = new frmAlunos();
                frmAlunos.Show();
            }
            else if (rdbProfessor.Checked)
            {
                frmProfessor frmProfessor = new frmProfessor();
                frmProfessor.Show();
            }
            else
            {
                MessageBox.Show("Selecione uma opção!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
