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
    public partial class TelaDeletar : Form
    {
        public TelaDeletar()
        {
            InitializeComponent();
        }
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            Cursos.Codigo = Convert.ToInt32(textBoxcod.Text);

            Opera mopera = new();
            mopera.PesquisaCurso();

            textBoxcod.Text = Cursos.Codigo.ToString();
            textBoxturno.Text = Cursos.Turno;
            textBoxduracao.Text = Cursos.Duracao;
            comboBoxcurso.Text = Cursos.Curso;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursos.Codigo = Convert.ToInt32(textBoxcod.Text);

            Opera mopera = new();
            mopera.DeletarCursos();
        }


    }
}
