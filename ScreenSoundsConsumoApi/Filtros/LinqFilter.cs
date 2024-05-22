
using ScreenSoundsConsumoApi.Modelos;
using System.Linq;

namespace ScreenSoundsConsumoApi.Filtros;

internal class LinqFilter
{

    //filtrando todos os geneneros musicais 
    public static void FiltrarTodosOSGenerosMusicas(List<Musicas> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }
}
