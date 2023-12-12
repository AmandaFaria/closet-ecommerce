using Closet.API.Models;
using Closet.Data;
using Microsoft.AspNetCore.Mvc;

namespace Closet.API.Services
{
    public class AutenticacaoService
    {
        public string AutenticarUsuario(UsuarioLoginModel usuarioLogin, CadastroUsuarioModel usuarioCadastrado)
        {
            // Verifica se o email do usuário no login corresponde ao email cadastrado
            if (usuarioLogin.Email != usuarioCadastrado.Email)
            {
                return "Email não encontrado";
            }

            // Verifica se a senha do usuário no login é igual à senha cadastrada
            if (usuarioLogin.Senha != usuarioCadastrado.Senha && usuarioLogin.Senha != usuarioCadastrado.ConfirmaSenha)
            {
                return "Senha incorreta";
            }

            // Autenticação bem-sucedida
            return "Login bem-sucedido";
        }
    }
}
