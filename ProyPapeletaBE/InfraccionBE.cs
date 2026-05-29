using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyPapeletaBE
{
    public class InfraccionBE
    {
        // Campos principales de la infracción
        public String COD_INFRACCION { get; set; }
        public String DESCRIPCION_SANCION { get; set; }
        public String CALIFICACION { get; set; }
        public Int32 PUNTOS { get; set; }
        public Decimal UIT { get; set; }
        public DateTime FEC_REGISTRO { get; set; }
        public String USU_REGISTRO { get; set; }
        public DateTime FEC_ULT_MODIFICACION { get; set; }
        public String USU_ULT_MODIFICACION { get; set; }

        public bool ESTADO { get; set; }
    }
}