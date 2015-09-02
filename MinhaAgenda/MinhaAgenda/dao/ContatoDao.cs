using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaAgenda.model;

namespace MinhaAgenda.dao
{
    class ContatoDao
    {
        IList<Contato> contatos;
        public ContatoDao()
        {
            contatos = new List<Contato>();
        }

        public void adicionarContato(Contato contato)
        {
            contatos.Add(contato);
        }
        public void removerContato(Contato contato)
        {

        }
        public void atualizarContato(Contato contato)
        {

        }
        public void pegarPorId(int id)
        {

        }
        public IList<Contato> pegarTodos()
        {
            return contatos;
        }
    }
}
