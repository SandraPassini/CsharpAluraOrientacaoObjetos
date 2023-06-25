using ByteBank.Titular;
using ByteBank;
using System.Drawing;

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

//ContaCorrente conta4 = new ContaCorrente();
//conta4.saldo = -10;
//Console.WriteLine(conta4.saldo);

//metodo definirsaldo seta valores
ContaCorrente conta4 = new ContaCorrente();
conta4.SetSaldo(-10);
Console.WriteLine();

//Criamos o metodo para devolver o valor Saldo que é privado
Console.WriteLine("Saldo1: " + conta4.GetSaldo());

conta4.SetSaldo(1897);
Console.WriteLine();

//Criamos o metodo para devolver o valor Saldo que é privado
Console.WriteLine("Saldo2: " + conta4.GetSaldo());

ContaCorrente conta5 = new ContaCorrente();
conta5.Saldo = -150;
Console.WriteLine("conta5.Saldo: " + conta5.Saldo);

ContaCorrente conta6 = new ContaCorrente();
conta6.Saldo = 89150;
Console.WriteLine("conta6.Saldo: " + conta6.Saldo);


Console.ReadKey();

//Através desse mecanismo implementamos uma boa prática de orientação a
//objetos, que definimos os campos como privado e acessarmos eles através
//de uma propriedade ou método público, com isso, aplicamos o conceito de
//encapsulamento, que oculta de quem está desenvolvendo ou usando aquela
//classe quando for feita a implementação.