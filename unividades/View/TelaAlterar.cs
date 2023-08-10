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
    public partial class TelaAlterar : Form
    {
        public TelaAlterar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cursos.Codigo = Convert.ToInt32(textBoxCodigo.Text);
            Opera mopera = new();
            mopera.PesquisaCurso();

            textBoxCodigo.Text = Cursos.Codigo.ToString();
            textBoxturno.Text = Cursos.Turno;
            textBoxduracao.Text = Cursos.Duracao;
            comboBoxcurso.Text = Cursos.Curso;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cursos.Codigo = Convert.ToInt32(textBoxCodigo.Text);
            Cursos.Turno = textBoxturno.Text;
            Cursos.Duracao = textBoxduracao.Text;
            Cursos.Curso = comboBoxcurso.Text;

            Opera mopera = new();
            mopera.AlterarCursos();
        }
    }
}
