// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using HospedagemDehotel;

List<Pessoa> hospede = new List<Pessoa>();

Pessoa P1 = new Pessoa("Adriano", "Ngola");
Pessoa P2 = new Pessoa("Bento", "Ngola");

hospede.Add(P1);
hospede.Add(P2);

Suite suite = new Suite("Premiun", 3, 30);

Reserva NovaReserva = new Reserva(10);

NovaReserva.CadastrarSuite(suite);
NovaReserva.CadastrarHospedes(hospede);


Console.WriteLine($"Hóspedes: {NovaReserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diário: {NovaReserva.CalcularValorDiario():c}");
