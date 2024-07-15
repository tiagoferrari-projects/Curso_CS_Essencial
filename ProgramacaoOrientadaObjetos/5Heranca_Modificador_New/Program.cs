﻿Console.WriteLine("## Herança- Modificador New ##\n");

Aluno aluno = new Aluno();
aluno.Nome = "Maria";
aluno.Curso = "ADS";
Console.WriteLine(aluno.Saudacao());

Console.ReadKey();

class Pessoa
{
    public string? Nome { get; set; }
    public string Saudacao() => $"Oi, Eu sou o(a) {Nome}";
}

class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public new string Saudacao() => $"Oi, Eu sou o(a) {Nome} do curso de : {Curso}";
}