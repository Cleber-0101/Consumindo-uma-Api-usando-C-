﻿

using System.Text.Json.Serialization;

namespace ScreenSoundsConsumoApi.Modelos;

//Criando classe e dessarializando
internal class Musicas
{
    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Duração: {Duracao /1000}");
        Console.WriteLine($"Genero: {Genero}");
    }
}
