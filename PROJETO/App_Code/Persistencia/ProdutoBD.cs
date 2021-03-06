﻿using FATEC; //para acesso a classe Mapped
using System;
using System.Web;
using PROJETO.Classes; //para acesso a classe Produto
using System.Data; //para uso de DataSet
using System.Collections.Generic;

namespace PROJETO.Persistencia
{
    /// <summary>
    /// Summary description for ProdutoBD
    /// </summary>
    public class ProdutoBD
    {
        //métodos
        //Search
        public DataSet Search(string termo)
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_produto WHERE pro_nome LIKE ? nome ORDER BY pro_nome", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?nome", '%' + termo + '%'));
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }
        //insert
        public bool Insert(Produto produto)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_produto(pro_nome, pro_datacadastro, pro_precovenda) VALUES (?nome, ?datacadastro, ?precovenda)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?nome", produto.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?datacadastro", produto.Datacadastro));
            objCommand.Parameters.Add(Mapped.Parameter("?precovenda", produto.PrecoVenda));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }

        public DataSet Select4(int idProduto)
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("select p.pro_nome as Produto, p.pro_precovenda as Venda, i.itc_precocusto as Custo, p.pro_precovenda - i.itc_precocusto as Lucro, (p.pro_precovenda - i.itc_precocusto)/p.pro_precovenda*100 as Procentagem from tbl_produto p inner join tbl_itenscompra i on p.pro_codigo = i.pro_codigo where p.pro_codigo  like ?idProduto group by p.pro_nome;", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?idProduto", idProduto));
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }

        //selectall
        public DataSet SelectAll()
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_produto", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }
        //selectall1
        public DataSet SelectAll1()
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_produto", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }

        //selectall2
        public DataSet SelectAll2()
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_produto", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }
        

        //select
        public Produto Select(int id)
        {
            Produto obj = null;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_produto WHERE pro_codigo = ?codigo", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new Produto();
                obj.Codigo = Convert.ToInt32(objDataReader["pro_codigo"]);
                obj.Nome = Convert.ToString(objDataReader["pro_nome"]);
                obj.Datacadastro = Convert.ToString(objDataReader["pro_datacadastro"]);
                obj.PrecoVenda = Convert.ToDouble(objDataReader["pro_precovenda"]);
            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();
            return obj;
        }
        //update
        public bool Update(Produto produto)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "UPDATE tbl_produto SET pro_nome=?nome, pro_datacadastro=?datacadastro, pro_precovenda=?precovenda WHERE pro_codigo=?codigo";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?nome", produto.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?datacadastro", produto.Datacadastro));
            objCommand.Parameters.Add(Mapped.Parameter("?precovenda", produto.PrecoVenda));
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", produto.Codigo));
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
            string sql = "DELETE FROM tbl_produto WHERE pro_codigo=?codigo";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }
       
        //construtor
        public ProdutoBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}