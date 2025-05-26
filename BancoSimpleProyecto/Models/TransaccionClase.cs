using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSimpleProyecto.Models
{
    public class TransaccionClase
    {
        [Key]
        public int TransaccionId { get; set; }
        public decimal Monto { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        public string Description { get; set; }

        public int CuentaOrigenId { get; set; }

        public int CuentaDestinoId { get; set; }

    }
}
