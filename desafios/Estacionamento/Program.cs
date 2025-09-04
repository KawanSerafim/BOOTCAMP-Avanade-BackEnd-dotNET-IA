﻿using desafios.Estacionamento.Models;
Console.OutputEncoding = System.Text.Encoding.UTF8;

bool exibirMenu = true;
string? placa = "";
decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");
Console.WriteLine("Digite o preço inicial: ");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

while(exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch(Console.ReadLine())
    {
        case "1":
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            placa = Console.ReadLine();

            if(placa != null)
            {
                es.AdicionarVeiculo(placa);
            }

            break;
        case "2":
            Console.WriteLine("\nDigite a placa do veículo para remover:");
            placa = Console.ReadLine();
            
            Console.WriteLine("\nDigite a quantidade de horas que o veículo permaneceu estacionado:");
            int horas = Convert.ToInt32(Console.ReadLine());

            if (placa != null)
            {
                Console.WriteLine(es.RemoverVeiculo(placa, horas));
            }

            break;
        case "3":
            Console.WriteLine(es.ListarVeiculos());
            break;
        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("\nPressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");