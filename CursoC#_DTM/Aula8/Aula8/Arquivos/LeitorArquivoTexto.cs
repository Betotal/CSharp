using Aula8.Classes;
using Aula8.Enum;
using Aula8.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula8.Arquivos
{
    public class LeitorArquivoTexto : ILeitorArquivoPessoa
    {
        public List<Pessoa> LeituraArquivo(string caminhoArq)
        {
            var lista = new List<Pessoa>();
            if (File.Exists(caminhoArq))
            {
                try
                {
                    using StreamReader leitor = new StreamReader(caminhoArq);
                    string linha;
                    while ((linha = leitor.ReadLine()) != null)
                    {
                        var partes = linha.Split(';');
                        lista.Add(new Pessoa(partes[0], int.Parse(partes[1]), GeneroEnum(partes[2])));
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine($"Exemplo erro de abertura do arquivo {e.Message}");
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Ocorreu o erro: {e.Message}");
                }
            }
            return lista;
        }

        private EnumGenero GeneroEnum(string genero)
        {
            if (genero == "Masculino")
            {
                return EnumGenero.Masculino;

            }else if (genero == "Feninino")
            {
                return EnumGenero.Feminino;
            }
            else
            {
                return EnumGenero.Outro;
            }
        }
    }
}
