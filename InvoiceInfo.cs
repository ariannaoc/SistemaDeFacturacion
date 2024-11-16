using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_SistemaDeFacturacion
{
    public class InvoiceInfo
    {
        public string DocumentNumber { get; set; }
        public string FilePath { get; set; }
        public DateTime Date { get; set; }  // para la fecha 
        public int VentasMeses { get; set; }
    }


}
