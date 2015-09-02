using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaAgenda.model
{
    class Contato
    {
        private int id;
        private string nome;
        private string email;
        private string telefone;

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string Telefone
        {
            get { return this.telefone; }
            set { this.telefone = value; }
        }

    }
}
