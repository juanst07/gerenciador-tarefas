using System;

namespace SistemaDeTarefas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Layout.Formatação.ImprimirCabecalho();
                Layout.Formatação.Cor("Escolha uma opção:", "branco");
                Layout.Formatação.Cor("1 - Adicionar Tarefa", "branco");
                Layout.Formatação.Cor("2 - Listar Tarefas", "branco");
                Layout.Formatação.Cor("3 - Concluir Tarefa", "branco");
                Layout.Formatação.Cor("4 - Remover Tarefa", "branco");
                Layout.Formatação.Cor("5 - Sair", "branco");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Layout.Formatação.Cor("Digite a descrição da tarefa:", "branco");
                        string descricao = Console.ReadLine();
                        GerenciarTarefa.Gerenciador.AdicionarTarefa(descricao);
                        break;

                    case 2:
                        GerenciarTarefa.Gerenciador.ListarTarefa();
                        break;

                    case 3:
                        Layout.Formatação.Cor("Digite o ID da tarefa a concluir:", "branco");
                        int idConcluir = int.Parse(Console.ReadLine());
                        GerenciarTarefa.Gerenciador.ConcluirTarefa(idConcluir);
                        break;

                    case 4:
                        Layout.Formatação.Cor("Digite o ID da tarefa a remover:", "branco");
                        int idRemover = int.Parse(Console.ReadLine());
                        GerenciarTarefa.Gerenciador.RemoverTarefa(idRemover);
                        break;

                    case 5:
                        Layout.Formatação.Cor("Saindo...", "vermelho");
                        break;

                    default:
                        Layout.Formatação.Cor("Opção inválida!", "vermelho");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            } while (opcao != 5);
        }
    }
}
