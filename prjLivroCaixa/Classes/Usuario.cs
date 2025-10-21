using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjLivroCaixa.Classes
{
    [Serializable]
    public class Usuario:IComparable<Usuario>//IComparable<Usuario> é uma interface genérica que a classe está implementando.Essa interface obriga a classe a implementar o método CompareTo para comparar objetos do tipo Usuario.
//Icomparable é uma interface que permite a comparação de objetos do mesmo tipo
    {

        
        public string Nome { get; private set; }

        public string Cpf { get; private set;}

        public string Login { get; private set; }

        public string Senha { get; private set; }

        public char Perfil { get; private set; }

        private static int contador;

        public string registro;

      public bool PrimeiroAcesso { get; private set; } = true;


        public void TrocaSenha(string senha)
        {
            Senha = senha;
        }

        public Usuario(String registro)
        {
            this.registro = registro; //sobrecarga
        }

        public Usuario(string nome, string cpf, string login, char perfil)
        {
            Nome = nome;
            Senha = Cpf = cpf;
            Login = login;
            Perfil = perfil;

            registro = (++contador).ToString("D4"); //formata o numero para 4 casas decimais
        }

        int IComparable<Usuario>.CompareTo(Usuario other) // esse é o metodo que a interface obriga a usar
         // Um número negativo se o objeto atual for "menor" que other.
        //Zero se forem "iguais".
        //Um número positivo se o objeto atual for "maior" que other.
       

        {
            return registro.CompareTo(other.registro); // aqui faz com que o C# quer ordenar e procurar pelo registro
            //esse compare compara o registro em ordem alfabetica *
        }

        public  override String ToString() //estou sobrescrevendo o metodo tostring da classe object
        {
            return registro + ", " +
                Nome + ", " +
                Cpf + ", " +
                Login + ", " +
                Perfil + ", " +
                (Senha.Equals(Cpf) ? "Não trocou a senha" : "Trocou  a senha");

        }
        public void Altera(string nome,char perfil)
        {
            Nome = nome;
            Perfil= perfil;
        }

        public static void AcertaContador(List<Usuario> lista)
        {
            String ultimo = lista[lista.Count - 1].registro;
            int.TryParse(ultimo, out contador);
        }

       public void AlteraAcesso()
        {
            PrimeiroAcesso = false;

           


        }
         
    }

}
