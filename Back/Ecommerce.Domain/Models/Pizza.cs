using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Domain.Enum;

namespace Ecommerce.Domain.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public decimal Preco { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public CategoriaDePizza Categoria { get; set; }
    }
}