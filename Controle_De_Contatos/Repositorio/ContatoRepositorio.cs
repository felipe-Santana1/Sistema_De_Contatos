using Controle_De_Contatos.Data;
using Controle_De_Contatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controle_De_Contatos.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext1;
        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext1 = bancoContext;
        }
        public ContatoModel ListarPorId(int id)
        {
            return _bancoContext1.Contatos.FirstOrDefault(x  =>  x.Id  == id);
        }
        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext1.Contatos.ToList();
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
            //Gravar no Banco de dados
            _bancoContext1.Contatos.Add(contato);
            _bancoContext1.SaveChanges();
            return contato;
        }

    }
}
