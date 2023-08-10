using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaculdadeUPITech.Model;
using unividades.View;

namespace FaculdadeUPITech.Controller
{
    internal class Opera
    {
        public void CadCurso()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pCadastrar", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("Curso", Cursos.Curso);
                cmd.Parameters.AddWithValue("Turno", Cursos.Turno);
                cmd.Parameters.AddWithValue("Duracao", Cursos.Duracao);

                SqlParameter nv = cmd.Parameters.Add("idCurso", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Curso cadastrado com sucesso, Deseja cadastrar outro ?");

                if (resposta == DialogResult.Yes)
                {
                    TelaCadastro telaCadastro = new TelaCadastro();
                    telaCadastro.AbrirCadastro();
                }
                else
                {
                    return;
                }
              

            }
            catch(Exception)
            {
                throw;
            }
        }
        public void PesquisaCurso()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pBusca", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try 
            {
                cmd.Parameters.AddWithValue("@idCurso", Cursos.Codigo);
                cn.Open();

                var registros = cmd.ExecuteReader();

                if (registros.Read())
                {
                    Cursos.Codigo = Convert.ToInt32(registros["IdCurso"]);
                    Cursos.Turno = (string)registros["Turno"];
                    Cursos.Duracao = (string)registros["Duracao"];
                    Cursos.Curso = (string)registros["Curso"];
                }

                else
                {
                    Cursos.Codigo = 0;
                    Cursos.Turno = "";
                    Cursos.Duracao = "";
                    Cursos.Curso = "";
                    MessageBox.Show("Curso não encontrado");
                }
            }

            catch (Exception)
            {
                throw;
            }
        }

        public void AlterarCursos()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pAlterarPecas", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("IdCurso", Cursos.Codigo);
                cmd.Parameters.AddWithValue("Curso", Cursos.Curso);
                cmd.Parameters.AddWithValue("Turno", Cursos.Turno);
                cmd.Parameters.AddWithValue("Duracao", Cursos.Duracao);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Curso Alterado Com Sucesso");
                Cursos.Codigo = 0;
                Cursos.Curso = "";
                Cursos.Turno = "";
                Cursos.Duracao = "";
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeletarCursos()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pDeletar", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("IdCurso", Cursos.Codigo);
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Curso deletado com sucesso, Deseja deletar outro Curso?", "Deletar Registro", 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (resposta == DialogResult.Yes)
                {
                    TelaDeletar telaDeletar = new TelaDeletar();

                }
                else
                {
                    return;
                }
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
