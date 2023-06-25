using FranquiaFastFood;

Pedido pedido = new Pedido();
Cliente cliente = new Cliente();
pedido.cliente = cliente;
cliente.cpf = "12";

Console.WriteLine(pedido.cliente.cpf);