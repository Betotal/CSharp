// See https://aka.ms/new-console-template for more information

using Microsoft.Win32.SafeHandles;
using Modelo;

Console.WriteLine("Hello, World!");

//dalSQL.Class1 SQL = new dalSQL.Class1();

dalSQL.Funcoes funcao = new dalSQL.Funcoes();

// criando objetos
Produto produto = new Produto();
Estoque estoque = new Estoque();

// //Adicionar Produto 1
// produto.NOME = "Sapato";
// produto.COR = "Azul";
// funcao.Adicionar(produto); // Adicionando produto e salvando

// //estoque.PRODUTOID = produto.ID;
// estoque.PRODUTOID = produto.ID;
// estoque.QTDE = 100;
// estoque.LOCAL = "Expedição";
// funcao.Adicionar(estoque); // Adicionando produto e salvando


// produto.Mass = estoque;  //Adiciona o Estoque ao produto (FK)
// funcao.Adicionar(produto);

// //Adicionar Produto 2
// produto = new Produto();
// estoque = new Estoque();
// produto.NOME = "Sapato";
// produto.COR = "Preto";

// estoque.QTDE = 13;
// estoque.LOCAL = "Indeterminado";

// produto.Mass = estoque;  //Adiciona o Estoque ao produto (FK)
// funcao.Adicionar(produto);

// //Adicionar Produto 3
// produto = new Produto();
// estoque = new Estoque();
// produto.NOME = "Sapato";
// produto.COR = "Branco";

// estoque.QTDE = 33;
// estoque.LOCAL = "Recebimento";

// produto.Mass = estoque;  
// funcao.Adicionar(produto);

// //Alterar Produto 3, ID = 1
// produto = new Produto();
// produto.ID = 3;
// produto.NOME = "Camisa3 dalSQL";
// produto.COR = "Preta";
// funcao.Atualizar(produto);

// //Alterar Produto 5
// produto = new Produto();
// produto.ID = 6;
// produto.NOME = "Camisa6 dalSQL";
// funcao.Atualizar(produto);

// Alterar Entity
produto.ID = 8;
produto.NOME = "Sapato 41";
produto.COR = "Preto";
funcao.EntityAlterar(produto);

produto = new Produto();
produto.ID = 10;
produto.NOME = "Sapatenis Social";
produto.COR = "Bege";
funcao.Atualizar(produto);

produto = new Produto();
produto.ID = 4;
funcao.Excluir(produto);

funcao.Excluir(5);







Console.ReadLine();