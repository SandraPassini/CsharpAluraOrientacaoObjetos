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
sarah2.Nome = "Sarah Silva";
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

ContaCorrente conta6 = new ContaCorrente(1, "1551X");

//Temos disponível esse recurso para podermos criar variáveis, instâncias com propriedades para classe,
//assim, existem informações que são específicas de uma classe e informações trabalhadas por objetos. No caso,
//total de contas criadas é uma propriedade de classe e acessamos chamando o nome da classe, ponto a propriedade
//que é estática, ContaCorrente.TotalDeContasCriadas.
Console.WriteLine("Total de contas: " + ContaCorrente.TotalDeContasCriadas);
Console.WriteLine("Total de clientes: " + Cliente.TotalClientesCadastrados);

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