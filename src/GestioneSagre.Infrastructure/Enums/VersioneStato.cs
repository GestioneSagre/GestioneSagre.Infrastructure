using System.ComponentModel.DataAnnotations;

namespace GestioneSagre.Infrastructure.Enums;

public enum VersioneStato
{
    [Display(Name = "Attiva")]
    Attiva,

    [Display(Name = "Deprecata")]
    Deprecata
}