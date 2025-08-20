using Aula8.Classes;
using System.Collections.Generic;

namespace Aula8.Interfaces
{
    public interface ILeitorArquivoPessoa
    {
        List<Pessoa> LeituraArquivo(string caminhoArq);
    }
}
