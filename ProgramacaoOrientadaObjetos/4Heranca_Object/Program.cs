Console.WriteLine("## Herança- Object ##\n");

// metodos Object que estao disponiveis em todos os objetos e classes derivadas
Nada nada = new Nada();
nada.GetHashCode();
nada.GetType();
nada.ToString();
//nada.Equals();

Console.ReadKey();

public class Nada
{

}

public struct Struct1
{

}

public class Classe1
{

}

public class Classe2
{

}

public class ClasseDerivada : Classe1
{

}