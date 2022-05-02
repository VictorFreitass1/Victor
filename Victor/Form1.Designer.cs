namespace Victor
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigoCurso = new System.Windows.Forms.TextBox();
            this.txtNomeCurso = new System.Windows.Forms.TextBox();
            this.txtCategoriaCurso = new System.Windows.Forms.TextBox();
            this.txtCargaHorariaCurso = new System.Windows.Forms.TextBox();
            this.txtValorCurso = new System.Windows.Forms.TextBox();
            this.btnInserirCurso = new System.Windows.Forms.Button();
            this.btnConsultaCursoPorId = new System.Windows.Forms.Button();
            this.btnAlterarCurso = new System.Windows.Forms.Button();
            this.btnExcluirCurso = new System.Windows.Forms.Button();
            this.btnListarCursos = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.txtBuscaCursoPorDescricao = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CATEGORIA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CARGA HORÁRIA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "VALOR R$";
            // 
            // txtCodigoCurso
            // 
            this.txtCodigoCurso.Location = new System.Drawing.Point(110, 4);
            this.txtCodigoCurso.Name = "txtCodigoCurso";
            this.txtCodigoCurso.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoCurso.TabIndex = 5;
            // 
            // txtNomeCurso
            // 
            this.txtNomeCurso.Location = new System.Drawing.Point(110, 30);
            this.txtNomeCurso.Name = "txtNomeCurso";
            this.txtNomeCurso.Size = new System.Drawing.Size(375, 20);
            this.txtNomeCurso.TabIndex = 6;
            // 
            // txtCategoriaCurso
            // 
            this.txtCategoriaCurso.Location = new System.Drawing.Point(110, 54);
            this.txtCategoriaCurso.Name = "txtCategoriaCurso";
            this.txtCategoriaCurso.Size = new System.Drawing.Size(232, 20);
            this.txtCategoriaCurso.TabIndex = 7;
            // 
            // txtCargaHorariaCurso
            // 
            this.txtCargaHorariaCurso.Location = new System.Drawing.Point(110, 79);
            this.txtCargaHorariaCurso.Name = "txtCargaHorariaCurso";
            this.txtCargaHorariaCurso.Size = new System.Drawing.Size(100, 20);
            this.txtCargaHorariaCurso.TabIndex = 8;
            // 
            // txtValorCurso
            // 
            this.txtValorCurso.Location = new System.Drawing.Point(110, 105);
            this.txtValorCurso.Name = "txtValorCurso";
            this.txtValorCurso.Size = new System.Drawing.Size(100, 20);
            this.txtValorCurso.TabIndex = 9;
            // 
            // btnInserirCurso
            // 
            this.btnInserirCurso.Location = new System.Drawing.Point(11, 186);
            this.btnInserirCurso.Name = "btnInserirCurso";
            this.btnInserirCurso.Size = new System.Drawing.Size(75, 23);
            this.btnInserirCurso.TabIndex = 10;
            this.btnInserirCurso.Text = "Inserir";
            this.btnInserirCurso.UseVisualStyleBackColor = true;
            this.btnInserirCurso.Click += new System.EventHandler(this.btnInserirCurso_Click);
            // 
            // btnConsultaCursoPorId
            // 
            this.btnConsultaCursoPorId.Location = new System.Drawing.Point(110, 186);
            this.btnConsultaCursoPorId.Name = "btnConsultaCursoPorId";
            this.btnConsultaCursoPorId.Size = new System.Drawing.Size(75, 23);
            this.btnConsultaCursoPorId.TabIndex = 11;
            this.btnConsultaCursoPorId.Text = "Consultar";
            this.btnConsultaCursoPorId.UseVisualStyleBackColor = true;
            // 
            // btnAlterarCurso
            // 
            this.btnAlterarCurso.Location = new System.Drawing.Point(219, 186);
            this.btnAlterarCurso.Name = "btnAlterarCurso";
            this.btnAlterarCurso.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarCurso.TabIndex = 12;
            this.btnAlterarCurso.Text = "Alterar";
            this.btnAlterarCurso.UseVisualStyleBackColor = true;
            // 
            // btnExcluirCurso
            // 
            this.btnExcluirCurso.Location = new System.Drawing.Point(316, 186);
            this.btnExcluirCurso.Name = "btnExcluirCurso";
            this.btnExcluirCurso.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirCurso.TabIndex = 13;
            this.btnExcluirCurso.Text = "Excluir";
            this.btnExcluirCurso.UseVisualStyleBackColor = true;
            // 
            // btnListarCursos
            // 
            this.btnListarCursos.Location = new System.Drawing.Point(410, 186);
            this.btnListarCursos.Name = "btnListarCursos";
            this.btnListarCursos.Size = new System.Drawing.Size(75, 23);
            this.btnListarCursos.TabIndex = 14;
            this.btnListarCursos.Text = "Listar";
            this.btnListarCursos.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Pesquisa por descrição";
            // 
            // dgvCursos
            // 
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Location = new System.Drawing.Point(12, 280);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.Size = new System.Drawing.Size(473, 150);
            this.dgvCursos.TabIndex = 16;
            // 
            // txtBuscaCursoPorDescricao
            // 
            this.txtBuscaCursoPorDescricao.Location = new System.Drawing.Point(12, 259);
            this.txtBuscaCursoPorDescricao.Name = "txtBuscaCursoPorDescricao";
            this.txtBuscaCursoPorDescricao.Size = new System.Drawing.Size(473, 20);
            this.txtBuscaCursoPorDescricao.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 438);
            this.Controls.Add(this.txtBuscaCursoPorDescricao);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnListarCursos);
            this.Controls.Add(this.btnExcluirCurso);
            this.Controls.Add(this.btnAlterarCurso);
            this.Controls.Add(this.btnConsultaCursoPorId);
            this.Controls.Add(this.btnInserirCurso);
            this.Controls.Add(this.txtValorCurso);
            this.Controls.Add(this.txtCargaHorariaCurso);
            this.Controls.Add(this.txtCategoriaCurso);
            this.Controls.Add(this.txtNomeCurso);
            this.Controls.Add(this.txtCodigoCurso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigoCurso;
        private System.Windows.Forms.TextBox txtNomeCurso;
        private System.Windows.Forms.TextBox txtCategoriaCurso;
        private System.Windows.Forms.TextBox txtCargaHorariaCurso;
        private System.Windows.Forms.TextBox txtValorCurso;
        private System.Windows.Forms.Button btnInserirCurso;
        private System.Windows.Forms.Button btnConsultaCursoPorId;
        private System.Windows.Forms.Button btnAlterarCurso;
        private System.Windows.Forms.Button btnExcluirCurso;
        private System.Windows.Forms.Button btnListarCursos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.TextBox txtBuscaCursoPorDescricao;
    }
}

