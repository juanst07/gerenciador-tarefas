using System;
using System.Collections.Generic;

namespace GerenciarTarefa
{
    public static class Gerenciador
    {
        private static List<Tarefas.Tarefa> tarefas = new List<Tarefas.Tarefa>();
        private static int contador = 1;

        public static void AdicionarTarefa(string descricao)
        {
            var tarefa = new Tarefas.Tarefa(contador++, descricao);
            tarefas.Add(tarefa);
            Layout.Formatação.Cor("Tarefa adicionada com sucesso!", "verde");
        }

        public static void ConcluirTarefa(int id)
        {
            var tarefa = tarefas.Find(t => t.Id == id);
            if (tarefa != null)
            {
                tarefa.Concluida = true;
                Layout.Formatação.Cor("Tarefa concluída!", "verde");
            }
            else
            {
                Layout.Formatação.Cor("Tarefa não encontrada!", "vermelho");
            }
        }

        public static void ListarTarefa()
        {
            Layout.Formatação.Cor("A lista com todas as tarefas:", "amarelo");
            foreach (var tarefa in tarefas)
            {
                tarefa.ExibirTarefa();
            }
        }

        public static void RemoverTarefa(int id)
        {
            var tarefa = tarefas.Find(t => t.Id == id);
            if (tarefa != null)
            {
                tarefas.Remove(tarefa);
                Layout.Formatação.Cor("Tarefa removida com sucesso!", "vermelho");
            }
            else
            {
                Layout.Formatação.Cor("Tarefa não encontrada!", "vermelho");
            }
        }
    }
}
