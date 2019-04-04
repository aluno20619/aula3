using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;


namespace Multas.Models
{
    public class Agentes
    {

        public int ID { get; set; }

        public string Nome { get; set; }

        public string Esquadra { get; set; }

        public string Fotografia { get; set; }

        public ICollection<Multas> listaMultas{ get;set;}

    }
    [ForeignKey()]

}