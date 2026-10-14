using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO
{
    internal class Contato
    {
        public string Nome;
        public string Telefone;
        public string Email;

        public Contato(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }

        public Contato(string nome, string telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }
    }
}
