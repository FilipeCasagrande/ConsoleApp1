namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int jogador = 0;
            int computador = 0;
            const int chegada = 30;
            while (true)
            {
                Inicio();

                int resultado = lancarDado();
                sortearDado(resultado);

                jogador = jogador + resultado;
                Console.WriteLine($"O jogador moveu-se para a posição {jogador} de {chegada}");

                if (jogador >= chegada)
                {
                    Console.WriteLine("O jogador venceu!");
                    Console.ReadLine();
                    break;
                }

                else if (resultado == 6)
                {
                    Random dadoJ = new Random();
                    int resultadoJ = dadoJ.Next(1, 7);
                    Console.WriteLine("Parabéns você ganhou uma jogada extra, precione ENTER para jogar");
                    Console.ReadLine();
                    jogador = jogador + resultadoJ;
                    Console.WriteLine($"O resultado foi {resultadoJ}  o jogador moveu-se para a posição {jogador}");
                }

                switch (jogador)
                {
                    case 5:
                    case 10:
                    case 15:
                        jogador = jogador + 3;
                        Console.WriteLine($"Parabens você avança 3 espaços, moveu-se para a posição: {jogador}!");
                        break;

                    case 7:
                    case 13:
                    case 20:
                        jogador = jogador - 2;
                        Console.WriteLine($"Que pena você caiu para a posição {jogador}");
                        break;
                }
                //COMPUTADOR
                Random dadoC = new Random();
                int resultadoC = dadoC.Next(1,7);
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Vez do computador");
                Console.WriteLine("-------------------------------");
                Console.WriteLine($"O numero sorteado foi: {resultadoC}");
                Console.WriteLine("-------------------------------");

                computador = computador + resultadoC;
                Console.WriteLine($"O Computador moveu-se para a posição {computador} de {chegada}");

                if (computador >= chegada)
                {
                    Console.WriteLine("O computador venceu!");
                    Console.ReadLine();
                    break;
                }

                else if (resultadoC == 6)
                {
                    Random dadoJ = new Random();
                    int resultadoJ = dadoJ.Next(1, 7);
                    Console.WriteLine("O computador ganhou uma jogada extra,");
                    computador = computador + resultadoJ;
                    Console.WriteLine($"O resultado foi {resultadoJ}  o computador moveu-se para a posição {computador}");
                }
               
                switch (computador)
                {
                    case 5:
                    case 10:
                    case 15:
                        computador = computador + 3;
                        Console.WriteLine($"O computador avança 3 espaços, moveu-se para a posição: {computador}!");
                        break;
                    
                    case 7:
                    case 13:
                    case 20:
                        computador = computador - 2;
                        Console.WriteLine($"O computador caiu para a posição {computador}");
                        break;
                }
                
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Deseja contuniar [S/N] ");
                string deveContinuar = Console.ReadLine();
                if (deveContinuar == "n")
                {
                    break;
                }
            }
        }
        static void Inicio()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("jogo Corrida de Dados");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Precione ENTER para lançar o dado...");
            Console.ReadLine();
        }
        static int lancarDado()
        {
            Random dado = new Random();
            int resultado = dado.Next(1, 7);

            return resultado;
        }
        static int sortearDado(int resultado)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"O numero sorteado foi: {resultado}");
            Console.WriteLine("-------------------------------");
            return resultado;
        }
    }
}
