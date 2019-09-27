using System.Threading.Tasks;
using Sq.Medalhas.Models;

namespace Sq.Medalhas.Services.Abstractions
{
    public interface ICalculoService
    {
        /**
         * Desafio #1:
         * ~~~~~~~~
         * Implementar o método CalcularQuadroMedalhasAsync (que retorna o quadro de medalhas de um pessoa dado seu id).
         * 
         * Desafio #2:
         * ~~~~~~~~
         * Além da implementação do método CalcularQuadroMedalhasAsync (que retorna o quadro de medalhas de um pessoa dado seu id),
         * implementar também uma sobrecarga deste método que recebe uma lista de Ids e retorne uma lista de QuadrosMedalhas sendo
         * um QuadroMedalhas para cada Id informado.
         */
        
        Task<QuadroMedalhas> CalcularQuadroMedalhasAsync(string pessoaId);
    }
}