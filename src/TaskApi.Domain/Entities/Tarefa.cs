using TaskApi.Domain.Enums;

namespace TaskApi.Domain.Entities;

public sealed class Tarefa
{
    public Guid Id { get; private set; }
    public string Titulo { get; private set; }
    public string? Descricao { get; private set; }
    public DateTimeOffset? DataVencimento { get; private set; }
    public StatusTarefa Status { get; private set; }
    public DateTimeOffset CriadaEmUtc { get; private set; }
    public DateTimeOffset? AtualizadaEmUtc { get; private set; }

    private Tarefa()
    {
        Titulo = string.Empty;
    }

    public Tarefa(
        string titulo,
        string? descricao,
        DateTimeOffset? dataVencimento)
    {
        Id = Guid.NewGuid();
        Titulo = titulo;
        Descricao = descricao;
        DataVencimento = dataVencimento;
        Status = StatusTarefa.Pendente;
        CriadaEmUtc = DateTimeOffset.UtcNow;
    }

    public void AtualizarDetalhes(
        string titulo,
        string? descricao,
        DateTimeOffset? dataVencimento)
    {
        Titulo = titulo;
        Descricao = descricao;
        DataVencimento = dataVencimento;
        AtualizadaEmUtc = DateTimeOffset.UtcNow;
    }

    public void AlterarStatus(StatusTarefa novoStatus)
    {
        Status = novoStatus;
        AtualizadaEmUtc = DateTimeOffset.UtcNow;
    }
}
