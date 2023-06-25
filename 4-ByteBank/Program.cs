using ByteBank;

Console.WriteLine("Boas Vindas ao seu banco, ByteBank!\n");
ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "André Silva";
conta1.conta = "110123-X";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agência Central";
conta1.saldo = 100;

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
Console.ReadKey();