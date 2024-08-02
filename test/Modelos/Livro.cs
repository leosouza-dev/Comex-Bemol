using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Modelos
{
    public class Livro : Produto, IIdentificavel
    {
        public Livro(string nome) : base(nome)
        {
        }

        public string Isbn { get; set; }
        public int TotalDePaginas { get; set; }

        public string Identificar()
        {
            return $"Livro: {Nome}, ISBN: {Isbn}";
        }
    }
}
