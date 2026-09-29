# Preparando uma viagem

Exercício de programação síncrona e assíncrona em C#.

Para executar com o SDK do .NET 10 instalado:

```sh
dotnet run
```

O programa executa as duas versões em sequência:

- **Síncrona:** utiliza `Thread.Sleep` para carregar o celular por 8 segundos e depois arrumar a mala por 5 segundos. Tempo esperado: aproximadamente **13 segundos**.
- **Assíncrona:** utiliza `async Task` e `await Task.Delay`. Inicia ambas as operações antes de aguardar sua conclusão com `Task.WhenAll`. Tempo esperado: aproximadamente **8 segundos**.

Cada versão mede o tempo com `Stopwatch` e exibe “Pronto para viajar!” somente após concluir as duas atividades. A execução completa demora aproximadamente 21 segundos.

`Thread.Sleep` bloqueia a thread durante a espera. `await Task.Delay` permite aguardar sem mantê-la bloqueada. Ao iniciar as duas tarefas antes de aguardá-las, seus períodos de espera se sobrepõem.
