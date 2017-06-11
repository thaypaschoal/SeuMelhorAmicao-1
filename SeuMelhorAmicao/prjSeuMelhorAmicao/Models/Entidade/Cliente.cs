using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace prjSeuMelhorAmicao.Models.Entidade
{
    public class Cliente
    {
        public Cliente()
        {
            Animal = new List<Animal>();
        }

        public int Id { get; set; }

        [StringLength(1)]
        public char Genero { get; set; }
        
        public DateTime? DataNascimneto { get; set; }

        public int? Conta { get; set; }

        public Usuario Usuario { get; set; }

        public ICollection<Animal> Animal { get; set; }
    }
}