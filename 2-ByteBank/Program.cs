using ByteBank;

Console.WriteLine("Bem vindo ao seu banco,  Bytebank ");

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "André Silva";
conta1.conta = "110123-X";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agência Central";
conta1.saldo = 100;

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = "Amanda Nogueira";
//conta2.conta = "10106-X";
//conta2.numero_agencia = 321;
//conta2.nome_agencia = "Agência Central";
//conta2.saldo = 100;

//Console.WriteLine("Titular :"+conta1.titular);
//Console.WriteLine("Conta :" + conta1.conta);
//Console.WriteLine("Número Agência :" + conta1.numero_agencia);
//Console.WriteLine("Nome Agência :" + conta1.nome_agencia);
//Console.WriteLine("Saldo: "+conta1.saldo);

double saldo = 100;
conta1.saldo = saldo;
double saldo2 = conta1.saldo;
conta1.saldo = 200;
Console.WriteLine("saldo " + saldo);
Console.WriteLine("saldo2: " + saldo2);
Console.WriteLine("conta1.saldo: " + conta1.saldo);
Console.WriteLine(saldo == conta1.saldo);
Console.WriteLine(saldo == saldo2);

Console.ReadKey();