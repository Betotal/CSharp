using Aula8.Classes;
using Aula8.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula8.Service
{
    class PessoaService:IPessoaService
    {
        private List<Pessoa> pessoas = new List<Pessoa>();

        public List<Pessoa> FiltrarPorIdade(int idadeMin, List<Pessoa> pessoas)
        {
            return pessoas.Where(p => p.IdadeGet >= idadeMin).ToList();
        }

        public List<Pessoa> LerArquivo(string caminho)
        {
            //LeitorArquivoTexto x = new LeitorArquivoTexto();
            //List<Pessoa> retorno = x.LeituraArquivo(caminho);
            //return retorno;
            return new LeitorArquivoTexto().LeituraArquivo(caminho);
        }

    }
}
