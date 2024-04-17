using System;
using System.Threading.Channels;

namespace GestaoEquipamentos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Acoes acoes = new Acoes();

            while (true)
            {
                try
                {
                    Console.Clear();

                    Console.WriteLine("Gestão de Equipamentos");
                    Console.WriteLine();

                    Console.WriteLine("Digite 1 para o Cadastro de Equipamentos");
                    Console.WriteLine("Digite 2 para o Controle de Chamados");
                    Console.WriteLine("Digite S para sair");
                    string opcao1 = Console.ReadLine();

                    if (opcao1 == "1")
                    {
                        Console.Clear();

                        Console.WriteLine("Cadastro de Equipamentos");
                        Console.WriteLine();

                        Console.WriteLine("Digite 1 para inserir um novo equipamento");
                        Console.WriteLine("Digite 2 para visualizar os equipamentos cadastrados");
                        Console.WriteLine("Digite 3 para editar um equipamento");
                        Console.WriteLine("Digite 4 para excluir um equipamento");
                        Console.WriteLine("Digite S para sair");
                        string opcao2 = Console.ReadLine();

                        switch (opcao2)
                        {
                            case "1":
                                Console.Clear();

                                Console.WriteLine("Inserindo um Equipamento");
                                Console.WriteLine();

                                Console.Write("Digite o nome do equipamento: ");
                                string nomeEquipamento = Console.ReadLine().ToUpper();
                                Console.Write("Digite o preço de aquisição: ");
                                decimal precoAquisicao = Convert.ToDecimal(Console.ReadLine().ToUpper());
                                Console.Write("Digite o número de série: ");
                                string numeroSerie = Console.ReadLine().ToUpper();
                                Console.Write("Digite a data de fabricação: ");
                                string dataFabricacao = Console.ReadLine();
                                Console.Write("Digite o nome da fabricante: ");
                                string fabricante = Console.ReadLine().ToUpper();

                                Equipamento equipamento = new Equipamento(nomeEquipamento, precoAquisicao, numeroSerie, dataFabricacao, fabricante);

                                acoes.RegistrarEquipamentos(equipamento);

                                Console.WriteLine();
                                Console.WriteLine("Cadastro realizado com sucesso!");
                                Console.WriteLine();
                                Console.WriteLine("Tecle 'enter' para retornar ao menu principal!");
                                Console.ReadLine();

                                break;

                            case "2":
                                Console.Clear();

                                Console.WriteLine("Visualização dos Equipamentos Cadastrados");
                                Console.WriteLine();

                                acoes.VisualizarEquipamentos();

                                Console.WriteLine();
                                Console.WriteLine("Tecle 'enter' para retornar ao menu principal!");
                                Console.ReadLine();

                                break;

                            case "3":
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
                                    Console.Write("Digite a nova data de fabricação: ");
                                    string novoDataFabricacao = Console.ReadLine();
                                    Console.Write("Digite o novo nome da fabricante: ");
                                    string novoFabricante = Console.ReadLine().ToUpper();

                                    Equipamento equipamentoEditado = new Equipamento(novoNomeEquipamento, novoPrecoAquisicao, novoNumeroSerie, novoDataFabricacao, novoFabricante);

                                    acoes.EditarEquipamento(equipamentoEditado, nomeBusca);
                                    
                                    Console.WriteLine();
                                    Console.WriteLine("Edição realizada com sucesso!");
                                    Console.WriteLine();
                                    Console.WriteLine("Tecle 'enter' para retornar ao menu principal!");
                                    Console.ReadLine();

                                }
                                break;

                            case "4":
                                Console.Clear();

                                Console.WriteLine("Exclusão de Equipamento");
                                Console.WriteLine();

                                Console.Write("Digite o nome do equipamento que você deseja excluir: ");
                                string nomeExcluido = Console.ReadLine().ToUpper();

                                acoes.ExcluirEquipamento(nomeExcluido);
                                
                                Console.WriteLine();
                                Console.WriteLine("Exclusão realizada com sucesso!");
                                Console.WriteLine();
                                Console.WriteLine("Tecle 'enter' para retornar ao menu principal!");
                                Console.ReadLine();

                                break;

                            default:
                                break;
                        }
                    }
                    else if (opcao1 == "2")
                    {
                        Console.WriteLine("Controle de Chamados");
                    }
                    else
                    {
                        bool opcaoSairSelecionada = string.IsNullOrEmpty(opcao1) || opcao1.Equals("S", StringComparison.InvariantCultureIgnoreCase);
                        if (opcaoSairSelecionada)
                        {
                            break;
                        }
                    }
                }
                catch (Exception)
                {
                }
            }
        }
    }
}
