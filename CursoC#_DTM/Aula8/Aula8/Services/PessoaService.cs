using Aula8.Arquivos;
using Aula8.Classes;
using Aula8.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula8.Services
{
    class PessoaService : IPessoaService
    {
        private List<Pessoa> pessoas = new List<Pessoa>();
        public List<Pessoa> FiltrarPorIdade(int idadeMinima)
        {
            return pessoas.Where(pes => pes.Idade >= idadeMinima).ToList();
        }

        public void LerArquivo(string caminhoArq)
        {
            //LeitorArquivoTexto leitor = new LeitorArquivoTexto();
            //List<Pessoa> Lista = leitor.LeituraArquivo(caminhoArq);
            //return Lista;
            pessoas = new LeitorArquivoTexto().LeituraArquivo(caminhoArq);
        }

        public List<Pessoa> PegarTodos()
        {
            return pessoas;
        }
    }
}
