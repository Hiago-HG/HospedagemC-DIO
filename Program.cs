using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Marcos da silva");
Pessoa p2 = new Pessoa(nome: "Jonatham ribeiro");
Pessoa p3 = new Pessoa(nome: "Dona cotinhas");
Pessoa p4 = new Pessoa(nome: "Pablo Moura");
Pessoa p5 = new Pessoa(nome: "Maurcio da costa");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);
hospedes.Add(p4);
hospedes.Add(p5);

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 5, valorDiaria: 60);

Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");