using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel.DataAnnotations;
using System;

namespace Closet.API.Models
{
    public class CadastroUsuarioModel
    {
        public int? Id {get; set;}
        public string NomeUsuario {get;set;}
        public string SobrenomeUsuario {get; set;}
        public string Email {get; set;}

        [DataType(DataType.Password)]
        public string Senha {get;set;}
        [DataType(DataType.Password)]
        [Compare("Senha", ErrorMessage = "As senhas não coincidem.")]
        public string ConfirmaSenha {get;set;}
        public string Telefone {get;set;}
    

        public CadastroUsuarioModel(int? id, string nomeUsuario, string sobrenomeUsuario, string email, string senha, string confirmaSenha, string telefone)
        {
            Id = id;
            NomeUsuario = nomeUsuario;
            SobrenomeUsuario = sobrenomeUsuario;
            Email = email;
            Senha = senha;
            ConfirmaSenha = confirmaSenha;
            Telefone = telefone;
        }
    }
}