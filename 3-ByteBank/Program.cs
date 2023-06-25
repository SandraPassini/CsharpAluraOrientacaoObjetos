using ByteBank;
using System;

Console.WriteLine("Bem vindo ao seu banco,  Bytebank ");

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "André Silva";
conta1.conta = "110123-X";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agência Central";
conta1.saldo = 100;

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "André Silva";
conta2.conta = "111999-X";
conta2.numero_agencia = 321;
conta2.nome_agencia = "Agência Central";
conta2.saldo = 100;

//Mesmo que os valores de conta1 e conta2 sejam iguais, quando é feito o comando new aloca-se um espaço em memória.
//E esse endereço de memória é um numero diferente para cada instancia/referencia, por isso o resultado é false
// Resumindo, temos dois objetos com os mesmos valores, mas diferentes por conter endereços de memórias diferentes.
Console.WriteLine(conta1 == conta2);

//"conta 1" vai receber a referência da "conta 2", conta 1 =conta2;. Agora o "conta 1" possui o endereço de memória da "conta 2".
//Visto que igualamos o endereço de memória quando aplicamos o código, isto é, ambas estão com o endereço
conta1 = conta2;

Console.WriteLine(conta1 == conta2);

Console.ReadKey();