using SupermercadoMenorPreco;
using static SupermercadoMenorPreco.CadastroProduto;

CadastroProduto cadastroProduto = new CadastroProduto();
cadastroProduto.fabricante = "Sonhos Possíveis";
cadastroProduto.valorUnitario = 1.00;
cadastroProduto.valorCompra = 30.00;
cadastroProduto.nome = "Felicidade";
cadastroProduto.quantidadeEstoque = 5;
cadastroProduto.codigoBarras = "HUUY&¨&%¨¨KJKI";

Console.WriteLine("Fabricante: " + cadastroProduto.fabricante);
Console.WriteLine("Valor Unitário: " + cadastroProduto.valorUnitario);
Console.WriteLine("Valor Compra: " + cadastroProduto.valorCompra);
Console.WriteLine("Nome: " + cadastroProduto.nome);
Console.WriteLine("Quantidade em Estoque: " + cadastroProduto.quantidadeEstoque);
Console.WriteLine("Código de Barras: " + cadastroProduto.codigoBarras);

Console.ReadKey();