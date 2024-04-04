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

    /// <summary>
    /// Verifica se as peças tem alguma semelhança
    /// </summary>
    /// <param name="p1"></param>
    /// <param name="p2"></param>
    /// <param name="p3"></param>
    /// <param name="p4"></param>
    /// <returns></returns>
    private bool VerIgual(Piece p1, Piece p2, Piece p3, Piece p4)
    {
        if (p1 == null || p2 == null || p3 == null || p4 == null)
            return false;

        return p1.Igual(p2) && p1.Igual(p3) && p1.Igual(p4);
    }

    private bool VerLinha(int linha)
    {
        return VerIgual(tabuleiro[linha, 0], tabuleiro[linha, 1], tabuleiro[linha, 2], tabuleiro[linha, 3]);
    }

    private bool VerColuna(int coluna)
    {
        return VerIgual(tabuleiro[0, coluna], tabuleiro[1, coluna], tabuleiro[2, coluna], tabuleiro[3, coluna]);
    }

    private bool VerDiagonais()
    {
        return VerIgual(tabuleiro[0, 0], tabuleiro[1, 1], tabuleiro[2, 2], tabuleiro[3, 3]) ||
               VerIgual(tabuleiro[0, 3], tabuleiro[1, 2], tabuleiro[2, 1], tabuleiro[3, 0]);
    }