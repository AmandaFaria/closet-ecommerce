using System.Collections.Generic;
namespace Closet.API.Models
{
    public class RoupaDTO
    {
        public string NomeRoupa {get; set;}
        public double PrecoRoupa {get; set;}
        public string DescricaoRoupa {get; set;}
        public string FotoRoupa {get; set;}
        public int Quantidade {get;set;}
        public int CategoriaID {get; set;}

        public RoupaDTO(string nomeRoupa, double precoRoupa, string descricaoRoupa, string fotoRoupa, int quantidade, int categoriaID)
        {
            NomeRoupa = nomeRoupa;
            PrecoRoupa = precoRoupa;
            DescricaoRoupa = descricaoRoupa;
            FotoRoupa = fotoRoupa;
            Quantidade = quantidade;
            CategoriaID = categoriaID;
        }
    }
}