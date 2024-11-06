using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_SistemaDeFacturacion
{
    //una vez hayan hecho el patron singleton, van a cambiar a que no herede de UserControl, sino BaseActualizarPanel
    //para llamar al metodo, y usar botones de alguna manera que necesiten, solo tienen que cuando hagan el botonClick
    //le metan eso si van a actualizar el panel donde se muestra la informacion
     public class BaseActualizarPanel : UserControl
        {
            protected void ActualizarPanelPrincipal(UserControl newControl)
            {
                var parentForm = this.FindForm() as PaginaPrincipal;
                if (parentForm != null)
                {
                    parentForm.UpdatePanel(newControl);
                }
            }
        }
   
}
