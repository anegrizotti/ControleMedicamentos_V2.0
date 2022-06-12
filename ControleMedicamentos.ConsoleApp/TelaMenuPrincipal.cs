﻿using ControleMedicamento.Infra.BancoDados.ModuloMedicamento;
using ControleMedicamentos.ConsoleApp.ModuloFornecedor;
using ControleMedicamentos.ConsoleApp.ModuloMedicamento;
using ControleMedicamentos.Dominio.Compartilhado;
using ControleMedicamentos.Dominio.ModuloFornecedor;
using ControleMedicamentos.Dominio.ModuloFuncionario;
using ControleMedicamentos.Dominio.ModuloMedicamento;
using ControleMedicamentos.Dominio.ModuloPaciente;
using ControleMedicamentos.Dominio.ModuloRequisicao;
using ControleMedicamentos.Infra.BancoDados.ModuloFornecedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ConsoleApp
{
    public class TelaMenuPrincipal
    {
        //private RepositorioFuncionario repositorioFuncionario;
        //private TelaCadastroFuncionario telaCadastroFuncionario;

        private RepositorioFornecedorEmBancoDados repositorioFornecedor;
        private TelaCadastroFornecedor telaCadastroFornecedor;

        private RepositorioMedicamentoEmBancoDados repositorioMedicamento;
        private TelaCadastroMedicamento telaCadastroMedicamento;

        //private RepositorioPaciente repositorioPaciente;
        //private TelaCadastroPaciente telaCadastroPaciente;

        //private RepositorioRequisicao repositorioRequisicao;
        //private TelaCadastroRequisicao telaCadastroRequisicao;

        public TelaMenuPrincipal(Notificador notificador)
        {
            //repositorioFuncionario = new RepositorioFuncionario();
            //telaCadastroFuncionario = new TelaCadastroFuncionario(repositorioFuncionario, notificador);

            repositorioFornecedor = new RepositorioFornecedorEmBancoDados();
            telaCadastroFornecedor = new TelaCadastroFornecedor(repositorioFornecedor, notificador);

            repositorioMedicamento = new RepositorioMedicamentoEmBancoDados();
            telaCadastroMedicamento = new TelaCadastroMedicamento(repositorioMedicamento, notificador);

            //repositorioPaciente = new RepositorioPaciente();
            //telaCadastroPaciente = new TelaCadastroPaciente(repositorioPaciente, notificador);

            //repositorioRequisicao = new RepositorioRequisicao();
            //telaCadastroRequisicao = new TelaCadastroRequisicao(repositorioRequisicao, repositorioPaciente, repositorioMedicamento,
            //    repositorioFuncionario, telaCadastroPaciente, telaCadastroMedicamento, telaCadastroFuncionario, notificador);
        }

        public string MostrarOpcoes()
        {
            Console.Clear();

            Console.WriteLine("Controle de Retirada de Medicamentos 2.0");

            Console.WriteLine();

            Console.WriteLine("Digite 1 para Gerenciar Funcionários");
            Console.WriteLine("Digite 2 para Gerenciar Fornecedores");
            Console.WriteLine("Digite 3 para Gerenciar Medicamentos");
            Console.WriteLine("Digite 4 para Gerenciar Pacientes");
            Console.WriteLine("Digite 5 para Gerenciar Requisições");

            Console.WriteLine("Digite s para sair");

            string opcaoSelecionada = Console.ReadLine();

            return opcaoSelecionada;
        }

        public TelaBase ObterTela()
        {
            string opcao = MostrarOpcoes();

            TelaBase tela = null;

            //if (opcao == "1")
            //    tela = telaCadastroFuncionario;

            if (opcao == "2")
                tela = telaCadastroFornecedor;

            else if (opcao == "3")
                tela = telaCadastroMedicamento;

            //else if (opcao == "4")
            //    tela = telaCadastroPaciente;

            //else if (opcao == "5")
            //    tela = telaCadastroRequisicao;

            return tela;
        }
    }
}
