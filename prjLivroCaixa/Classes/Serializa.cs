﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace prjLivroCaixa.Classes
{
    class Serializa
    {
        public static void SerializaLancamento(List<Lancamento> lista, String arq)
        {
            using (FileStream fs = new FileStream(arq, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, lista);
            }
        }
        public static List<Lancamento> DesserializaLancamento(String arq)
        {
            using (FileStream fs = new FileStream(arq, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (List<Lancamento>)formatter.Deserialize(fs);

            }
        }
        public static void SerializaUsuario(List<Usuario> lista, String arq)
        {
            using (FileStream fs = new FileStream(arq, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, lista);
            }
        }
        public static List<Usuario> DesserializaUsuario(String arq)
        {
            using (FileStream fs = new FileStream(arq, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (List<Usuario>)formatter.Deserialize(fs);

            }
        }
    }
}
