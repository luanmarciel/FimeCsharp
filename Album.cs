class Colecao
{
    private List<Filme> filmes = new List<Filme>();
    public string Nome { get; set; }
    public int DuracaoTotal => filmes.Sum(m => m.Duracao);

    public void AdcionarFilme(Filme filme)
    {
        filmes.Add(filme);
    }

    public void ExibirFilmesDaColecao()
    {
        System.Console.WriteLine($"Lista de filmes da coleção {Nome}:\n");
        foreach(var filme in filmes)
        {
            System.Console.WriteLine($"Filme: {filme.Nome}");
        }
        System.Console.WriteLine($"\nPara assistir essa coleção completa você precisa de: {DuracaoTotal} segundos.");
    }
}