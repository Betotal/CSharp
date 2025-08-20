using Aula8.Classes;
using System.Collections.Generic;

namespace Aula8.Interfaces
{
    public interface IPessoaService
    {
        void  LerArquivo(string caminhoArq);
        List<Pessoa> PegarTodos();
        List<Pessoa> FiltrarPorIdade(int idadeMinima);

    }
}
