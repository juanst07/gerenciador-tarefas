using Layout;
using Tarefas;

namespace GerenciarTarefas
{
    class Gerenciador
    {
        private List<Tarefa> tarefas = new List<Tarefa>();
        private int ProximoId = 1;

        public void AdicionarTarefa(string descricao)
        {
            var novaTarefa = new Tarefa(ProximoId++, descricao);
            tarefas.Add(novaTarefa);
            Formatacao.Cor($"\n\tTarefa {descricao} adicionada com sucesso!", ConsoleColor.Green);       
        }
        public void ConcluirTarefa(int id)
        {
            var tarefa = tarefas.Find( t => t.Id == id);
            if(tarefa != null)
            {
                tarefa.Concluida = true;
            }
            ListarTarefa();
            Formatacao.Cor("\n\tTarefa concluída!", ConsoleColor.Green);
        }
        public void ListarTarefa()
        {
        Console.WriteLine("\n\tTarefas:");
        if (tarefas.Count == 0)
        {
            Formatacao.Cor("\tNenhuma tarefa cadastrada.", ConsoleColor.Gray);
        }
            foreach (var tarefa in tarefas)
        {
           string status = tarefa.Concluida ? "[X]" : "[ ]";
            Formatacao.Cor($"\t{status} ID: {tarefa.Id} - {tarefa.Descricao}", ConsoleColor.Yellow);
        }
        }
        public void RemoverTarefa(int id)
        {
            var tarefa = tarefas.Find(Rtarefa => Rtarefa.Id == id);
            if (tarefa != null)
            {
                tarefas.RemoveAll(Rtarefa => Rtarefa.Id == id);
                ListarTarefa();
                Formatacao.Cor($"\n\tTarefa removida com sucesso!", ConsoleColor.Red);
            }
        }
        public void Sair()
        {
            Formatacao.Cor("\n\tSaindo...\n", ConsoleColor.Red);
        }
    }
}