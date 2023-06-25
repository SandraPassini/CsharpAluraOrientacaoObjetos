using ByteBank;

Console.WriteLine("Boas Vindas ao seu banco, ByteBank!\n");
ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "André Silva";
conta1.conta = "110123-X";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agência Central";
conta1.saldo = 359.00;

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "Amanda Nogueira";
conta2.conta = "10106-X";
conta2.numero_agencia = 23;
conta2.nome_agencia = "Agência Central";
conta2.saldo = 100;

Console.WriteLine("Saldo da Amanda pré-saque: " + conta2.saldo);
conta2.Sacar(50);
Console.WriteLine("Saldo da Amanda pós-saque: " + conta2.saldo);
conta2.Sacar(90);
Console.WriteLine("Saldo da Amanda pós-saque: " + conta2.saldo);
conta2.Sacar(0);
Console.WriteLine("Saldo da Amanda pós-saque: " + conta2.saldo);

Console.WriteLine("");
conta2.Depositar(60);
Console.WriteLine("Saldo da Amanda pós-depósito: " + conta2.saldo);

Console.WriteLine("");
Console.WriteLine("Saldo da Amanda pré-saque: " + conta2.saldo);
bool saque = conta2.Sacar(50);
Console.WriteLine("saque: " + saque);
Console.WriteLine("Saldo da Amanda pós-saque: " + conta2.saldo);
conta2.Depositar(60);
Console.WriteLine("Saldo da Amanda pós-depósito: " + conta2.saldo);

Console.WriteLine("");
Console.WriteLine("Saldo da Amanda pré-transferência: " + conta2.saldo);
Console.WriteLine("Saldo do André  pré- Transferência: " + conta1.saldo);
bool transferencia = conta1.Transferir(50, conta2);
Console.WriteLine("Transferência realizada com sucesso? " + transferencia);
Console.WriteLine("Saldo da Amanda pós-transferência: " + conta2.saldo);
Console.WriteLine("Saldo do André pós-transferência: " + conta1.saldo);

Console.ReadKey();