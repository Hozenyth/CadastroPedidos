

using CpmPedidos.Domain.Interfaces;
using System.Collections.Generic;

namespace CpmPedidos.Domain.Entities
{
    public class PromocaoProduto : BaseDomain, IExebivel
    {           
        public string Nome { get; set; }
        public decimal Preco { get; set; }
       
        public bool Ativo { get; set; }

        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }

        public int ImagemId { get; set; }
        public virtual Imagem Imagem { get; set; }     
    }
}
