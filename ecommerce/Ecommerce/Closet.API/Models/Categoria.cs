namespace Closet.API.Models
{
    public class CategoriaModel
    {
        public int? Id {get;set;}
        public string NomeCategoria {get;set;}
        public ICollection<RoupaModel>? Roupas {get; set;}

        public CategoriaModel(int? id, string nomeCategoria)
        {
            Id = id;
            NomeCategoria = nomeCategoria;
        }

    }
}