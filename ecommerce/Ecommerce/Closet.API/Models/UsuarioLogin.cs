using System.Runtime.CompilerServices;

namespace Closet.API.Models
{
    public class UsuarioLoginModel
    {
        public int? Id {get;set;}
        public string Email {get;set;}
        public string Senha {get;set;}

        public UsuarioLoginModel(int? id, string email, string senha)
        {
            Id = id;
            Email = email;
            Senha = senha;
        }
    }
}