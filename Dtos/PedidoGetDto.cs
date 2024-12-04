using api_LojaClientes.Modelos;

namespace api_LojaClientes.Dtos
{
    public class PedidoGetDto
    {
        public int idCliente { get; set; } //chave  estrangeira
        public DateOnly dataPedido { get; set; }
        public string statusPedido { get; set; }
        public decimal valorTotalPedido { get; set; }
        public string observacoesPedido { get; set; }
        public List<ItensPedidoGetDto> itensPedido { get; set; } = new List<ItensPedidoGetDto> { };
    }

    public class ItensPedidoGetDto
    {
        public int idItemPedido { get; set; }
        public string nomeProduto { get; set; }
    }
}
