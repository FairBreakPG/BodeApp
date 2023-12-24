using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Sistema
{
    class DetOC
    {       
        private Producto _Producto;
        private int _CantidadProducto;
        private int _PrecioProducto;
             
        public Producto Producto
        {
            get
            {
                return _Producto;
            }
            set
            {
                _Producto = value;
            }
        }

        public DetOC()
        {

        }

        public int CantidadProducto
        {
            get
            {
                return _CantidadProducto;
            }
            set
            {
                _CantidadProducto = value;
            }
        }
        public int PrecioProducto
        {
            get
            {
                return _PrecioProducto;
            }
            set
            {
                _PrecioProducto = value;
            }
        }
        public DetOC(Producto parProducto, int parCantidadProducto, int parPrecioProducto)
        {
            this._Producto = parProducto;
            this._CantidadProducto = parCantidadProducto;
            this._PrecioProducto = parPrecioProducto;
        }
    }
    
}