public class Filme
{
    public string Nome { get; set; }  
    public string Artista { get; set; }
    public int Duracao { get; set; }  
    public bool Disponivel { get; set; } 
    public string DescricaoResumida 
    {
         get
         {
            return $"O filme {Nome} pertence á: {Artista}";
         }
    }

    public void ExibirFichaTecnica() //método
    {
        System.Console.WriteLine($"Nome: {Nome}");
        System.Console.WriteLine($"Artista: {Artista}");
        System.Console.WriteLine($"Duração: {Duracao}");
        if(Disponivel)
        {
            System.Console.WriteLine("Disponível no plano");
        }else
        {
            System.Console.WriteLine("Adquira o Plus+");
        }
    }
}
