using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace apisaude.Models;

public partial class Paciente
{
    public int CodPaciente { get; set; }

    public long Cpf { get; set; }

    public string NomePaciente { get; set; } = null!;

    public long? CartaoSus { get; set; }

    public string? Rua { get; set; }

    public long? NumeroCasa { get; set; }

    public string? Bairro { get; set; }

    public string? Cidade { get; set; }

    public int? Telefone { get; set; }

    public string Email { get; set; } = null!;

    public int? CodMed { get; set; }
    
    [JsonIgnore]
    public virtual Medico? CodMedNavigation { get; set; }

    public virtual ICollection<Entrega> Entregas { get; } = new List<Entrega>();
}
