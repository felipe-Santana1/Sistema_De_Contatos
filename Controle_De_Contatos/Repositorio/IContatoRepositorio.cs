using Controle_De_Contatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controle_De_Contatos.Repositorio
{
   public interface IContatoRepositorio
    {
        ContatoModel ListarPorId(int id);

        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato); 
    }
}
