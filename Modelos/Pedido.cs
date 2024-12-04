using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_LojaClientes.Modelos
{
    public class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idPedido { get; set; }
        public int idCliente { get; set; } //chave estrangeira Indica que cada pedido pertence a um cliente específico
        public DateOnly dataPedido { get; set; } 
        public string statusPedido { get; set; }
        public decimal valorTotalPedido { get; set; }
        public string observacoesPedido { get; set; }
        public ICollection<ItemPedido> itemPedidos { get; set; } //IColletion é o pai. Representa a relação "um para muitos" entre Pedido e ItemPedido.
        //Um pedido pode conter vários itens, e essa coleção armazena a lista de itens associados
    }
}
//idClienteRepresenta a chave estrangeira (FK - Foreign Key) que associa o pedido a um cliente
//Indica que cada pedido pertence a um cliente específico