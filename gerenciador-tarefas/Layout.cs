using System;

namespace Layout
{
    public class Formatação
    {
        public static void Cor(string mensagem, string cor)
        {
            switch (cor.ToLower())
            {
                case "branco":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "verde":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "amarelo":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "vermelho":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }

            Console.WriteLine(mensagem);
            Console.ResetColor();
        }

        public static void ImprimirCabecalho()
        {
            Cor("=======================================", "amarelo");
            Cor("=         GERENCIADOR DE TAREFA       =", "amarelo");
            Cor("=======================================", "amarelo");
        }
    }
}
