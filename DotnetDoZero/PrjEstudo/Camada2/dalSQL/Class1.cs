using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Modelo;

namespace dalSQL
{
    public class Class1
    {
        public Class1(){
            Console.WriteLine("Estou na camada 2 - SQL");
            Console.WriteLine();
        /* 
            using SQLContexto ctxCat = new SQLContexto();
            ctxCat.Categoria.ToList().ForEach(c => Console.WriteLine(c.NOME));

            using SQLContexto ctxPdt = new SQLContexto();
            ctxPdt.Produtos.ToList().ForEach(p => Console.WriteLine(p.NOME));
        */
            using (SQLContexto ctx = new SQLContexto())
            {

                Produto? produto = new Produto();
                Estoque? estoque = new Estoque();

                produto.NOME = "Camisa8 dalSQL";
                produto.COR = "Céu Azul";
                ctx.Product.Add(produto);   //Adiciona na tabela Produto
                ctx.SaveChanges();           //efetiva a gravação

                estoque.PRODUTOID = produto.ID;
                estoque.QTDE = 32;
                estoque.LOCAL = "Prateleira 1";
                ctx.Stock.Add(estoque);   //Adiciona na tabela Produto
                ctx.SaveChanges();           //efetiva a gravação

                produto = new Produto();
                estoque = new Estoque();

                produto.NOME = "Camisa9 dalSQL";
                produto.COR = "Azul metálico";
                estoque.QTDE = 31;
                estoque.LOCAL = "Prateleira 2";

                produto.Mass = estoque;
                ctx.Product.Add(produto);
                ctx.SaveChanges(); 
            //    Funcoes.Adicionar(produto);

            /*    
                Console.WriteLine("Estou na Categoria - SQL");
                Console.WriteLine();
                ctx.Categoria.ToList().ForEach(c => Console.WriteLine(c.NOME));

                Console.WriteLine("Estou na Produto - SQL");
                Console.WriteLine();
                ctx.Produtos.ToList().ForEach(p => Console.WriteLine(p.NOME));
            */    
            }
        }
    }
}