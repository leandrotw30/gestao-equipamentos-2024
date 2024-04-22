using GestaoEquipamentos.ConsoleApp.ModuloEquipamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.ConsoleApp.ModuloChamado
{
    public class RepositorioChamado
    {
        Chamado[] arrayChamados = new Chamado[100];

        public void CadastrarChamado(Chamado chamado)
        {
            for (int i = 0; i < arrayChamados.Length; i++)
            {
                if (arrayChamados[i] == null)
                {
                    arrayChamados[i] = chamado;
                    break;
                }
            }
        }
        public Chamado[] SelecionarChamados()
        {
            return arrayChamados;
        }
        public void EditarChamado(Chamado chamadoEditado, string nomeBusca)
        {
            foreach (var chamado in arrayChamados)
            {
                if (chamado != null && chamado.Título.Equals(nomeBusca))
                {
                    chamado.Título = chamadoEditado.Título;
                    chamado.DescricaoChamado = chamadoEditado.DescricaoChamado;
                    chamado.Equipamento = chamadoEditado.Equipamento;
                }
            }
        }
        public void ExcluirChamados(string nomeExcluido)
        {
            for (int i = 0; i < arrayChamados.Length; i++)
            {
                var chamado = arrayChamados[i];

                if (chamado != null && chamado.Título.Equals(nomeExcluido))
                {
                    arrayChamados[i] = null;
                }
            }
        }
    }
}
