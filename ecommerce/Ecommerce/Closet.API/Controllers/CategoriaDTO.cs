using System.Collections.Generic;
namespace Closet.API.Models
{
    public class CategoriaDTO
    {
        public string NomeCategoria {get;set;}
        
        public CategoriaDTO(string nomeCategoria)
        {
            NomeCategoria = nomeCategoria;
        }
    }
}