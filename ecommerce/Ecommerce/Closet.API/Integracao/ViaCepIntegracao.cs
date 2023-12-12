using Closet.API.Integracao.Refit;
using Closet.API.Integracao.Response;
using Closet.Integracao.Interfaces;

namespace Closet.API.Integracao
{
    public class ViaCepIntegracao : IViaCepIntegracao
    {
        private readonly IViaCepIntegracaoRefit _viaCepIntegracaoRefit;
        public ViaCepIntegracao(IViaCepIntegracaoRefit _viaCepIntegracaoRefit)
        {
            this._viaCepIntegracaoRefit = _viaCepIntegracaoRefit;
        } 
        public async Task<ViaCepResponse> ObterDadosViaCep(string cep)
        {
            var responseData = await _viaCepIntegracaoRefit.ObterDadosViaCep(cep);


            if(responseData != null && responseData.IsSuccessStatusCode)
            {
                return responseData.Content;
            }

            return null;
        }
    }
}