using Aula8.Classes;
using System.Collections.Generic;

namespace Aula8.Interfaces
{
    public interface ILeitorArquivo
    {
        List<Pessoa> LeituraArquivo(string caminho);
    }
}
