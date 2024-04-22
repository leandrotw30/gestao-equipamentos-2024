using GestaoEquipamentos.ConsoleApp.ModuloChamado;
using System;
using System.Threading.Channels;

namespace GestaoEquipamentos.ConsoleApp.ModuloEquipamento
{
    public class Program
    {
        static void Main(string[] args)
        {
            TelaEquipamento telaEquipamento = new TelaEquipamento();
            
            TelaChamado telaChamado = new TelaChamado();

            bool opcaoSairSelecionada = false;

            while (!opcaoSairSelecionada)
            {
                try
                {
                    char opcaoMenuPrincipal = ApresentarMenuPrincipal();

                    if (opcaoMenuPrincipal == '1')
                    {
                        char opcaoMenuEquipamento = telaEquipamento.ApresentarSegundoMenu();

                        switch (opcaoMenuEquipamento)
                        {
                            case '1':
                                telaEquipamento.CadastrarEquipamento(); break;

                            case '2':
                                telaEquipamento.VisualizarEquipamento(); break;

                            case '3':
                                telaEquipamento.EditarEquipamento(); break;

                            case '4':
                                telaEquipamento.ExcluirEquipamento(); break;

                            case 'S':
                                telaEquipamento.ApresentarSegundoMenu(); break;
                                        
                            default:
                                Console.WriteLine("Opção inválida. Tente novamente!"); break;
                        }
                    }
                    else if (opcaoMenuPrincipal == '2')
                    {
                        char opcaoMenuChamado = telaChamado.ApresentarSegundoMenu();

                        switch (opcaoMenuChamado)
                        {
                            case '1':
                                telaChamado.CadastrarChamado(); break;

                            case '2':
                                telaChamado.VisualizarChamados(); break;

                            case '3':
                                telaChamado.EditarChamado(); break;

                            case '4':
                                telaChamado.ExcluirEquipamento(); break;

                            case 'S':
                                continue;

                            default:
                                Console.WriteLine("Opção inválida. Tente novamente!"); break;
                        }
                    }
                    else if (opcaoMenuPrincipal.Equals('S'))    
                        opcaoSairSelecionada = true;

                    else
                        Console.WriteLine("Opção inválida. Tente novamente!");
                }
                catch (Exception)
                {
                }
            }
        }
        private static char ApresentarMenuPrincipal()
        {
            Console.Clear();

            Console.WriteLine("Gestão de Equipamentos");
            Console.WriteLine();

            Console.WriteLine("Digite 1 para o Controle de Equipamentos");
            Console.WriteLine("Digite 2 para o Controle de Chamados");
            Console.WriteLine("Digite S para sair");
            char opcaoMenuPrincipal = Convert.ToChar(Console.ReadLine().ToUpper());
            
            return opcaoMenuPrincipal;
        }
    }
}
