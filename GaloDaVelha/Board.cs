using System;

public class Board
{
    private Piece[,] tabuleiro;
    private const int TamanhoTab = 4;

    public Board()
    {
        tabuleiro = new Piece[TamanhoTab, TamanhoTab];
    }


    /// <summary>
    /// Permite colocar uma peça no tabuleiro verificando se a posição está 
    /// ocupada ou não
    /// </summary>
    /// <param name="linha"></param>
    /// <param name="coluna"></param>
    /// <param name="peça"></param>
    /// <returns></returns>
    public bool ColocarPeça(int linha, int coluna, Piece peça)
    {
        if (linha < 0 || linha >= TamanhoTab || coluna < 0 || coluna >= TamanhoTab)
            return false;

        if (tabuleiro[linha, coluna] == null)
        {
            tabuleiro[linha, coluna] = peça;
            return true;
        }

        return false;
    }
}