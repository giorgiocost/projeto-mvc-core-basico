using System;

namespace projeto_mvc_core_basico.Models
{
    public class Produto : Entity
    {
        public Guid FornecedorId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public decimal DataCadastro { get; set; }
        public bool Ativo { get; set; }

        /* EF relacionamento N para 1*/
        public Fornecedor Fornecedor { get; set; }
    }
}