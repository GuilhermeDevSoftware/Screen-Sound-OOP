class Album
{
    public Album(string nome)
    {
        Nome = nome;
    }
    private List<Musica> musicas = new List<Musica>(); //Só está disponivel aqui dentro da class Album

    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica (Musica musica)
    {
        musicas.Add (musica);
    }

    public void ExibirMusicasDoAlbum ()
    {
        Console.WriteLine($"Lista de músicas do Album {Nome}\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}\n");
        }
        Console.WriteLine($"O album tem {DuracaoTotal} de minutos\n");
    }
}
