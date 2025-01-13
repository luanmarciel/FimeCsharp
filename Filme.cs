public class Filme
{
    public string nome = string.Empty;  // Inicializa com uma string vazia
    public string artista = string.Empty;
    public int duracao = 0;  // Inicializa com 0 (já é o valor padrão)
    public bool disponivel = false;  // Inicializa com false

    public void ExibirFichaTecnica() //método
    {
        System.Console.WriteLine($"Nome: {nome}");
        System.Console.WriteLine($"Artista: {artista}");
        System.Console.WriteLine($"Duração: {duracao}");
        if(disponivel)
        {
            System.Console.WriteLine("Disponível no plano");
        }else
        {
            System.Console.WriteLine("Adquira o Plus+");
        }
    }
}
