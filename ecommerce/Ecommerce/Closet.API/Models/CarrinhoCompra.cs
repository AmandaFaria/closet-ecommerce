using System.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Collections.Generic;
using System.Linq;


namespace Closet.API.Models
{
    public class CarrinhoCompraModel
    {
        public int? Id { get; set; }
        public int QuantidadeCarrinho { get; set; }
        public List<RoupaModel> RoupasCarrinho { get; set; }

        public bool Comprou { get; set; }

        public CarrinhoCompraModel(int? id, int quantidadeCarrinho)
        {
            Id = id;
            QuantidadeCarrinho = quantidadeCarrinho;
        }

        public void AdicionarItem(RoupaModel roupa, int quantidade)
        {
            if (quantidade > 0 && roupa != null)
            {
                var itemExistente = RoupasCarrinho.FirstOrDefault(r => r.Id == roupa.Id);

                if (itemExistente != null)
                {
                    itemExistente.Quantidade += quantidade;
                }
                else
                {
                    RoupasCarrinho.Add(new RoupaModel(
                        id: roupa.Id,
                        nomeRoupa: roupa.NomeRoupa,
                        precoRoupa: roupa.PrecoRoupa,
                        descricaoRoupa: roupa.DescricaoRoupa,
                        fotoRoupa: roupa.FotoRoupa,
                        quantidade: quantidade
                    ));
                }

                AtualizarValorFinal();
            }
        }

        public string VerificarPagamento() => Comprou ? "Pagamento efetuado com sucesso!" : "Aguardando pagamento!";
        

        private double AtualizarValorFinal()
        {
            return RoupasCarrinho.Sum(r => r.PrecoRoupa * r.Quantidade);
        }

        public double CalcularValorFinalItem(RoupaModel roupa, int quantidade)
        {
            if (roupa != null && quantidade > 0)
            {
                return roupa.PrecoRoupa * quantidade;
            }
            else
            {
                return 0;
            }
        }
    }
}
