Console.WriteLine("Exercicio Pratico 02\n");
Console.WriteLine("g- Crie um construtor que permita criar um carro somente usando os atributos : Modelo e Montadora (não\r\nuse a palavra-chave this)" +
    "\r\nh- Explique qual o comportamento ao usar este construtor para criar objetos do tipo Carro" +
    "\r\ni- Crie um método chamado VelocidadeMaxima que recebe um parâmetro do tipo int chamado potencia que\r\nvai retornar um double representando a velocidade máxima do carro\r\n( Para calcular a velocidade multiplique a potencia por 1.75)" +
    "\r\nj- Explique o comportamento da palavra return");

Console.WriteLine("\nResposta(h): Ao usar este construtor, a criação de um objeto do tipo Carro será realizada com valores específicos para 'Modelo' e 'Montadora'. Este construtor exige que sejam fornecidos esses valores no momento da criação do objeto. Não é possível criar um objeto Carro sem fornecer estes valores, a menos que exista também um construtor padrão na classe Carro.");

Carro carro1 = new Carro("Civic","Honda");

Console.WriteLine("O 'return' encerra a execução do método, retorna o controle de volta para o método chamador retornando o valor do tipo definido no método ");


Console.ReadKey();

public class Carro
{
    public Carro(string modelo, string montadora)
    {
        Modelo = modelo;
        Montadora = montadora;
    }

    public string? Modelo;
    public string? Montadora;

    public double VelocidadeMaxima(int potencia)
    {
        return potencia * 1.75;
    }
}