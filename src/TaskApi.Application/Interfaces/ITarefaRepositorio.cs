using TaskApi.Application.DTOs;
using TaskApi.Domain.Entities;
namespace TaskApi.Application.Interfaces;


public interface ITarefaRepositorio
{
    Task<Tarefa?> ObterPorIdAsync(
        Guid id,
        CancellationToken cancellationToken);

    Task<IReadOnlyList<Tarefa>> ListarAsync(
        FiltroTarefaDto filtro,
        CancellationToken cancellationToken);

    Task AdicionarAsync(
        Tarefa tarefa,
        CancellationToken cancellationToken);

    void Remover(Tarefa tarefa);

    Task SalvarAlteracoesAsync(
        CancellationToken cancellationToken);
}
