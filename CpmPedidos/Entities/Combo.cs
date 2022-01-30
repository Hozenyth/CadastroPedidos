

using CpmPedidos.Domain.Interfaces;
using System.Collections.Generic;

namespace CpmPedidos.Domain.Entities
{
    public class Combo : BaseDomain, IExebivel
    {        
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public bool Ativo { get; set; }

        public int ImagemId { get; set; }
        public virtual Imagem Imagem { get; set; }

        public virtual List<Produto> Produtos { get; set; }
    }
}
