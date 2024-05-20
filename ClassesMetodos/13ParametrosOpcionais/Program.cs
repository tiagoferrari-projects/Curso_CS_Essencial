Console.WriteLine("## Parâmetros Opcionais ##");

Console.WriteLine("Informe o destino:");
string destino = Console.ReadLine();
Console.WriteLine("Informe o título:");
string titulo = Console.ReadLine();
Console.WriteLine("Informe o assunto:");
string assunto = Console.ReadLine();

Email email = new();
email.Enviar();
email.Enviar(destino);
email.Enviar(destino, titulo);
email.Enviar(destino, titulo, assunto);

//não posso fazer
//email.Enviar(destino,,assunto); // causa erro
email.Enviar(destino, assunto: assunto); // utilizar argumento nomeado

Console.ReadKey();

public class Email
{
    public void Enviar(string destino = "Destino Padrão", string titulo = "Título Padrão", string assunto = "Assunto Padrão")
    {
        Console.WriteLine($"\nPara {destino} - {titulo}\nAssunto: {assunto}");
    }
}
