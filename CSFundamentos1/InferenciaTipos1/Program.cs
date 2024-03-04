Console.WriteLine("## Inferência Tipos (var) ##");

//int idade = 25;
//string nome = "Maria";
//decimal salario = 2500.00m;

var idade = 25;
var nome = "Maria";
var salario = 2500.00m;

Console.WriteLine($"{nome} tem {idade} anos e ganha {salario.ToString("c")}");

// var limitações
//var salario = null;
//var titulo;
//var imposto, total, salario;

//// não posso mudar o tipo após inicializar
//var num = 10;
//num = num + 10;
//num = "Teste";

// funciona para tipos definidos pelo usuário
var teste = new Teste();
teste.MeuMetodo();


Console.ReadKey();

public class Teste
{
    public void MeuMetodo()
    {
        Console.WriteLine("Meu método");
    }
}