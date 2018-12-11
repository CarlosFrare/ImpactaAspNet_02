﻿using Pessoal.Dominio.Entidades;
using Pessoal.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoal.Repositorios.SqlServer
{
    public class TarefaRepositorio : ITarefaRepositorio
    {
        private readonly string 
        stringConexao = ConfigurationManager.ConnectionStrings["pessoalSqlServer"].ConnectionString;


        public void Atualizar(Tarefa Tarefa)
        {

            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();

                using (var comando = new SqlCommand("TarefaAtualizar", conexao))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddRange(Mapear(Tarefa).ToArray());
                    comando.ExecuteNonQuery();
                }

            }

        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public int Inserir(Tarefa Tarefa)
        {
            using (var conexao  = new SqlConnection(stringConexao))
            {
                conexao.Open();

                using (var comando = new SqlCommand("TarefaInserir",  conexao))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddRange(Mapear(Tarefa).ToArray());
                    return (int)comando.ExecuteScalar();
                }
            }
        }

        private List<SqlParameter> Mapear(Tarefa tarefa)
        {
            var parametros = new List<SqlParameter>();

            if (tarefa.Id > 0)
            {
                parametros.Add(new SqlParameter("@Id", tarefa.Id));
            }

            parametros.Add(new SqlParameter("@Concluida", tarefa.Concluida));
            parametros.Add(new SqlParameter("@Nome", tarefa.Nome));
            parametros.Add(new SqlParameter("@Observacoes", tarefa.Observacoes));
            parametros.Add(new SqlParameter("@Prioridade", tarefa.Prioridade));

            return parametros;
            //throw new NotImplementedException();
        }

        public Tarefa Selecionar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Tarefa> Selecionar()
        {
            throw new NotImplementedException();
        }
    }
}