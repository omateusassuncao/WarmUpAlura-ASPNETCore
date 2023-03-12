using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasaDoCodigo.Models.ViewModels;

namespace CasaDoCodigo.Models
{
    public class UpdateQuantidadeResponse
    {
        public UpdateQuantidadeResponse(ItemPedido itempedido, CarrinhoViewModel carrinhoViewModel)
        {
            Itempedido = itempedido;
            CarrinhoViewModel = carrinhoViewModel;
        }

        public ItemPedido Itempedido { get; }
        public CarrinhoViewModel CarrinhoViewModel { get; }
    }
}
