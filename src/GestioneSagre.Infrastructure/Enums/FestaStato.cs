using System.ComponentModel.DataAnnotations;

namespace GestioneSagre.Infrastructure.Enums;

public enum FestaStato
{
    [Display(Name = "Creata")]
    Creata,

    [Display(Name = "In corso")]
    InCorso,

    [Display(Name = "Conclusa")]
    Conclusa,

    [Display(Name = "Eliminata")]
    Eliminata
}