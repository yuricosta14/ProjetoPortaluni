using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoPortaluni.View.Alunos;

namespace ProjetoPortaluni.View
{
    public partial class frmAlunos : Form
    {
        public frmAlunos()
        {
            InitializeComponent();
        }


        private void btnBoletim_Click(object sender, EventArgs e)
        {
            var form = new frmBoletim();
            form.ShowDialog();
        }

        private void btnFreqAluno_Click(object sender, EventArgs e)
        {
            var form = new frmFreq();
            form.ShowDialog();
        }

        private void lblSupContato_Click(object sender, EventArgs e)
        {
            var form = new frmSuporte();
            form.ShowDialog();
        }
    }
}
