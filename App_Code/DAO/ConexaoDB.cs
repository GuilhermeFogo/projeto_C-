using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using MongoDB.Driver.Core;

/// <summary>
/// Descrição resumida de ConexaoDB
/// </summary>
public class ConexaoDB
{
    private MongoClient conn;

    public void conectar()
    {
        String linha_conexao = "mongodb://localhost:8080";
        this.conn = new MongoClient(linha_conexao);
        this.conn.GetDatabase("teste_banco");

    }


    public void inserir(Cliente cliente)
    {
        String insert_mongo = "db.cliente.insert([" +
            "{nome:" + cliente.Nome + ",senha:" + cliente.Senha + ",telefone:" + cliente.Telefone + ",email:" + cliente.Email + ",rua:" +
            cliente.Rua + ",bairro:" + cliente.Bairro + "}])";
        try
        {
            // metodo.execute(inserir);
        }
        catch (MongoException e)
        {
            String menssagem = e.Message.ToString();
            Console.Out.WriteLine(menssagem);
        }
    }

    public void deletar(Cliente cliente)
    {
        String delete_mongo = "db.cliente.remove({ nome:" + cliente.Senha + "})";
        try
        {
            // metodo.execute(delete)
        }
        catch (MongoException e)
        {
            String menssagem = e.Message.ToString();
            Console.Out.WriteLine(menssagem);
        }
    }

    public void atualizar(Cliente cliente) {
        String update_mongo = "db.cliente.update([" +
            "{nome:" + cliente.Nome + ",senha:" + cliente.Senha + ",telefone:" + cliente.Telefone + ",email:" + cliente.Email + ",rua:" +
            cliente.Rua + ",bairro:" + cliente.Bairro + "}])";

        try
        {
            // metodo.execute(aualizar)
        }
        catch (MongoException e)
        {
            String menssagem = e.Message.ToString();
            Console.Out.WriteLine(menssagem);
        }
    }


    public String listar()
    {
        String listagem = "db.cliente.find()";
       
        try
        {
            // metodo.execute(listar)
        }
        catch (MongoException e)
        {
            String menssagem = e.Message.ToString();
            Console.Out.WriteLine(menssagem);
        }
        return listagem;
    }



}