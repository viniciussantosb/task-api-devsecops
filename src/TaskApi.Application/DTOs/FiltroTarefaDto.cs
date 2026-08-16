using TaskApi.Domain.Enums;

namespace TaskApi.Application.DTOs;

public sealed record FiltroTarefaDto(
    StatusTarefa? Status,
    DateTimeOffset? DataVencimentoDe,
    DateTimeOffset? DataVencimentoAte);
