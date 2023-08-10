using FaculdadeUPITech.Model;
using FaculdadeUPITech.Controller;
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
    public partial class TelaPesquisa : Form
    {
        public TelaPesquisa()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cursos.Codigo = Convert.ToInt32(textBoxcod.Text);

            Opera mopera = new Opera();
            mopera.PesquisaCurso();

            textBoxcod.Text = Cursos.Codigo.ToString();
            textBoxhorario.Text = Cursos.Duracao;
            textBoxsala.Text = Cursos.Turno;
        }
    }
}
