using Aula8.Classes;
using System.Collections.Generic;

namespace Aula8.Interfaces
{
    public interface IPessoaService
    {
        List<Pessoa> LerArquivo(string caminho);
        List<Pessoa> FiltrarPorIdade(int idadeMin, List<Pessoa> pessoas);
    }
}
