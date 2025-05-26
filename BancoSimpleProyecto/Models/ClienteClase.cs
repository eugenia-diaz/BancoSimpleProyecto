using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSimpleProyecto.Models
{
    public class ClienteClase
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Identificacion { get; set; }
    }
}
