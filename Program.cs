using DesafioPOO.Models;


// IMPLEMENTADO!!! (Nokia)
Console.WriteLine("Seu Nokia possui as seguintes informações.");
Smartphone n1 = new Nokia("(88) 88888-8888", "Nokia 3310", "3109783617NMDAO31NDA", 520);
Console.WriteLine("");// SEPARAÇÃO PARA MELHOR VISUALIZAÇÃO NO CONSOLE.
n1.Apresentar();
Console.WriteLine("");// SEPARAÇÃO PARA MELHOR VISUALIZAÇÃO NO CONSOLE.
n1.InstalarAplicativo("Sanke");
Console.WriteLine("");// SEPARAÇÃO PARA MELHOR VISUALIZAÇÃO NO CONSOLE.
n1.Ligar();


Console.WriteLine("");// SEPARAÇÃO PARA MELHOR VISUALIZAÇÃO NO CONSOLE.
Console.WriteLine("========================================================================="); // SEPARAÇÃO PARA MELHOR VISUALIZAÇÃO NO CONSOLE.


// IMPLEMENTADO!!! (Iphone)
Console.WriteLine("Seu Iphone possui as seguintes informações.");
Smartphone i1 = new Nokia("(11) 11111-1111", "Iphone 13", "H13KH5H1KJJD8ASN7FF1", 128);
Console.WriteLine("");// SEPARAÇÃO PARA MELHOR VISUALIZAÇÃO NO CONSOLE.
n1.Apresentar();
Console.WriteLine("");// SEPARAÇÃO PARA MELHOR VISUALIZAÇÃO NO CONSOLE.
n1.InstalarAplicativo("Netflix");
Console.WriteLine("");// SEPARAÇÃO PARA MELHOR VISUALIZAÇÃO NO CONSOLE.
i1.ReceberLigacao();