// See https://aka.ms/new-console-template for more information
namespace S1A5;

class Pessoa
{
    //field
    public string nome;
    public int idade;
    public string genero;

    //Construtor
    public Pessoa()
    {

    }
    public Pessoa(string nome, int idade, string genero)
    {
        this.nome = nome;
        this.idade = idade;
        this.genero = genero;
    }

    //método
    public void Identificar()
    {
        Console.WriteLine($"Olá, sou o {nome}. Tenho {idade} anos e sou do sexo {genero} .");

    }
}
