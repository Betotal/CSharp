using Aula8.Classes;
using Aula8.Enum;
using Aula8.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace Aula8
{
    public class LeitorArquivoTexto : ILeitorArquivo
    {
        public List<Pessoa> LeituraArquivo(string caminho)
        {
            var lista = new List<Pessoa>();
            if (File.Exists(caminho))
            {
                try
                {
                    using (StreamReader leitor = new StreamReader(caminho)) //realiza leitura no arquivo
                    {
                        string linha;
                        while ((linha = leitor.ReadLine()) != null)
                        {
                            var partes = linha.Split(';');
                            lista.Add(new Pessoa(partes[0], int.Parse(partes[1]), partes[2] == "Feminino" ? EnumGenero.Feminino : EnumGenero.Masculino));
                        }
                    }
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Erro ao abrir arquivo: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro: " + ex.Message);
                }
            }
            return lista;

        }
    }
}
