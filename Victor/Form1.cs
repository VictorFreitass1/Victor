using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Victor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserirCurso_Click(object sender, EventArgs e)
        {
            Curso c = new Curso(txtNomeCurso.Text, txtCategoriaCurso.Text, Convert.ToInt32(txtCargaHorariaCurso.Text), Convert.ToDouble(txtValorCurso.Text));
            c.Incluir();
            if (c.crs_codigo > 0)
            {
                txtCodigoCurso.Text = c.crs_codigo.ToString();
                MessageBox.Show("Cliente gravado com sucesso!");
            }
            else
            {
                MessageBox.Show("Falha ao inserir cliente.");
            }
        }

        private void btnListarCursos_Click(object sender, EventArgs e)
        {
            dgvCursos.Rows.Clear();
            List<Curso> listaDeCursos = Curso.Listar();
            int cont = 0;
            foreach (Curso curso in listaDeCursos)
            {
                dgvCursos.Rows.Add();
                dgvCursos.Rows[cont].Cells[0].Value = curso.crs_codigo.ToString();
                dgvCursos.Rows[cont].Cells[1].Value = curso.crs_nome.ToString();
                dgvCursos.Rows[cont].Cells[2].Value = curso.crs_categoria.ToString();
                dgvCursos.Rows[cont].Cells[3].Value = curso.crs_carga_horaria.ToString();
                dgvCursos.Rows[cont].Cells[4].Value = curso.crs_valor;
                cont++;
            }
        }

        private void btnConsultaCursoPorId_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterarCurso_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            if (curso.Alterar())
            {
                MessageBox.Show("Cliente alterado com Sucesso!");
            }
            else
            {
                MessageBox.Show("Falha na alteração do Cliente!");
                btnConsultaCursoPorId.Text = "...";
                txtCodigoCurso.Text = "";
                txtBuscaCursoPorDescricao.Text = "";
                txtCargaHorariaCurso.Text = "";
                txtCategoriaCurso.Text = "";
                txtCodigoCurso.ReadOnly = true;
                btnAlterarCurso.Enabled = false;
            }
    }

        private void btnExcluirCurso_Click(object sender, EventArgs e)
        {

        }
    }
}
