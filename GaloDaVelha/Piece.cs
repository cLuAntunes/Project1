/// <summary>
/// Enumerações com as caracteristicas das peças
/// </summary>
public enum Tamanho
{
    Grande,
    Pequena 
}

public enum Cor
{
    Clara,
    Escura
}

public enum Forma
{
    Redonda,
    Quadrada
}

public enum Furo
{
    Com,
    Sem
}

public class Piece
{
    private Tamanho tamanho;
    private Cor cor;
    private Forma forma;
    private Furo furo;

    public Piece(Tamanho size, Cor color, Forma form, Furo hole)
    {
        tamanho = size;
        cor = color;
        forma = form;
        furo = hole;
    }

    public Tamanho GetTamanho()
    {
        return tamanho;
    }

    public Cor GetCor()
    {
        return cor;
    }

    public Forma GetForma()
    {
        return forma;
    }

    public Furo GetFuro()
    {
        return furo;
    }

    /// <summary>
    /// Checa se as peças tem caracteristicas em comum, se tiver pelo menos uma
    /// igual, retorna True
    /// </summary>
    /// <param name="outra"></param>
    /// <returns></returns>
    public bool Igual(Piece outra)
    {
        return tamanho == outra.GetTamanho() ||
               cor == outra.GetCor() ||
               forma == outra.GetForma() ||
               furo == outra.GetFuro();
    }


}