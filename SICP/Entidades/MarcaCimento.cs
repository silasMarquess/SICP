using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICP.Entidades
{
    class MarcaCimento
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public MarcaCimento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

    }
}
