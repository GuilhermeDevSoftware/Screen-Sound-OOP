class Banda
{
    public Banda(string nome)
    {
        Nome = nome;
    }

    private List<Album> albums = new List<Album>();
    public string Nome { get; }

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Exibindo disco de {Nome}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Album: {album.Nome}, Tempo: [{album.DuracaoTotal}] min\n");
        }
    }
}