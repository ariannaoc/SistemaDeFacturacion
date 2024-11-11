using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_SistemaDeFacturacion
{
    public class Productos
    {
        //agregue aqui unas cosas de prueba, nada mas
        private int ID_Productos;
        private string Nombre_Productos;
        private string Estado_Productos;
        private string Descripcion_Productos;
        private int Stock_Productos;
        private string Categoria_Productos;
        private string Marca_Productos;
        public string Precio {  get; set; }
        public int cantidad { get; set; }

        public int id_productos
        {
            get { return ID_Productos; }
            set { ID_Productos = value; }
        }

        public string nombre_productos
        {
            get { return Nombre_Productos; }
            set { Nombre_Productos = value; }
        }

        public string estado_productos
        {
            get { return Estado_Productos; }
            set { Estado_Productos = value; }
        }

        public string descripcion_productos
        {
            get { return Descripcion_Productos; }
            set { Descripcion_Productos = value; }
        }

        public int stock_productos
        {
            get { return Stock_Productos; }
            set { Stock_Productos = value; }
        }
        public string categoria_productos
        {
            get { return Categoria_Productos; }
            set { Categoria_Productos = value; }
        }

        public string marca_productos
        {
            get { return Marca_Productos; }
            set { Marca_Productos = value; }
        }
    }


}
