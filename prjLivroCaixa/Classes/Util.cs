using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjLivroCaixa.Classes
{
    class Util
    {
        public static bool ValidarCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

        public static string FormataCpf(String cpf)
        {
            cpf = cpf.Replace(".", "").
                Replace("-", "").
                Replace("/", "").
                Replace(" ", "");

            if (cpf.Length != 11)
            {
                return "";
            }

            if (!double.TryParse(cpf, out double d))
            {
                return "";
            }

            return
                cpf.Substring(0, 3) + "." +
                cpf.Substring(3, 3) + "." +
                cpf.Substring(6, 3) + "-" +
                cpf.Substring(9, 2);

        }
        public static String ValidaSenha(String senha)
        {
            if (senha.Length < 8)
            {
                return "Use pelo menos 8 caracteres";
            }

            int cMa = 0, cMi = 0, cN = 0, cE = 0;

            char[] vet = senha.ToCharArray();

            foreach (char ch in vet)
            {
                if (ch >= 'A' && ch <= 'Z') cMa++;
                else if (ch >= 'a' && ch <= 'z') cMi++;
                else if (ch >= '0' && ch <= '9') cN++;
                else cE++;
            }

            if (cMa == 0) return "Precisa de um caracter maiúsculo";
            if (cMi == 0) return "Precisa de um caracter minúsculo";
            if (cN == 0) return "Precisa de um caracter numérico";
            if (cE == 0) return "Precisa de um caracter especial";


            return "";
        }
    }
}
