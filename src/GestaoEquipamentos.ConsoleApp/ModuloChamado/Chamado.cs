using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.ConsoleApp.ModuloChamado
{
    public class Chamado
    {
        public string Título;
        public string DescricaoChamado;
        public string Equipamento;
        public DateTime DataAbertura;
        public double DiasCorridos;

        public Chamado(string nomeChamado, string descricaoChamado, string nomeEquipamento, DateTime dataAbertura)
        {
            Título = nomeChamado;
            DescricaoChamado = descricaoChamado;
            Equipamento = nomeEquipamento;
            DataAbertura = dataAbertura;
        }
        public Chamado(string nomeChamado, string descricaoChamado, string nomeEquipamento)
        {
            Título = nomeChamado;
            DescricaoChamado = descricaoChamado;
            Equipamento = nomeEquipamento;
        }
    }
}
