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
    /// Caractere Unicode para representar cada uma das combinações possiveis
    /// das peças
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        string unicodeChar;

        switch ((tamanho, cor, forma, furo))
        {
            case (Tamanho.Grande, Cor.Clara, Forma.Redonda, Furo.Com):
                unicodeChar = "\u25CF"; // ●
                break;
            case (Tamanho.Grande, Cor.Clara, Forma.Redonda, Furo.Sem):
                unicodeChar = "\u25CC"; // ◌
                break;
            case (Tamanho.Grande, Cor.Clara, Forma.Quadrada, Furo.Com):
                unicodeChar = "\u25A1"; // □
                break;
            case (Tamanho.Grande, Cor.Clara, Forma.Quadrada, Furo.Sem):
                unicodeChar = "\u25A2"; // ▢
                break;
            case (Tamanho.Grande, Cor.Escura, Forma.Redonda, Furo.Com):
                unicodeChar = "\u25D9"; // ◙
                break;
            case (Tamanho.Grande, Cor.Escura, Forma.Redonda, Furo.Sem):
                unicodeChar = "\u25D8"; // ◘
                break;
            case (Tamanho.Grande, Cor.Escura, Forma.Quadrada, Furo.Com):
                unicodeChar = "\u25FC"; // ◼
                break;
            case (Tamanho.Grande, Cor.Escura, Forma.Quadrada, Furo.Sem):
                unicodeChar ="\u25A7"; // ▧
                break;
            case (Tamanho.Pequena, Cor.Clara, Forma.Redonda, Furo.Com):
                unicodeChar = "\u25C9"; // ◉
                break;
            case (Tamanho.Pequena, Cor.Clara, Forma.Redonda, Furo.Sem):
                unicodeChar = "\u25CE"; // ◎
                break;
            case (Tamanho.Pequena, Cor.Clara, Forma.Quadrada, Furo.Com):
                unicodeChar = "\u25AB"; // ▫
                break;
            case (Tamanho.Pequena, Cor.Clara, Forma.Quadrada, Furo.Sem):
                unicodeChar = "\u25AF"; // ▯
                break;
            case (Tamanho.Pequena, Cor.Escura, Forma.Redonda, Furo.Com):
                unicodeChar = "\u25C7"; // ◇
                break;
            case (Tamanho.Pequena, Cor.Escura, Forma.Redonda, Furo.Sem):
                unicodeChar = "\u25C8"; // ◈
                break;
            case (Tamanho.Pequena, Cor.Escura, Forma.Quadrada, Furo.Com):
                unicodeChar = "\u25A3"; // ▣
                break;
            case (Tamanho.Pequena, Cor.Escura, Forma.Quadrada, Furo.Sem):
                unicodeChar = "\u25A2"; // ▢
                break;
            default:
                unicodeChar = " ";
                break;
        }

        return unicodeChar;
    }   

}