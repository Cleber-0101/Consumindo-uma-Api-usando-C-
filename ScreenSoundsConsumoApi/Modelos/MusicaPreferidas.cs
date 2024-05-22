using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ScreenSoundsConsumoApi.Modelos
{
    internal class MusicaPreferidas
    {
        public string? Nome { get; set; }
        public List<Musicas> ListaDeMusicas { get; set; }

        public MusicaPreferidas(string nome)
        {
            Nome = nome;
            ListaDeMusicas = new List<Musicas>();   
        }

        public void AdicionarMusicasFavoritas(Musicas musica)
        {
            ListaDeMusicas.Add(musica);
        }


        public void ExibirMusicasFavoritas()
        {
            Console.WriteLine($"Essas são as musicas favoritas {Nome}");
            foreach (var musicas in ListaDeMusicas)
            {
                Console.WriteLine($"- {musicas.Nome} de {musicas.Artista}");
            }
        }


        //transformar em string (serialise)
        //Criando arquivo json 
        internal void GerarArquivoJson()
        {
            string json = JsonSerializer.Serialize(new
            {
                nome = Nome,
                musicas = ListaDeMusicas,   
            });

            string nomeDoArquivo = $"musicas-favoritas{Nome}.json";

            File.WriteAllText(nomeDoArquivo, json);
            Console.WriteLine($"json foi criado com sucesso {Path.GetFullPath(nomeDoArquivo)}");
        }
    }
}
