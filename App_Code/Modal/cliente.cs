using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de cliente
/// </summary>
public class Cliente
{
    private String nome;
    private String senha;
    private String rua;
    private String cep;
    private String bairro;
    private String telefone;
    private String email;

    public cliente()
    {
      
    }

    public cliente(string nome, string senha, string rua, string cep, string bairro, string telefone, string email)
    {
        this.Nome = nome;
        this.Senha = senha;
        this.Rua = rua;
        this.Cep = cep;
        this.Bairro = bairro;
        this.Telefone = telefone;
        this.Email = email;
    }

    public string Nome { get => nome; set => nome = value; }
    public string Senha { get => senha; set => senha = value; }
    public string Rua { get => rua; set => rua = value; }
    public string Cep { get => cep; set => cep = value; }
    public string Bairro { get => bairro; set => bairro = value; }
    public string Telefone { get => telefone; set => telefone = value; }
    public string Email { get => email; set => email = value; }
}