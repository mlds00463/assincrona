using System.Diagnostics;

namespace PreparandoViagem;

internal class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("=== Versão síncrona ===");
        Stopwatch relogio = Stopwatch.StartNew();

        CarregarCelular();
        ArrumarMala();

        relogio.Stop();
        Console.WriteLine("Pronto para viajar!");
        Console.WriteLine($"Tempo total: {relogio.Elapsed.TotalSeconds:F1} segundos");

        Console.WriteLine("\n=== Versão assíncrona ===");
        relogio.Restart();

        // Inicia as duas operações antes de aguardar qualquer uma delas.
        Task tarefaCarregarCelular = CarregarCelularAsync();
        Task tarefaArrumarMala = ArrumarMalaAsync();

        await Task.WhenAll(tarefaCarregarCelular, tarefaArrumarMala);

        relogio.Stop();
        Console.WriteLine("Pronto para viajar!");
        Console.WriteLine($"Tempo total: {relogio.Elapsed.TotalSeconds:F1} segundos");
    }

    static void CarregarCelular()
    {
        Console.WriteLine("Carregando o celular...");
        Thread.Sleep(8000);
        Console.WriteLine("Celular carregado!");
    }

    static void ArrumarMala()
    {
        Console.WriteLine("Arrumando a mala...");
        Thread.Sleep(5000);
        Console.WriteLine("Mala arrumada!");
    }

    static async Task CarregarCelularAsync()
    {
        Console.WriteLine("Carregando o celular...");
        await Task.Delay(8000);
        Console.WriteLine("Celular carregado!");
    }

    static async Task ArrumarMalaAsync()
    {
        Console.WriteLine("Arrumando a mala...");
        await Task.Delay(5000);
        Console.WriteLine("Mala arrumada!");
    }
}
