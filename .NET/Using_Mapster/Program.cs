using Mapster;
using Using_Mapster;

var pedido = new Pedido{
    Numero = "AABBBBB00000",
    Nome = "PEÇA X",
    Preco = 10000M };


var pedidoDTO = pedido.Adapt<PedidoDTO>();

Console.WriteLine(@$"{pedidoDTO.Nome} {pedido.Preco}");

