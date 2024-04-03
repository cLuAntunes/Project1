using System;

namespace GaloDaVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao GaloDaVelha!");

            Console.Write("Nome do Jogador 1: ");
            string nomePlayer1 = Console.ReadLine();
            Player player1 = new Player(nomePlayer1);

            Console.Write("Nome do Jogador 2: ");
            string nomePlayer2 = Console.ReadLine();
            Player player2 = new Player(nomePlayer2);
        }
    }
}
