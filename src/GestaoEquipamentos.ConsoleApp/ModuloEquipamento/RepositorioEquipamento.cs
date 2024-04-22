using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.ConsoleApp.ModuloEquipamento
{
    public class RepositorioEquipamento
    {
        Equipamento[] arrayEquipamentos = new Equipamento[100];

        public void RegistrarEquipamentos(Equipamento equipamento)
        {
            for (int i = 0; i < arrayEquipamentos.Length; i++)
            {
                if (arrayEquipamentos[i] == null)
                {
                    arrayEquipamentos[i] = equipamento;
                    break;
                }
            }
        }

        public void VisualizarEquipamentos()
        {
            var position = Console.GetCursorPosition();
            Console.Write("Nome do Equipamento | ");
            Console.SetCursorPosition(22, position.Top);
            Console.Write("Preço de Aquisição | ");
            Console.SetCursorPosition(43, position.Top);
            Console.Write("Número de Série | ");
            Console.SetCursorPosition(61, position.Top);
            Console.Write("Data de Fabricação | ");
            Console.SetCursorPosition(82, position.Top);
            Console.Write("Fabricante");
            Console.SetCursorPosition(92, position.Top);
            Console.WriteLine();

            foreach (var equipamento in arrayEquipamentos)
            {
                if (equipamento != null)
                {
                    position = Console.GetCursorPosition();
                    Console.Write(equipamento.NomeEquipamento);
                    Console.SetCursorPosition(22, position.Top);
                    Console.Write(equipamento.PrecoAquisicao);
                    Console.SetCursorPosition(43, position.Top);
                    Console.Write(equipamento.NumeroSerie);
                    Console.SetCursorPosition(61, position.Top);
                    Console.Write(equipamento.DataFabricacao);
                    Console.SetCursorPosition(82, position.Top);
                    Console.Write(equipamento.Fabricante);
                    Console.SetCursorPosition(92, position.Top);
                    Console.WriteLine();
                }
            }
        }

        public void EditarEquipamento(Equipamento equipamentoEditado, string nomeBusca)
        {
            foreach (var equipamento in arrayEquipamentos)
            {
                if (equipamento != null && equipamento.NomeEquipamento.Equals(nomeBusca))
                {
                    equipamento.NomeEquipamento = equipamentoEditado.NomeEquipamento;
                    equipamento.PrecoAquisicao = equipamentoEditado.PrecoAquisicao;
                    equipamento.NumeroSerie = equipamentoEditado.NumeroSerie;
                    equipamento.DataFabricacao = equipamentoEditado.DataFabricacao;
                    equipamento.Fabricante = equipamentoEditado.Fabricante;
                }
            }
        }

        public void ExcluirEquipamento(string nomeExcluido)
        {
            for (int i = 0; i < arrayEquipamentos.Length; i++)
            {
                var equipamento = arrayEquipamentos[i];

                if (equipamento != null && equipamento.NomeEquipamento.Equals(nomeExcluido))
                {
                    arrayEquipamentos[i] = null;
                }
            }
        }
    }
}
