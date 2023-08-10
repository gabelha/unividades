using FaculdadeUPITech.Controller;
using FaculdadeUPITech.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unividades.View
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursos.Turno = textBoxturno.Text;
            Cursos.Duracao = textBoxduracao.Text;
            Cursos.Curso = comboBoxcurso.Text;

            Opera mcurso = new Opera();
            mcurso.CadCurso();
        }

        public void AbrirCadastro()
        {
            this.ShowDialog();
        }
    }
}
