using ScreenSoundsConsumoApi.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSoundsConsumoApi.Filtros
{
    internal class LinqOrder
    {

        //ordena todas as musicas pelo artistas 
        public static void ExibirListaDeArtistasOrdenados(List<Musicas> musicas)
        {
            var artistasOrdenados = musicas.OrderBy(musicas => musicas.Artista).Select(musicas => musicas.Artista).Distinct().ToList();
            foreach (var artistas in artistasOrdenados)
            {
                Console.WriteLine($"- {artistas}");
            }
        }
    }
}
