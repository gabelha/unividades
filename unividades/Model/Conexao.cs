using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaculdadeUPITech.Model
{
    internal class Conexao
    {
        public static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\diogo.acosta1\source\repos\unividades\unividades\Model\DBFaculdade.mdf;Integrated Security=True";
        }
    }
}
