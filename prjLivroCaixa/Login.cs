using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjLivroCaixa.Classes;

namespace prjLivroCaixa
{
    public partial class Login: Form
    {
        private static List<Usuario> usuarios;
        private static string arquivo = "listaUsuarios.dat";
        public Login()
        {
            InitializeComponent();
            if (usuarios == null)
            {
                if (File.Exists(arquivo))
                {
                    usuarios = Serializa.DesserializaUsuario(arquivo);
                }
                else
                {
                    usuarios = new List<Usuario>();
                }
            }
        }

        private void lbTitulo_Click(object sender, EventArgs e)
        {

        }

        private void pnTrocaSenha_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btAcesso_Click(object sender, EventArgs e)
        {
            foreach (Usuario u in usuarios)
            {
                if (u.Login.Equals(tbLogin.Text))
                {


                    if (tbSenha.Text.Equals(u.Cpf) && u.PrimeiroAcesso == true)
                    {
                        lbMensagem.Text = "";
                        pnTrocaSenha.Visible = true;

                       
                        return;
                    }
                    if (tbLogin.Text.Equals(u.Login) && u.PrimeiroAcesso == false && tbSenha.Text != u.Senha)
                    {
                        lbMensagem.Text = "Senha incorreta";
                        return;
                    }
                   

                    if (tbSenha.Text.Equals(u.Senha))
                    {
                        Hide();
                        LivroCaixaForm frm = new LivroCaixaForm();
                        frm.Show();
                        return;
                    }

                }



                lbMensagem.Text = "Usuário não cadastrado";


            }
       

            

        }

        private void tbSenha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void lbSenha_Click(object sender, EventArgs e)
        {

        }

        private void lbLogin_Click(object sender, EventArgs e)
        {

        }

        private void btOkPainel_Click(object sender, EventArgs e)
        {
            String erro = Util.ValidaSenha(tbSenhaA.Text);

            if (erro != "")
            {
                lbMensagem.Text = erro; //a variavel erro guarda o retorno do metodo valida senha,e por ser uma string e o metodo retornar a string,guarda a senha aq
                return;
            }

            if (tbSenhaA.Text != tbSenhaB.Text)
            {
                lbMensagem.Text = "Senhas diferentes";
                return;
            }

            if(tbSenhaA.Text  == tbSenha.Text)
            {
                lbMensagem.Text = "Senha não pode ser igual ao CPF";
                return;
            }

            lbMensagem.Text = "";

            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Login.Equals(tbLogin.Text))
                {
                   usuario.AlteraAcesso();
                    usuario.TrocaSenha(tbSenhaA.Text);
                    Serializa.SerializaUsuario(usuarios, arquivo);
                    pnTrocaSenha.Visible = false;
                    tbLogin.Text = tbSenha.Text = lbMensagem.Text = "";
                    return;
                }
            }

            lbMensagem.Text = "Usuario não encontrado";

        }
    }
}
