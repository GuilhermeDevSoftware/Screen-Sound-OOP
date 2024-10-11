Banda theDoors = new Banda("The Doors");

Album albumTheDoors = new Album("L.A.Woman");

Musica musica = new Musica(theDoors, "Ride on the Storm")
{
    Duracao = 7,
    Disponivel = true,
};


Musica musica2 = new Musica(theDoors, "People Are Strange")
{
    Duracao = 5,
    Disponivel = false,
};

albumTheDoors.AdicionarMusica(musica);
albumTheDoors.AdicionarMusica(musica2);
theDoors.AdicionarAlbum(albumTheDoors);

theDoors.ExibirDiscografia();
musica.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();