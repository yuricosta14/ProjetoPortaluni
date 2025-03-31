using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoPortaluni.View.Professor;

namespace ProjetoPortaluni.View
{
    public partial class frmProfessor : Form
    {
        public frmProfessor()
        {
            InitializeComponent();
        }

        private void btnGernciaAluno_Click(object sender, EventArgs e)
        {
            var form = new frmGerenciadorAlunos();
            form.ShowDialog();
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            var form = new frmNotas();
            form.ShowDialog();
        }

        private void btnFreq_Click(object sender, EventArgs e)
        {
            var form = new frmFrequencia();
            form.ShowDialog();
        }



        private void lblSupContato_Click(object sender, EventArgs e)
        {
            var form = new frmSuporte();
            form.ShowDialog();
        }
    }
}
