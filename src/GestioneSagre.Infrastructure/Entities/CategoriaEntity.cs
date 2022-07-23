namespace GestioneSagre.Infrastructure.Entities;

public class CategoriaEntity
{
    public int Id { get; private set; }
    public string CategoriaVideo { get; private set; } = string.Empty;
    public string CategoriaStampa { get; private set; } = string.Empty;
    public string GuidFesta { get; private set; }
    public virtual ICollection<ProdottoEntity> Prodotti { get; private set; }

    public void ChangeCategoriaVideo(string categoriaVideo)
    {
        CategoriaVideo = categoriaVideo;
    }

    public void ChangeCategoriaStampa(string categoriaStampa)
    {
        CategoriaStampa = categoriaStampa;
    }

    public void ChangeGuidFesta(string guidFesta)
    {
        GuidFesta = guidFesta;
    }
}