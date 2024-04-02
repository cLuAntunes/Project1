public class Player
{
    private string nome;

    public Player(string nomePlayer)
    {
        nome = nomePlayer; 
    }

    /// <summary>
    /// Método para retornar o nome do jogador
    /// </summary>
    /// <returns></returns>
    public string GetName()
    {
        return nome;
    }
}
