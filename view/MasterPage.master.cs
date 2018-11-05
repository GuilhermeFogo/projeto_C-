using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    private ConexaoDB con;

    protected void Page_Load(object sender, EventArgs e)
    {
        ConexaoDB conexaoDB = con = new ConexaoDB();
        conexaoDB.conectar();
        
    }



    protected void btn_inserir(object sender, EventArgs e)
    {
        Helper_campos campos = new Helper_campos();
        campos.Val_bairro = this.campo_bairro.Text;
        campos.Val_nome = this.campo_nome.Text;
        campos.Val_rua = this.campo_rua.Text;
        campos.Val_senha = this.campo_senha.Text;
        campos.Val_telefone = this.campo_tel.Text;
        campos.Val_email = this.campo_email.Text;
        Cliente cliente = new Cliente();
         bool verifica = campos.pega_campos(cliente);
        if (verifica)
        {
            this.con.inserir(cliente);
        }
        else
        {
            // mensagem
        }

       
        
    }
    

    protected void btn_deleta(object sender, EventArgs e)
    {
        Helper_campos campos = new Helper_campos();
        campos.Val_bairro = this.campo_bairro.Text;
        campos.Val_nome = this.campo_nome.Text;
        campos.Val_rua = this.campo_rua.Text;
        campos.Val_senha = this.campo_senha.Text;
        campos.Val_telefone = this.campo_tel.Text;
        campos.Val_email = this.campo_email.Text;
        Cliente cliente = new Cliente();
        bool verifica = campos.pega_campos(cliente);
        if (verifica)
        {
            this.con.deletar(cliente);
        }
        else
        {
            // mensagem
        }
    }

    protected void btn_atualiza(object sender, EventArgs e)
    {
        Helper_campos campos = new Helper_campos();
        campos.Val_bairro = this.campo_bairro.Text;
        campos.Val_nome = this.campo_nome.Text;
        campos.Val_rua = this.campo_rua.Text;
        campos.Val_senha = this.campo_senha.Text;
        campos.Val_telefone = this.campo_tel.Text;
        campos.Val_email = this.campo_email.Text;
        Cliente cliente = new Cliente();
        bool verifica = campos.pega_campos(cliente);
        if (verifica)
        {
            this.con.atualizar(cliente);
        }
        else
        {
            // mensagem
        }
    }

    protected void btn_consultar_Click(object sender, EventArgs e)
    {
        Helper_campos campos = new Helper_campos();
        String dado = this.con.listar();
        campos.Val_bairro = dado;
        campos.Val_nome = dado;
        campos.Val_rua = dado;
        campos.Val_senha = dado;
        campos.Val_telefone = dado;
        campos.Val_email = dado;

    }
}
