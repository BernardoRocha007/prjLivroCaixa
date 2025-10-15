using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjLivroCaixa.Classes
{
    [Serializable]
   public class Lancamento : IComparable<Lancamento>
    {
        public string Id { get; private set; }
        public DateTime Data { get; private set; }
        public string Descricao { get; private set; }
        public char Tipo { get; private set; }
        public Usuario Responsavel { get; private set; }

        public decimal Valor { get; private set; }

        private static int contador = 0;

        public override string ToString()
        {
            return String.Concat(

                Id, ", ",
                Data.ToString("dd/MM/yyyy"), ", ",
                Descricao, ", ",
                Responsavel.Nome, ", ",
                Tipo == 'C' ? "Crédito" : "Débito", ", ",
                String.Format(" R$ {0:###,###.00}", Valor)

                );
        }

        public static void AcertaContador(List<Lancamento> lista)
        {
            if (lista.Count == 0)
            {
                contador = 0;
                return;
            }
            String id = lista[lista.Count - 1].Id;
            int.TryParse(id, out contador);
        }

        public Lancamento(
            DateTime data,
            Usuario responsavel,
            string descricao,
            char tipo,
            decimal valor)
        {
            Data = data;
            Responsavel = responsavel;
            Descricao = descricao;
            Tipo = tipo;
            Valor = valor;
            Id = (++contador).ToString("D6");
        }

        int IComparable<Lancamento>.CompareTo(Lancamento lan)
        {
            return Id.CompareTo(lan.Id);
        }
    }
}

