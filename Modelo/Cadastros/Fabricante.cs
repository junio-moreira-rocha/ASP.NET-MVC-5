using System.Collections.Generic;
using System.ComponentModel;


namespace Modelo.Cadastros
{
    public class Fabricante
    {
        [DisplayName("Fabricante Id")]
        public long FabricanteId { get; set; }

        [DisplayName("Fabricante Nome")]
        public string Nome { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}