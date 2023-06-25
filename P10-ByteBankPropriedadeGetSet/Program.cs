using ByteBank;
using ByteBank.Titular;

Cliente sarah = new Cliente();

ContaCorrente conta4 = new ContaCorrente();
conta4.Saldo = 100;
conta4.Titular = sarah;
conta4.Titular.Profissao = "amor";
Console.WriteLine(conta4.Saldo);
Console.WriteLine(conta4.Titular.Profissao);

Console.ReadKey();