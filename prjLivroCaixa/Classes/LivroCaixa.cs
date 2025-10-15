using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace prjLivroCaixa.Classes
{
    class LivroCaixa
    {
        public DateTime Identificador { get; private set; }
        public decimal ValorTransporte { get; private set; }

        private List<Lancamento> lancamentos;

        public void Add(Lancamento l)
        {
            lancamentos.Add(l);
        }

        public void Salvar(String arquivo)
        {
            Serializa.SerializaLancamento(lancamentos, arquivo);
        }

        public string Relatorio()
        {
            StringBuilder sb = new StringBuilder();

            decimal saldo = ValorTransporte;

            foreach (Lancamento lan in lancamentos)
            {
                saldo += lan.Tipo == 'C' ? lan.Valor : -lan.Valor;
                sb.AppendLine(lan.ToString() + ", " +
                    String.Format(" R${0:###,###.00}", saldo));
            }

            return sb.ToString();
        }

        public LivroCaixa(DateTime identificador, decimal valorTransporte, string nomeArquivo)
        {
            Identificador = identificador;
            ValorTransporte = valorTransporte;

            if (lancamentos == null)
            {
                if (File.Exists(nomeArquivo))
                {
                    lancamentos = Serializa.DesserializaLancamento(nomeArquivo);
                    Lancamento.AcertaContador(lancamentos);

                }
                else
                {
                    lancamentos = new List<Lancamento>();
                }
            }


        }
    }
}

