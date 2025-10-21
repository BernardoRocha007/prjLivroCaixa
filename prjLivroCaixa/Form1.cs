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
    public partial class frmCadUser : Form
    {

		private static int posicao;

        private static int posicaoAchei = -1;

        private static string arquivo = "listaUsuarios.dat";

        private static Usuario usuario;

        static List<Usuario> usuarios; //oq pertence a classe é criado quando o programa começa a rodar,oq é criado pelo formulario,ele e sempre resetado,e ao ser estatico os dados se mantem sempre que abre o programa
		private void frmCadUser_Load(object sender, EventArgs e)
		{
            usuario = new Usuario("Bernardo", "", "",'A') ;
			if(usuarios == null)
            {
				usuarios = new List<Usuario>();
            }
            
		}
		public frmCadUser()
        {
            InitializeComponent();

            if (usuarios == null)
            {
                if (File.Exists(arquivo))
                {
                    usuarios = Serializa.DesserializaUsuario(arquivo);
                    Usuario.AcertaContador(usuarios);
                    tbRelatorio.Text = Relatorio();
                }
                else
                {
                    usuarios = new List<Usuario>();
                }
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
			posicao = -1;
            tbCpf.Text = 
                tbLogin.Text =
                tbNome.Text =
				tbBuscar.Text =
                lbMensagem.Text = String.Empty;

            rbUsuario.Checked = rbAdm.Checked = false;

            if (btOk.Text.Equals("Alterar"))
            {
               
                AlteraInterface();
                btOk.Text = "Cadastrar";
            }

            tbCpf.Enabled =
                tbLogin.Enabled = true;

            posicaoAchei = -1;

        }

		
		private void Alterar() {
            Usuario u = usuarios[posicao];
            u.Altera(tbNome.Text, rbAdm.Checked ? 'A' : 'U');
            
        }


        private void btOk_Click(object sender, EventArgs e)
        {

            if (tbNome.Text.Trim().Equals(string.Empty)) //trim remove espaço antes e depois do nome
            {
                lbMensagem.Text = "Nome é obrigatório";
                return;
            }

            if (!Util.ValidarCpf(tbCpf.Text))
            {

                lbMensagem.Text = "CPF inválido";
                return;
            }

            if (tbLogin.Text.Trim().Equals(string.Empty))
            {
                lbMensagem.Text = "Login é obrigatório";
                return;
            }
            if (!rbAdm.Checked && !rbUsuario.Checked)
            {
                lbMensagem.Text = "Selecione o perfil";
                return;
            }

            if (posicaoAchei >= 0) // Está alterando
            {
                usuarios[posicaoAchei].Altera(tbNome.Text,
                   (rbAdm.Checked ? 'A' : 'U'));

                tbRelatorio.Text = Relatorio();
                Serializa.SerializaUsuario(usuarios, arquivo);
                return;
            }

            foreach (Usuario u in usuarios)
            {
                if (u.Cpf.Equals(tbCpf.Text))
                {
                    lbMensagem.Text = "Cpf ja esta em uso";
                    return;
                }

                if (u.Login.Equals(tbLogin.Text))
                {
                    lbMensagem.Text = "Login ja cadastrado";
                    return;
                }

            }

            Usuario usuario = new Usuario(
                tbNome.Text,
                Util.FormataCpf(tbCpf.Text),
                tbLogin.Text,
                (rbAdm.Checked ? 'A' : 'U'));

            usuarios.Add(usuario);
            usuarios.Sort();  //pq tem um metodo compare to na classe usuario que diz qual o criterio de ordenação*
                              //Sort() ordena a lista usando o método CompareTo dos objetos.
                              // No seu caso, ordena os usuários pelo campo registro.
                              //É comum chamar Sort() após adicionar novos itens para manter a lista ordenada.
            tbRelatorio.Text = Relatorio();

            if (btOk.Text.Equals("Alterar"))
            {
                Alterar();
                tbRelatorio.Text = Relatorio();
                AlteraInterface();
                btOk.Text = "Cadastrar";


            }
            Serializa.SerializaUsuario(usuarios, arquivo);
            btLimpar_Click(sender, e);

        }

		private string Relatorio()
        {
			StringBuilder str = new StringBuilder(); //StringBuilder é uma classe eficiente para construir strings grandes concatenando várias partes, evitando criar muitas strings temporárias (mais performático que usar + repetidamente).
			foreach(Usuario u in usuarios)
            {
				str.AppendLine(u.ToString());

            }
			return str.ToString();
        }



        private void btBuscar_Click(object sender, EventArgs e)
        {
			if(!int.TryParse(tbBuscar.Text,out int num)) 
			{
				lbMensagem.Text = "Digitação de número registro inválido";
					return;
			}

			Usuario fajuto = new Usuario(num.ToString("D4"));
			int pos = usuarios.BinarySearch(fajuto);

		     if(pos < 0)
            {
				lbMensagem.Text = "Nao existe ninguem com esse registro";
				return ;
            }
             tbLogin.Enabled = 
                tbCpf.Enabled = false;
            posicaoAchei = pos;
            posicao = pos;
			Mostra(usuarios[pos]);
            btReiniciar.Enabled = true;
			AlteraInterface();


        }

		private void Mostra(Usuario u)
        {
			tbNome.Text = u.Nome;
			tbCpf.Text = u.Cpf;
			tbLogin.Text = u.Login;


			rbAdm.Checked = u.Perfil == 'A';
			rbUsuario.Checked = u.Perfil == 'U';

			
        }

       

		private void AlteraInterface() 
		{
            if (btOk.Text.Equals("Cadastrar"))
            {
                btOk.Text = "Alterar";
                btExcluir.Enabled = true;

                tbLogin.Enabled =
                    tbCpf.Enabled = false;
            }


        }


        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (posicaoAchei == -1)
            {
                return;
            }
            usuarios.Remove(usuarios[posicaoAchei]);
            btLimpar_Click(sender, e);
            tbRelatorio.Text = Relatorio();
            Serializa.SerializaUsuario(usuarios, arquivo);
        }

        private void btSairCad_Click(object sender, EventArgs e)
        {
            Hide();
            Login log = new Login();
            log.Show();
        }

        private void btReiniciar_Click(object sender, EventArgs e)
        {
            if (posicaoAchei == -1)
            {
                return;
            }

            usuarios[posicaoAchei].TrocaSenha(usuarios[posicaoAchei].Cpf);
            usuarios[posicaoAchei].PrimeiroAcesso = true;
            tbRelatorio.Text = Relatorio();
            Serializa.SerializaUsuario(usuarios, arquivo);
        }
    }
}
