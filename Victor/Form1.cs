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
            Curso c = new Curso(txtCodigoCurso.Text, txtNomeCurso.Text, txtCategoriaCurso, txtBuscaCursoPorDescricao);
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
            List<Curso> listaDeClientes = Curso.Listar();
            int cont = 0;
            foreach (Curso cliente in listaDeClientes)
            {
                dgvCursos.Rows.Add();
                dgvCursos.Rows[cont].Cells[0].Value = cliente.crs_codigo.ToString();
                dgvCursos.Rows[cont].Cells[1].Value = cliente.crs_nome.ToString();
                dgvCursos.Rows[cont].Cells[2].Value = cliente.crs_categoria.ToString();
                dgvCursos.Rows[cont].Cells[3].Value = cliente.crs_carga_horaria.ToString();
                dgvCursos.Rows[cont].Cells[4].Value = cliente.crs_valor;
                cont++;
            }
        }
    }
}
