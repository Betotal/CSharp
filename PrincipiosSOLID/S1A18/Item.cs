using System;

namespace S1A18
{
    public class Item
    {
        /*   //  Modelo Anemico
        public int ItemId { get; set; }
        public int PedidoId { get; set; }
        public string ItemNome { get; set; }
        public decimal ItemPreco { get; set; }
        */

         //  Modelo Rico - Com validação na propria classe

        public Item(int itemId, int pedidoId, string itemNome, decimal itemPreco)
        {
            if (pedidoId <= 0){
                throw new ArgumentException("O Código do Pedico deve ser informado com valor maior que zero!");
            }
            if (itemId <= 0){
                throw new ArgumentException("O Código do Item deve ser informado com valor maior que zero!");
            }

            ItemId = itemId;
            PedidoId = pedidoId;
            ItemNome = itemNome;
            ItemPreco = itemPreco;
        }

        public int ItemId { get; private set; }
        public int PedidoId { get; private set; }
        private string _ItemNome;
        public string ItemNome{
            get  => _ItemNome; // (lambda)  or {return _ItemNome;} 
            private set{
                _ItemNome = (value.Length > 100)?
                            throw new ArgumentOutOfRangeException (nameof(ItemNome), 
                                   "O nome do item não podde excedoer 100 caracteres") : value;
            }
        }
        
        private decimal _ItemPreco;
        public decimal ItemPreco { 
            get => _ItemPreco;
            private set{
                _ItemPreco = (value <= 0)?
                    throw new ArgumentOutOfRangeException (nameof(ItemPreco), 
                                   "O preço do item deve ser maior que 0 (zero)!") : value;

            }
        }

    }
}