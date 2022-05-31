using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04_Shift_FIAP_POO_Parte2.Models
{
    class Livro : Produto
    {

        public string Autor { get; set; }
        public int NumPaginas { get; set; }
        public int AnoPublicacao { get; set; }

        public Livro(int id, string nome, string autor) : base(id, nome)
        {
            Autor = autor;

        }
    }
}
