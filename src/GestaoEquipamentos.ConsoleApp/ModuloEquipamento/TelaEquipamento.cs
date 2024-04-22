using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.ConsoleApp.ModuloEquipamento
{
    public class TelaEquipamento
    {
        RepositorioEquipamento repositorioEquipamento = new RepositorioEquipamento();
        public char ApresentarSegundoMenu()
        {
            Console.Clear();

            Console.WriteLine("Cadastro de Equipamentos");
            Console.WriteLine();

            Console.WriteLine("Digite 1 para inserir um novo equipamento");
            Console.WriteLine("Digite 2 para visualizar os equipamentos cadastrados");
            Console.WriteLine("Digite 3 para editar um equipamento");
            Console.WriteLine("Digite 4 para excluir um equipamento");
            Console.WriteLine("Digite S para sair");
            char opcao2 = Convert.ToChar(Console.ReadLine());

            return opcao2;
        }
        public void CadastrarEquipamento()
        {
            Console.Clear();

            Console.WriteLine("Inserindo um Equipamento");
            Console.WriteLine();

            Console.Write("Digite o nome do equipamento: ");
            string nomeEquipamento = Console.ReadLine().ToUpper();
            Console.Write("Digite o preço de aquisição: ");
            decimal precoAquisicao = Convert.ToDecimal(Console.ReadLine().ToUpper());
            Console.Write("Digite o número de série: ");
            string numeroSerie = Console.ReadLine().ToUpper();
            Console.Write("Digite a data de fabricação correspondente ao formato - dd/mm/aaaa: ");
            DateTime dataFabricacao = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Digite o nome da fabricante: ");
            string fabricante = Console.ReadLine().ToUpper();

            Equipamento equipamento = new Equipamento(nomeEquipamento, precoAquisicao, numeroSerie, dataFabricacao, fabricante);
            
            if (ValidarEquipamento(equipamento))
            {
                repositorioEquipamento.RegistrarEquipamentos(equipamento);

                Console.WriteLine();
                Console.WriteLine("Cadastro realizado com sucesso!");
            }
        
            Console.WriteLine();
            Console.WriteLine("Tecle 'enter' para retornar ao menu principal!");
            Console.ReadLine();
        }
        public bool ValidarEquipamento(Equipamento equipamento)
        {
            bool validacaoNome = true;

            if (equipamento.NomeEquipamento.Length < 6)
            {
                Console.WriteLine("O nome do equipamento deve ter no mínimo 6 digitos.");
                validacaoNome = false;
            }
            return validacaoNome;
        }
        public void VisualizarEquipamento()
        {
            Console.Clear();

            Console.WriteLine("Visualização dos Equipamentos Cadastrados");
            Console.WriteLine();

            repositorioEquipamento.VisualizarEquipamentos();

            Console.WriteLine();
            Console.WriteLine("Tecle 'enter' para retornar ao menu principal!");
            Console.ReadLine();
        }
        public void EditarEquipamento()
        {
            Console.Clear();

            Console.WriteLine("Edição de Equipamento");
            Console.WriteLine();

            Console.Write("Digite o nome do equipamento que você deseja editar: ");
            string nomeBusca = Console.ReadLine().ToUpper();

            if (nomeBusca != null)
            {
                Console.Write("Digite o novo nome do equipamento: ");
                string novoNomeEquipamento = Console.ReadLine().ToUpper();
                Console.Write("Digite o novo preço de aquisição: ");
                decimal novoPrecoAquisicao = Convert.ToDecimal(Console.ReadLine().ToUpper());
                Console.Write("Digite o novo número de série: ");
                string novoNumeroSerie = Console.ReadLine().ToUpper();
                Console.Write("Digite a nova data de fabricação correspondente ao formato - dd/mm/aaaa: ");
                DateTime novoDataFabricacao = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Digite o novo nome da fabricante: ");
                string novoFabricante = Console.ReadLine().ToUpper();

                Equipamento equipamentoEditado = new Equipamento(novoNomeEquipamento, novoPrecoAquisicao, novoNumeroSerie, novoDataFabricacao, novoFabricante);

                repositorioEquipamento.EditarEquipamento(equipamentoEditado, nomeBusca);

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

            Console.WriteLine("Exclusão de Equipamento");
            Console.WriteLine();

            Console.Write("Digite o nome do equipamento que você deseja excluir: ");
            string nomeExcluido = Console.ReadLine().ToUpper();

            repositorioEquipamento.ExcluirEquipamento(nomeExcluido);

            Console.WriteLine();
            Console.WriteLine("Exclusão realizada com sucesso!");
            Console.WriteLine();
            Console.WriteLine("Tecle 'enter' para retornar ao menu principal!");
            Console.ReadLine();
        }
    }
}
