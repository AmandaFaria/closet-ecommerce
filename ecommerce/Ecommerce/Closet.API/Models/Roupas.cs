using System.Collections.Generic;
namespace Closet.API.Models
{
    public class RoupaModel
    {
        public int? Id {get; set;}
        public string NomeRoupa {get; set;}
        public double PrecoRoupa {get; set;}
        public string DescricaoRoupa {get; set;}
        public string FotoRoupa {get; set;}
        public int Quantidade {get;set;}
        public CategoriaModel? Categoria {get; set;}

        public RoupaModel(int? id, string nomeRoupa, double precoRoupa, string descricaoRoupa, string fotoRoupa, int quantidade)
        {
            Id = id;
            NomeRoupa = nomeRoupa;
            PrecoRoupa = precoRoupa;
            DescricaoRoupa = descricaoRoupa;
            FotoRoupa = fotoRoupa;
            Quantidade = quantidade;
        }

        public RoupaModel(){}
    }
}