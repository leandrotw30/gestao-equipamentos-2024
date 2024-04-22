using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.ConsoleApp.ModuloEquipamento
{
    public class Equipamento
    {
        public string NomeEquipamento;
        public decimal PrecoAquisicao;
        public string NumeroSerie;
        public DateTime DataFabricacao;
        public string Fabricante;

        public Equipamento(string nomeEquipamento, decimal precoAquisicao, string numeroSerie, DateTime dataFabricacao, string fabricante)
        {
            NomeEquipamento = nomeEquipamento;
            PrecoAquisicao = precoAquisicao;
            NumeroSerie = numeroSerie;
            DataFabricacao = dataFabricacao;
            Fabricante = fabricante;
        }
    }
}
