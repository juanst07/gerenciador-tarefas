using System.ComponentModel.Design;
using GerenciarTarefas;
using Layout;


int opcao;
Gerenciador gerenciador = new Gerenciador();
inicio:
            Formatacao.ImprimirCabeçalho();
            Console.WriteLine("\t1 - Adicionar Tarefa");
            Console.WriteLine("\t2 - Listar Tarefas");
            Console.WriteLine("\t3 - Concluir Tarefa");
            Console.WriteLine("\t4 - Remover Tarefa");
            Console.WriteLine("\t0 - Sair");
            Console.Write("\tEscolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                Console.Clear();
                    Console.Write("\tDigite a descrição da tarefa: ");
                    string descricao = Console.ReadLine();
                    Console.Clear();
                    gerenciador.AdicionarTarefa(descricao);
                    goto inicio;
                case 2:
                Console.Clear();
                    gerenciador.ListarTarefa();
                    goto inicio;
                case 3:
                    Console.Clear();
                    gerenciador.ListarTarefa();
                    Console.Write("\n\tDigite o ID da tarefa a ser concluída: ");
                    int idTarefa = int.Parse(Console.ReadLine());
                    Console.Clear();
                    gerenciador.ConcluirTarefa(idTarefa);
                    goto inicio;
                case 4:
                    Console.Clear();
                    gerenciador.ListarTarefa();
                    Console.Write("\n\tDigite o ID da tarefa a ser removida: ");
                    int idRemover = int.Parse(Console.ReadLine());
                    Console.Clear();
                    gerenciador.RemoverTarefa(idRemover);
                    goto inicio;
                case 0:
                    gerenciador.Sair();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }