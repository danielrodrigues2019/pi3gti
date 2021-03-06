﻿using FATEC;
using System;
using System.Web;
using PROJETO.Classes;
using System.Data;
using System.Collections.Generic;

namespace PROJETO.Persistencia
{
    /// <summary>
    /// Summary description for FuncionarioBD
    /// </summary>
    public class ClienteBD
    {
        //métodos
        //insert
        public bool Insert(Cliente cliente)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_cliente(cli_nome, cli_telefone, cli_endereco, cli_cpf, cli_datacadastro) VALUES (?nome, ?telefone, ?endereco, ?cpf, ?datacadastro)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?nome", cliente.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?telefone", cliente.Telefone));
            objCommand.Parameters.Add(Mapped.Parameter("?endereco", cliente.Endereco));
            objCommand.Parameters.Add(Mapped.Parameter("?cpf", cliente.CPF));
            objCommand.Parameters.Add(Mapped.Parameter("?datacadastro", cliente.Datacadastro));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }
        //selectall
        public DataSet SelectAll()
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_cliente", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }

       static public DataSet SelectTodos()
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_cliente", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }

        //select
        public Cliente Select(int id)
        {
            Cliente obj = null;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_cliente WHERE cli_codigo=?codigo", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new Cliente();
                obj.Codigo = Convert.ToInt32(objDataReader["cli_codigo"]);
                obj.Nome = Convert.ToString(objDataReader["cli_nome"]);
                obj.Telefone = Convert.ToString(objDataReader["cli_telefone"]);
                obj.Endereco = Convert.ToString(objDataReader["cli_endereco"]);
                obj.CPF = Convert.ToString(objDataReader["cli_cpf"]);
                obj.CPF = Convert.ToString(objDataReader["cli_datacadastro"]);
            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();
            return obj;
        }
        //update
        public bool Update(Cliente cliente)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "UPDATE tbl_cliente SET cli_nome=?nome, cli_telefone=?telefone, cli_endereco=?endereco, cli_cpf=?cpf WHERE cli_codigo=?codigo";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", cliente.Codigo));
            objCommand.Parameters.Add(Mapped.Parameter("?nome", cliente.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?telefone", cliente.Telefone));
            objCommand.Parameters.Add(Mapped.Parameter("?endereco", cliente.Endereco));
            objCommand.Parameters.Add(Mapped.Parameter("?cpf", cliente.CPF));
            objCommand.Parameters.Add(Mapped.Parameter("?datacadastro", cliente.Datacadastro));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }
        //delete
        public bool Delete(int id)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "DELETE FROM tbl_cliente WHERE cli_codigo=?codigo";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }
        //relatoriocliente
        public string[][] QuantidadeClientes(string dataIni, string dataFim)
        {
            List<string[]> data = new List<string[]>();
            
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT cli_datacadastro AS dia, COUNT(cli_codigo) AS 'total' FROM tbl_cliente WHERE cli_datacadastro BETWEEN ?dataini and ?datafim GROUP BY cli_datacadastro", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?dataini", dataIni));
            objCommand.Parameters.Add(Mapped.Parameter("?datafim", dataFim));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                data.Add(new string[] { objDataReader["dia"].ToString(), objDataReader["total"].ToString() });
            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();

            return data.ToArray();
        }

        //construtor
        public ClienteBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}