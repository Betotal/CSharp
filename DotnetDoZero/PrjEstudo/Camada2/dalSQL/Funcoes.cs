using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Modelo;

namespace dalSQL
{
    public class Funcoes
    {

        public void ListarQuery()
        {
            using (SQLContexto ctx = new SQLContexto())
            {
                var Prod = ctx.Product.FromSqlRaw("Select * from Product");
                Prod.ToList().ForEach(obj => {Console.WriteLine(obj.NOME + "  |  " + obj.COR); }); 
            }
        }

        public void ListarPerformace()
        {
            using (SQLContexto ctx = new SQLContexto())
            {
                var Prod = ctx.Product.AsNoTracking().Where (obj => obj.COR == "Vermelho");
                Prod.ToList().ForEach(obj => {Console.WriteLine(obj.NOME + "  |  " + obj.COR); }); 
            }
        }

        public void Listar()
        {
            using (SQLContexto ctx = new SQLContexto())
            {
                var P1 = ctx.Product.Where(obj => obj.COR == "Vermelho"); // Lamda

                Console.WriteLine(P1);
                Console.WriteLine();

                Console.WriteLine(P1.ToList());
                Console.WriteLine();

                P1.ToList().ForEach(obj => {Console.WriteLine(obj.NOME + "  |  " + obj.COR); });
                Console.WriteLine();

                var ctxlinq = (from p in ctx.Product   //Linq
                                    where p.COR == "Vermelho"
                               select p).ToList();

                ctxlinq.ToList().ForEach(obj => {Console.WriteLine(obj.NOME + "  |  " + obj.COR); });                 
            }
        }

        public void ListaDinamico(string nome, string cor, int ? quantidade = null, string ? local = null)
        {
            using(SQLContexto ctx = new SQLContexto())
            {
  //              IQueryable<Produto> Prod = ctx.Product;
               IQueryable<Produto> Prod = ctx.Product.Include(est => est.Mass);
 
                if(!string.IsNullOrWhiteSpace(nome))
                {
                    Prod = Prod.Where(obj => obj.NOME.Contains(nome));  //obj.NOME.Equals(nome));
                }

                if(!string.IsNullOrWhiteSpace(cor))
                {
                    Prod = Prod.Where(obj => obj.COR.Contains(cor));   //obj.NOME.Equals(cor));
                }

                if(quantidade.HasValue)
                {
                    Prod = Prod.Where(obj => obj.Mass.QTDE > quantidade.Value);
                }

                if(!string.IsNullOrWhiteSpace(local))
                {
                    Prod = Prod.Where(obj => obj.Mass.LOCAL.Contains(local));
                }

                Prod.ToList().ForEach(obj => {Console.WriteLine(obj.NOME + "  |  " + obj.COR); });

            }
        } 

        public void SelecionarLambda(int id)
        {
            using (SQLContexto ctx = new SQLContexto())
            {
                Produto P1 = ctx.Product.Find(id);
                Produto P2 = ctx.Product.FirstOrDefault(p => p.ID == id + 3);

                Console.WriteLine(P1.NOME + "  |  " + P1.COR);
                Console.WriteLine(P2.NOME + "  |  " + P2.COR);
            }
        }

        public void SelecionarLinq(int id)
        {
            using (SQLContexto ctx = new SQLContexto())
            {
                Produto P3 = (from p in ctx.Product
                                  where p.ID == id
                              select p ).FirstOrDefault();
                
                Console.WriteLine(P3.NOME + "  |  " + P3.COR);

            }
        }

        public void Adicionar(Produto p)
        {
            using (SQLContexto ctx = new SQLContexto())
            {
                ctx.Product.Add(p);
                ctx.SaveChanges();
            }
        }
        public void Adicionar(Estoque e)
        {
            using (SQLContexto ctx = new SQLContexto())
            {
                ctx.Stock.Add(e);
                ctx.SaveChanges();
            }
        }

        public void Atualizar(Produto p)
        {
            using (SQLContexto ctx = new SQLContexto())
            {
                var findProduto = ctx.Product.FirstOrDefault( fp => fp.ID == p.ID);
                if (findProduto == null) return;

                if (findProduto.NOME != p.NOME || findProduto.COR != p.COR)
                {
                    if (findProduto.NOME != p.NOME && p.NOME != null)
                       findProduto.NOME = p.NOME;

                    if (findProduto.COR  != p.COR && p.COR != null) 
                       findProduto.COR   = p.COR;

                    ctx.SaveChanges();
                }
            }
        }

        public void EntityAlterar(Produto p)
        {
            using (SQLContexto ctx = new SQLContexto())
            {
                ctx.Entry(p).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void Excluir(Produto p)
        {
            using (SQLContexto ctx = new SQLContexto())
            {
                // deleção trazendo o objeto para o contexto
            //    var findProduto = ctx.Product.FirstOrDefault( fp => fp.ID == p.ID);
            //    if (findProduto == null) return;
                
            //    ctx.Product.Remove(findProduto);

                // deleção apenas com EF usando apenas o objeto
                ctx.Entry(p).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;

                ctx.SaveChanges();
            }
        }

        public void Excluir(int id)
        {
            using (SQLContexto ctx = new SQLContexto())
            {
                var findProduto = ctx.Product.FirstOrDefault( fp => fp.ID == id);

                if (findProduto == null) return;

                ctx.Product.Remove(findProduto);
                ctx.SaveChanges();
            }
        }
    }
}