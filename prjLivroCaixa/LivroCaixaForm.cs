using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using prjLivroCaixa.Classes;

namespace prjLivroCaixa
{
    public partial class LivroCaixaForm: Form
    {
        private static LivroCaixa livro;

        private static Usuario usuario;

        private static String nomeArquivo = "Lancamentos.dat";
        public LivroCaixaForm()
        {
            InitializeComponent();

            usuario = new Usuario("Bernardo", "", "", 'A');
            if (livro == null)
            {
                livro = new LivroCaixa(DateTime.Now, 1000, nomeArquivo);
                tbRelatorio.Text = livro.Relatorio();
            }

            lbTitulo.Text = "Livro Caixa da Rapaziada" + livro.Identificador.ToString("yyyy/MM");
        }
       
        private void btOk_Click(object sender, EventArgs e)
        {
            if (!DateTime.TryParse(tbData.Text, out DateTime data))
            {
                lbMensagem.Text = "Data inválida";
                return;
            }
            if (!decimal.TryParse(tbValor.Text, out decimal valor) || valor < 0)
            {
                lbMensagem.Text = "Valor Inválido";
                return;
            }
            if (tbDescricao.Text == "")
            {
                lbMensagem.Text = "Obrigatório digitar a descrição!";
                return;
            }

            if (!rbCredito.Checked && !rbDebito.Checked)
            {
                lbMensagem.Text = "Selecione se credito ou debito!";
                return;
            }

            Lancamento lan = new Lancamento(data, usuario, tbDescricao.Text,
                rbCredito.Checked ? 'C' : 'D', valor);
            livro.Add(lan);
            tbRelatorio.Text = livro.Relatorio();
            livro.Salvar(nomeArquivo);

            tbData.Text = tbDescricao.Text = tbValor.Text = "";
            rbCredito.Checked = rbDebito.Checked = false;
        }
    }
}
