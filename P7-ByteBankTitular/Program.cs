using ByteBank.Titular;
using ByteBank;

//Cliente cliente = new Cliente();
//cliente.nome = "Andre Silva";
//cliente.cpf = "10253541263";
//cliente.profissao = "Programador C#";

//Console.WriteLine(cliente.nome);
//Console.WriteLine(cliente.cpf);
//Console.WriteLine(cliente.profissao);

ContaCorrente conta3 = new ContaCorrente();

//propriedades são os campos conta, numero etc
//conta3.titular = cliente;
conta3.conta = "2513252-X";
conta3.numero_agencia = 35;
conta3.nome_agencia = "Agência Central";
//Senao instanciar a classe, ela estara nula, ou seja, nao ha referencia
if (conta3.titular == null)
    //{
    Console.WriteLine("Não há informações de titular");
//}

//Console.WriteLine(cliente.nome);
//Console.WriteLine(conta3.titular.nome);

Console.ReadKey();
