Console.WriteLine("## Assinatura de Método - Sobrecarga ##\n");

Email email = new Email();

email.Enviar("empresa@empresa.com.br");
email.Enviar("empresa@empresa.com.br","Proposta Comercial");
email.Enviar("empresa@empresa.com.br", 200);
email.Enviar(200, "empresa@empresa.com.br");

Console.ReadKey();

public class Email
{
    public void Enviar(string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"Assunto Padrão!");
    }
    public void Enviar(string endereco, string assunto)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"{assunto}");
    }

    public void Enviar(string endereco, decimal valor)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"Proposta Comercial");
        Console.WriteLine($"{valor}");
    }

    public void Enviar(decimal valor, string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"Pagamento Fornecedor");
        Console.WriteLine($"{valor}");
    }
}
