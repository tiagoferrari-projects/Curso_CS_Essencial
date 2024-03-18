Console.WriteLine("-- EXERCICIO 05 --\n");

Console.WriteLine("5- Escreva um programa para solicitar ao usuário que escolha a resposta correta de uma lista de opções de" +
    "\r\nresposta de uma pergunta. O usuário pode optar por continuar respondendo a pergunta ou parar de responder." +
    "\r\nNão utilize a instrução break." +
    "\r\nDica : Usar loop while e instruções if-elseif");


Console.WriteLine("Qual a instrução para sair de um loop?" +
    "\r\n//a.quit" +
    "\r\n//b.continue" +
    "\r\n//c.break" +
    "\r\n//d.exit" +
    "\r\nQual a opção correta ? (Tecle x para sair)?");

char resposta = Convert.ToChar(Console.ReadLine().ToLower());
bool condicao = true;

while (condicao)
{
    if (resposta == 'x')
    {
        Console.WriteLine("\nPrograma Encerrado!!");
        condicao = false;
    }

    else if (resposta != 'c')
    {
        Console.WriteLine("Sua resposta está incorreta.\nTente novamente!!");
        resposta = Convert.ToChar(Console.ReadLine().ToLower());
    }
    else
    {
        Console.WriteLine("Parabéns, você acertou!! ");
        condicao = false;
    }

}


Console.WriteLine("\nFim do processamento...");
Console.ReadKey();