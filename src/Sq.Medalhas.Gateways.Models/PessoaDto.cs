using System;

namespace Sq.Medalhas.Gateways.Models
{
    public class PessoaDto
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Regiao { get; set; }
        public long Pontuacao { get; set; }
    }
}