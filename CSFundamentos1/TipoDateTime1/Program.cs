Console.WriteLine("## Struct DateTime ##\n");

// extrair informações da data atual
DateTime hoje = DateTime.Now;
Console.WriteLine($"Hoje: {hoje}");

Console.WriteLine(hoje.Year);
Console.WriteLine(hoje.Month);
Console.WriteLine(hoje.Day);
Console.WriteLine(hoje.Hour);
Console.WriteLine(hoje.Minute);
Console.WriteLine(hoje.Second);
Console.WriteLine(hoje.Millisecond);

// adicionando valores
Console.WriteLine(hoje.AddDays(30));
Console.WriteLine(hoje.AddMonths(1));
Console.WriteLine(hoje.AddHours(1));
Console.WriteLine(hoje.AddDays(30));
Console.WriteLine(hoje.AddYears(5));

// obter o dia da semana e do ano
Console.WriteLine(hoje.DayOfWeek);
Console.WriteLine(hoje.DayOfYear);

// data no formato longo e curto
Console.WriteLine(hoje.ToLongDateString());
Console.WriteLine(hoje.ToShortTimeString());


/*
// criar uma data especifica usa formato: aaaa/mm/dd
DateTime dataHoje = new DateTime(2024, 02, 23);
Console.WriteLine(dataHoje);

// definir as horas
DateTime dataHoraHoje = new DateTime(2024,02,23,1,39,00);
Console.WriteLine(dataHoraHoje);
*/

Console.ReadKey();