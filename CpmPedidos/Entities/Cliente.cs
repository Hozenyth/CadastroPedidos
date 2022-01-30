

using CpmPedidos.Domain.Interfaces;
using System.Collections.Generic;

namespace CpmPedidos.Domain.Entities
{
    public class Cliente : BaseDomain, IExebivel
    {      
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public bool Ativo { get; set; }

        public int EnderecoId { get; set; }
        public virtual Endereco Endereco { get; set; }

        public virtual List<Pedido> Pedidos { get; set; }
    }
}
