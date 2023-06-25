using ByteBank;
using ByteBank.Titular;

Cliente sarah = new Cliente();

ContaCorrente conta4 = new ContaCorrente(1, "8X");
conta4.Saldo = 100;
conta4.Titular = sarah;
conta4.Titular.Profissao = "amor";
Console.WriteLine(conta4.Saldo);
Console.WriteLine(conta4.Titular.Profissao);
Console.WriteLine(conta4.Numero_agencia);
Console.WriteLine(conta4.Conta);

Console.WriteLine("");
Cliente sarah2 = new Cliente();
sarah.Nome = "Sarah Silva";
//depois do new é o construtor
ContaCorrente conta5 = new ContaCorrente(1, "1551X");
conta5.Saldo = 100;
conta5.Titular = sarah2;
conta5.Numero_agencia = -10;
conta5.Conta = "";

Console.WriteLine(conta5.Titular.Nome);
Console.WriteLine(conta5.Saldo);
Console.WriteLine(conta5.Numero_agencia);
Console.WriteLine(conta5.Conta);

Console.WriteLine("");
ContaCorrente conta6 = new ContaCorrente(2535, "125358-X");
ContaCorrente conta7 = new ContaCorrente(365, "957256-X");

Console.ReadKey();

//Existe um recurso que nós já utilizamos do .NET que é o construtor, é um método que tem o mesmo nome da classe e 
//é chamado no objeto, então, quando executamos o operador new, ele chama o construtor que tem o mesmo nome da classe
//sem parâmetros.

//Na classe ContaCorrente também temos esse método, não o visualizamos mas ele está implicitamente definido para essa 
//classe. Então, vamos definir esse método explicitamente para essa classe.

//O construtor da classe é chamado quando usamos o operador new.Detalhe importante quando trabalhamos com construtores, 
//é que a partir do momento que defino um explicitamente, ele passa a ser o construtor padrão da classe, isso significa 
//que não temos mais acesso ao de maneira automática ao public ContaCorrente() { }, sem nenhum parâmetro ou implementação,
//o método construtor padrão.

//Então, a partir do momento que definimos esse novo método public ContaCorrente(int numero_agencia, string conta), ele 
//passou o padrão para a classe.