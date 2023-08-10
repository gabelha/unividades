using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaculdadeUPITech.Model
{
    internal class Cursos
    {
        private static int codigo;
        private static string curso;
        private static string turno;
        private static string duracao;

        public static int Codigo { get => codigo; set => codigo = value; }
        public static string Curso { get => curso; set => curso = value; }
        public static string Turno { get => turno; set => turno = value; }
        public static string Duracao { get => duracao; set => duracao = value; }
    }
}
