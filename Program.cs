﻿using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new();

Pessoa p1 = new(nome: "Hóspede 1");
Pessoa p2 = new(nome: "Hóspede 2");
Pessoa p3 = new(nome: "Hóspede 3");
Pessoa p4 = new(nome: "Hóspede 4");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);
hospedes.Add(p4);

// Cria a suíte
Suite suite = new(tipoSuite: "Premium", capacidade: 5, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new(diasReservados: 11);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}\nValor diária: {reserva.CalcularValorDiaria()}");