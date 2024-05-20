Console.WriteLine("## Argumentos Nomeados ##");

Email email = new Email();

email.Enviar("teste@email.com", "Urgente", "Reunião de orçamento");

// argumentos nomeados
email.Enviar(titulo: "Urgente",destino: "teste@email.com",assunto: "Reunião de orçamento");
email.Enviar(destino: "teste@email.com", assunto: "Reunião de orçamento", titulo: "Urgente");
email.Enviar(assunto: "Reunião de orçamento", titulo: "Urgente", destino: "teste@email.com");

Console.ReadKey();

public class Email
{
    public void Enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"\nPara {destino} - {titulo}\nAssunto: {assunto}");
    }
}
