using System;
using System.Collections.Generic;

namespace apisaude.Models;

public partial class ClasseMed
{
    public int CodClasse { get; set; }

    public string NomeClasse { get; set; } = null!;

    public virtual ICollection<MatMed> MatMeds { get; } = new List<MatMed>();
}
