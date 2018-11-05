using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Helper_campos
/// </summary>
public class Helper_campos{

    private String val_nome;
    private String val_senha;
    private String val_rua;
    private String val_cep;
    private String val_bairro;
    private String val_telefone;
    private String val_email;

    public Helper_campos()
    {
        //
        // TODO: Adicionar lógica do construtor aqui
        //
    }

    public string Val_nome { get => val_nome; set => val_nome = value; }
    public string Val_senha { get => val_senha; set => val_senha = value; }
    public string Val_rua { get => val_rua; set => val_rua = value; }
    public string Val_cep { get => val_cep; set => val_cep = value; }
    public string Val_bairro { get => val_bairro; set => val_bairro = value; }
    public string Val_telefone { get => val_telefone; set => val_telefone = value; }
    public string Val_email { get => val_email; set => val_email = value; }

    public bool pega_campos(Cliente cliente)
    {
        if (this.val_bairro.Equals(null) || this.val_cep.Equals(null) || this.val_email.Equals(null) || this.val_nome.Equals(null)
            || this.val_rua.Equals(null) || this.Val_senha.Equals(null))
        {
            cliente.Senha = Val_senha;
            cliente.Telefone = Val_telefone;
            cliente.Nome = Val_nome;
            cliente.Rua = Val_rua;
            cliente.Email = Val_email;
            cliente.Bairro = Val_bairro;
            cliente.Cep = Val_cep;

            return true;
        }
        else
        {
           
            return false;
        }

    }
}