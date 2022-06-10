using ControleMedicamentos.Dominio.ModuloMedicamento;
using ControleMedicamentos.Dominio.ModuloPaciente;
using ControleMedicamentos.Dominio.ModuloFuncionario;

using System;
using System.Collections.Generic;

namespace ControleMedicamentos.Dominio.ModuloRequisicao
{
    public class Requisicao : EntidadeBase
    {
        private Medicamento medicamentoSelecionado;
        private Paciente pacienteSelecionado;
        private int quantidadeMedicamento;
        private DateTime dataHora;
        private Funcionario funcionarioSelecionado;

        public Requisicao(Medicamento medicamentoSelecionado, Paciente pacienteSelecionado, int quantidadeMedicamento, DateTime dataHora, Funcionario funcionarioSelecionado)
        {
            this.medicamentoSelecionado = medicamentoSelecionado;
            this.pacienteSelecionado = pacienteSelecionado;
            this.quantidadeMedicamento = quantidadeMedicamento;
            this.dataHora = dataHora;
            this.funcionarioSelecionado = funcionarioSelecionado;
        }

        public Medicamento Medicamento { get; set; }
        public Paciente Paciente { get; set; }
        public int QtdMedicamento { get; set; }
        public DateTime Data { get; set; }
        public Funcionario Funcionario { get; set; }
    }
}
