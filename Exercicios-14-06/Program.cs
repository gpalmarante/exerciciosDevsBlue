﻿// See https://aka.ms/new-console-template for more information
using ConsoleApp3.Ex01;
using ConsoleApp3.Ex02;
using ConsoleApp3.Ex03;
using ConsoleApp3.Ex04;
using ConsoleApp3.Ex05;

/*
●	Exercício 1: Crie as classes Carro e Motor. O carro possui um motor, mas o motor pode existir independentemente do carro.

●	Exercício 2: Crie as classes Escola e Professor. A escola contém uma lista de professores. Um professor pode lecionar em várias escolas ao mesmo tempo.

●	Exercício 3: Crie as classes Pedido e ItemPedido. Um pedido possui uma lista de itens de pedido. Os itens de pedido não dependem exclusivamente de um pedido e podem ser compartilhados entre diferentes pedidos.

●	Exercício 4: Crie as classes Departamento e Funcionario. O departamento possui uma lista de funcionários. Um funcionário pode fazer parte de diferentes departamentos ao longo da carreira.

●	Exercício 5 (mais desafiador): Crie as classes Biblioteca ,Livro, Leitor, Empréstimo.Implemente a lógica para permitir o empréstimo e a devolução de livros na biblioteca.

*/
Motor motor01 = new Motor(1, "FirePlus", 16, 159);
Carro carro = new Carro(1,"corsa", " City", motor01);


Escola escola = new Escola("Adventista", "Rua Bahia");
Professor prof01 = new Professor("josias", "quimica");
escola.AddProfessor(prof01);


Pedido pedido = new Pedido(1);
ItemPedido item01 = new ItemPedido(1, "pao");
pedido.AddItemPedido(item01);



Departamento departamento =new Departamento(1);
Funcionario Funcionario01 = new Funcionario(1,"jose");
departamento.AddFuncionario(1, Funcionario01);



Biblioteca biblioteca = new Biblioteca();

biblioteca.AddLivro(1, "maria e joao", "Arco","LIVRE");
biblioteca.AddLivro(2, "maria e joao1", "Arco1", "LIVRE");
biblioteca.AddLivro(3, "maria e joao2", "Arco2", "LIVRE");
biblioteca.AddLivro(4, "maria e joao3", "Arco3", "LIVRE");
biblioteca.AddLeitor(1,"fred", "rua regal", true);
biblioteca.AddEmprestimo(1, 1);
biblioteca.RetornaLivro(1, 1);
Console.ReadKey();



