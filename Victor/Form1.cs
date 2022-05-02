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
    }
}
