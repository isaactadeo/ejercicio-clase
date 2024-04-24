using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WireTechSERVICE
{
    public class PagoServicio
    {
        public int CodAutoIncremental { get; set; }
        public int FechaDeCobro { get; set; }
        public int DniUserPagador { get; set; }
        public int CodigoServicioPagado { get; set; }
        public double Importe { get; set; }
    }
}
