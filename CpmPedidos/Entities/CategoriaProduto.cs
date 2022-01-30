

using CpmPedidos.Domain.Interfaces;
using System.Collections.Generic;

namespace CpmPedidos.Domain.Entities
{
    public class CategoriaProduto : BaseDomain, IExebivel
    {            
        public string Nome { get; set; }     
        public bool Ativo { get; set; }

        public virtual List<Produto> Produtos { get; set; }
    }
}
