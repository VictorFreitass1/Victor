﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Victor
{
    public class Curso
    {
        // Atributos
        private int codigo;
        private string nome;
        private string categoria;
        private int carga_horaria;
        private decimal valor;
        private bool ativo;
        private DateTime data_cadastro;

        // Propriedades
        public int crs_codigo { get { return codigo; } set { codigo = value; } }
        public string crs_nome { get { return nome; } set { nome = value; } }
        public string crs_categoria { get { return categoria; } set { categoria = value; } }
        public int crs_carga_horaria { get { return carga_horaria; } set { carga_horaria = value; } }
        public decimal crs_valor { get { return valor; } set { valor = value; } }
        public bool crs_ativo { get { return ativo; } set { ativo = value; } }
        public DateTime crs_data_cadastro { get { return data_cadastro; } set { data_cadastro = value; } }
 
        // Construtores

        public Curso ()
        {

        }

        public Curso (string nome, string categoria, int carga_horaria, decimal valor, DateTime data_cadastro)
        {
            crs_nome = nome;
            crs_categoria = categoria;
            crs_carga_horaria = carga_horaria;
            crs_valor = valor;
            crs_data_cadastro = data_cadastro;
        }

        public Curso(int codigo, string nome, string categoria, int carga_horaria, decimal valor, DateTime data_cadastro, bool ativo)
        {
            crs_codigo = codigo;
            crs_nome = nome;
            crs_categoria = categoria;
            crs_carga_horaria = carga_horaria;
            crs_valor = valor;
            crs_data_cadastro = data_cadastro;
            crs_ativo = ativo;
        }

        // Métodos da classe
        public void Incluir () // Chamadas de banco e grava o registro
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "SP_NovoCurso";
            cmd.Parameters.AddWithValue("_crs_nome", nome);
            cmd.Parameters.AddWithValue("_crs_categoria", categoria);
            cmd.Parameters.AddWithValue("_crs_valor", valor);
            cmd.Parameters.AddWithValue("_crs_data_cadastro", data_cadastro);
            cmd.Connection.Close();     
        }
        public bool Atualizar()
        {
            bool resultado = false;
            try
            {
                var cmd = Banco.Abrir();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                // recebe o nome da procedure
                cmd.CommandText = "sp_cliente_alterar";
                // adiciona os parâmetros da procedure - lá do Mysql
                // cmd.Parameters.Add("_id", MysqlDbType.Int32).Value = _id;
                cmd.Parameters.AddWithValue("_crs_nome", nome);
                cmd.Parameters.AddWithValue("_crs_categoria", categoria);
                cmd.Parameters.AddWithValue("_crs_valor", valor);
                cmd.Parameters.AddWithValue("_crs_data_cadastro", data_cadastro);
                cmd.ExecuteNonQuery();
                resultado = true;
                cmd.Connection.Close();
            }
            catch (Exception)
            {

            }
            return true;

        }
    }
}