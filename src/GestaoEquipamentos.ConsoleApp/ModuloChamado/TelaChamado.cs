using GestaoEquipamentos.ConsoleApp.ModuloEquipamento;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.ConsoleApp.ModuloChamado
{
    public class TelaChamado
    {
        RepositorioChamado repositorio = new RepositorioChamado();
        
        public char ApresentarSegundoMenu()
        {
            Console.Clear();

            Console.WriteLine("Cadastro de Chamados");
            Console.WriteLine();

            Console.WriteLine("Digite 1 para inserir um novo chamado");
            Console.WriteLine("Digite 2 para visualizar os chamados cadastrados");
            Console.WriteLine("Digite 3 para editar um chamado");
            Console.WriteLine("Digite 4 para excluir um chamado");
            Console.WriteLine("Digite S para sair");
            char opcaoMenuChamado = Convert.ToChar(Console.ReadLine());
            
            return opcaoMenuChamado;
        }

        public void CadastrarChamado() 
        {
            Console.Clear();

            Console.WriteLine("Criando um Chamado");
            Console.WriteLine();

            Console.Write("Digite o nome do chamado: ");
            string nomeChamado = Console.ReadLine().ToUpper();
            Console.Write("Digite a descrição do chamado: ");
            string descricaoChamado = Console.ReadLine().ToUpper();
            Console.Write("Digite o nome do equipamento para qual o chamado será realizado: ");
            string nomeEquipamento = Console.ReadLine().ToUpper();
            Console.Write("Digite a data de abertura do chamado correspondente ao formato - dd/mm/aaaa: ");
            DateTime dataAbertura = Convert.ToDateTime(Console.ReadLine());

            Chamado chamado = new Chamado(nomeChamado, descricaoChamado, nomeEquipamento, dataAbertura);

            repositorio.CadastrarChamado(chamado);

            Console.WriteLine();
            Console.WriteLine("Cadastro realizado com sucesso!");
            Console.WriteLine();
            Console.WriteLine("Tecle 'enter' para retornar ao menu principal!");
            Console.ReadLine();
        }
        public void VisualizarChamados()
        {
            Console.Clear();

            Console.WriteLine("Visualização dos Chamados Cadastrados");
            Console.WriteLine();

            Console.WriteLine(
                "{0, -10} | {1, -15} | {2, -15} | {3, -10}",
                "Nome do Chamado", "Equipamento", "Data de Abertura", "Dias de Chamado Aberto"
            );

            Chamado[] chamadosCadastrados = repositorio.SelecionarChamados();
            
            for (int i = 0; i < chamadosCadastrados.Length; i++)
            {
                Chamado c = chamadosCadastrados[i];

                if (c == null)
                    continue;

                DateTime dataAtual = DateTime.Now;
                DateTime dataInicial = c.DataAbertura;
                var duracao = dataAtual - dataInicial;
                c.DiasCorridos = Math.Round(duracao.TotalDays);

                Console.WriteLine(
                    "{0, -15} | {1, -20} | {2, -15} | {3, -5}",
                    c.Título, c.Equipamento, c.DataAbertura.ToShortDateString(), c.DiasCorridos
                );
            }
            Console.WriteLine();
            Console.WriteLine("Tecle 'enter' para retornar ao menu principal!");
            Console.ReadLine();
        }
        public void EditarChamado()
        {
            Console.Clear();

            Console.WriteLine("Edição de Chamado");
            Console.WriteLine();

            Console.Write("Digite o nome do chamado que você deseja editar: ");
            string nomeBusca = Console.ReadLine().ToUpper();

            if (nomeBusca != null)
            {
                Console.Write("Digite o nome do chamado: ");
                string novoNomeChamado = Console.ReadLine().ToUpper();
                Console.Write("Digite a descrição do chamado: ");
                string novaDescricaoChamado = Console.ReadLine().ToUpper();
                Console.Write("Digite o nome do equipamento para qual o chamado será realizado: ");
                string novoNomeEquipamento = Console.ReadLine().ToUpper();

                Chamado chamadoEditado = new Chamado(novoNomeChamado, novaDescricaoChamado, novoNomeEquipamento);

                repositorio.EditarChamado(chamadoEditado, nomeBusca);

                Console.WriteLine();
                Console.WriteLine("Edição realizada com sucesso!");
                Console.WriteLine();
                Console.WriteLine("Tecle 'enter' para retornar ao menu principal!");
                Console.ReadLine();
            }
        }
        public void ExcluirEquipamento()
        {
            Console.Clear();

            Console.WriteLine("Exclusão de Chamado");
            Console.WriteLine();

            Console.Write("Digite o nome do chamado que você deseja excluir: ");
            string chamadoExcluido = Console.ReadLine().ToUpper();

            repositorio.ExcluirChamados(chamadoExcluido);

            Console.WriteLine();
            Console.WriteLine("Exclusão realizada com sucesso!");
            Console.WriteLine();
            Console.WriteLine("Tecle 'enter' para retornar ao menu principal!");
            Console.ReadLine();
        }
    }
}
