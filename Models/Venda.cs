using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExemploExplorando.Models
{
    public class Venda
    {
        public Venda(int id, string proudto, decimal preco, DateTime dataVenda)
        {
            this.Id = id;
            this.Produto = proudto;
            this.Preco = preco;
            this.DataVenda = dataVenda;
        }

        public int Id { get; set; }
        [JsonProperty("Nome_Produto")]
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }

        
    }
}