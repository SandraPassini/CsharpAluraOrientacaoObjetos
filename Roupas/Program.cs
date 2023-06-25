using System.Text.RegularExpressions;
using Roupas;

Roupa roupa1 = new Roupa();
roupa1.fabricante = "Moda Jeans";
roupa1.valor = 63.0;
Roupa roupa2 = roupa1;
roupa2.valor = roupa2.valor + 1000;

//Ocorre que como roupa2 recebeu roupa1, ambos passaram a utilizar o mesmo espaco de memoria
Console.WriteLine(roupa1.valor);
Console.ReadLine();