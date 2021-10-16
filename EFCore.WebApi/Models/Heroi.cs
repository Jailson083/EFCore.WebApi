using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.WebApi.Models
{
    public class Heroi
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public IdentidadeSecreta Identidade { get; set; }

        public ICollection<Arma> Armas { get; set; }

        public  ICollection<HeroiBatalha> HeroiBatalhas { get; set; }
    }
}
