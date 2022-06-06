
int nota = int.Parse(Console.ReadLine());

if (nota >= 8)
{
    Console.WriteLine("aprovado");
}
else if (nota < 8 && nota >= 5)
{
    Console.WriteLine("recuperação");
}
else
{
    Console.WriteLine("reprovado");
}

var resultado = (nota >= 8 ? "aprovado" : ((nota < 8 && nota >= 5) ? "recuperação" : "reprovado"));

Console.WriteLine(resultado);