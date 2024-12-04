namespace api_LojaClientes.Dtos
{
    public class PedidoDto
    {
        public int idCliente { get; set; } //chave estrangeira 
        public DateOnly dataPedido { get; set; } 
        public string statusPedido { get; set; }
        public decimal valorTotalPedido { get; set; }
        public string observacoesPedido { get; set; }
        public int[] itensPedido { get; set; } = [];
    }
}
