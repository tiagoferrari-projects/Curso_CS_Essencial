Console.WriteLine("Definindo Identificadores");
Console.WriteLine();

// identificadores válidos
string nome;
string nomeCompleto;
int idade;
int _valor;
int idade1;

// identificadores inválidos
//int 5idade;
//int $valor;
//int valor#total;
//string nome Completo;

// para nomes de variáveis: camelCase
string descontoTotal;
string desconto_total;

// constantes: maíusculas
double PI = 3.14;
string PREFIXO = "16";
string PREFIXO_SP = "11";

Console.ReadLine();

// para nomes de classes e métodos: PascalCase
class ImprimirTexto
{
    public void ImprimeNome()
    {
        Console.WriteLine("Ferrari");
    }
}