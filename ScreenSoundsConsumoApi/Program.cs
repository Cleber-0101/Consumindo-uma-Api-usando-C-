
//cliente
using System.Text.Json;
using ScreenSoundsConsumoApi.Filtros;
using ScreenSoundsConsumoApi.Modelos;


using (HttpClient cliente = new HttpClient())
{
    try
    {
        string resposta = await cliente.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musicas>>(resposta);
        musicas[1998].ExibirDetalhesDaMusica();
        // LinqFilter.FiltrarTodosOSGenerosMusicas(musicas);   
        // LinqOrder.ExibirListaDeArtistasOrdenados(musicas);   


        var musicasPreferidasDoCleber = new MusicaPreferidas("Cleber");
        //musicasPreferidasDoCleber.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasDoCleber.AdicionarMusicasFavoritas(musicas[4]);
        //musicasPreferidasDoCleber.AdicionarMusicasFavoritas(musicas[6]);
        //musicasPreferidasDoCleber.AdicionarMusicasFavoritas(musicas[100]);
        //musicasPreferidasDoCleber.AdicionarMusicasFavoritas(musicas[1154]);


        musicasPreferidasDoCleber.ExibirMusicasFavoritas();
        musicasPreferidasDoCleber.GerarArquivoJson();

    }
    catch(Exception ex)
    {
        Console.WriteLine($"temos um problema {ex.Message}");
    }
   
}