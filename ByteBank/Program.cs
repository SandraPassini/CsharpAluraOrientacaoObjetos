using ByteBank;

Console.WriteLine("****Boas Vindas ao seu banco, ByteBank - Modelo Orientado a Objetos****");

Console.WriteLine("");

//Criar objeto para poder usar a classe 
//defini uma referência do tipo da classe do objeto e
//instancia na memória do computador com o operador new
ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Sandra Passini";
conta1.conta = "7777-x";
conta1.numero_agencia = 639;
conta1.nome_agencia = "Agencia Prosperidade Com Muita Abundância";
conta1.saldo = 5550000.00;

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "Amanda Nogueira";
conta2.conta = "10106-X";
conta2.numero_agencia = 321;
conta2.nome_agencia = "Agência Central";
conta2.saldo = 100;

Console.WriteLine("Titular: " + conta1.titular);
Console.WriteLine("Conta: " + conta1.conta);
Console.WriteLine("Número Agencia: " + conta1.numero_agencia);
Console.WriteLine("Nome da Agencia: " + conta1.nome_agencia);
Console.WriteLine("Saldo: R$ " + conta1.saldo);

Console.WriteLine("");

Console.WriteLine("Titular: " + conta2.titular);
Console.WriteLine("Conta: " + conta2.conta);
Console.WriteLine("Número Agencia: " + conta2.numero_agencia);
Console.WriteLine("Nome da Agencia: " + conta2.nome_agencia);
Console.WriteLine("Saldo: R$ " + conta2.saldo);
Console.ReadKey();

Console.WriteLine("");

//Quando o campo não recebe informação, o valor apresentado é o padrão
ContaCorrente conta3 = new ContaCorrente();

Console.WriteLine("Titular :"+ conta3.titular);
Console.WriteLine("Conta :" + conta3.conta);
Console.WriteLine("Número Agência :" + conta3.numero_agencia);
Console.WriteLine("Nome Agência :" + conta3.nome_agencia);
Console.WriteLine("Saldo: " + conta3.saldo);
Console.WriteLine("Verificador: " + conta3.verificador);

Console.ReadKey();