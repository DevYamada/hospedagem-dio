// See https://aka.ms/new-console-template for more information

using hospedagem.Models;
using Hospedagem.Models;

List<Hospede> hospedes = new List<Hospede>();

Hospede p1 = new Hospede(nomeCompleto: "Joas asd");
Hospede p2 = new Hospede(nomeCompleto: "kas aso");

hospedes.Add(p1);
hospedes.Add(p2);


Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valor: 30);


Reserva reserva = new Reserva(DiasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);


Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor: {reserva.ObterValor()}");