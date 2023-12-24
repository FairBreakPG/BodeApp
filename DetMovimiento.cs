using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Gestor_de_Sistema
{
    class DetMovimiento
    {
        
       
        private int _FolioMov;
        private TipoMovimiento _TipoMovimiento;
        private Bodega _Bodega;
        private Producto _Producto;       
        private Producto _NombreProducto;
        private int  _CantidadProducto;
        private int _PrecioProducto;
       

       

        public int FolioMov
        {
            get
            {
                return _FolioMov;
            }
            set
            {
                _FolioMov = value;
            }
        }

        public Bodega Bodega
        {
            get
            {
                return _Bodega;
            }
            set
            {
                _Bodega = value;
            }
        }

        public TipoMovimiento TipoMovimiento
        {
            get
            {
                return _TipoMovimiento;
            }
            set
            {
                _TipoMovimiento = value;
            }
        }

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

        public Producto NombreProducto
        {
            get
            {
                return _NombreProducto;
            }
            set
            {
                _NombreProducto = value;
            }
        }

        public DetMovimiento()
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

        internal List<DetMovimiento> DetallesMovimiento { get => DetallesMovimiento; set => DetallesMovimiento = value; }

        public void AgregarBodega(Bodega ParBodega)
        {
            _Bodega = ParBodega;
        }


       

        public DetMovimiento(Producto parProducto, int parCantidadProducto, int parPrecioProducto)
        {
            this._Producto = parProducto;
            this._CantidadProducto = parCantidadProducto;
            this._PrecioProducto = parPrecioProducto;
        }

        //private DataTable objToDataTableDetMov(DetMovimiento parDetalleMov)
        //{
        //    DataTable dt = new DataTable();

        //    oTipoMovimiento = new TipoMovimiento(2);


        //    dt.Columns.Add("tProducto", System.Type.GetType("System.Int32"));
        //    dt.Columns.Add("tNombre", System.Type.GetType("System.String"));
        //    dt.Columns.Add("tCantidad", System.Type.GetType("System.Int32"));
        //    dt.Columns.Add("tPrecio", System.Type.GetType("System.Int32"));

        //    foreach (var parDetalleDetMov in _DetallesMovimiento)
        //        dt.Rows.Add(parDetalleDetMov.TipoMovimiento.IdMovimiento, parDetalleDetMov.Producto.IdProducto, parDetalleDetMov.CantidadProducto, parDetalleDetMov.PrecioProducto);
        //    _DetallesMovimiento = new List<DetMovimiento>();
        //    return dt;

        //}

      

        public DetMovimiento(TipoMovimiento parTipoMovimiento, Producto parProducto, Producto parNombreProducto, int parCantidadProducto, int parPrecioProducto)
        {
            this._TipoMovimiento = parTipoMovimiento;
            this._Producto = parProducto;
            this._NombreProducto = parNombreProducto;
            this._CantidadProducto = parCantidadProducto;
            this._PrecioProducto = parPrecioProducto;
        }

        public DetMovimiento(TipoMovimiento parTipoMovimiento, Producto parProducto, int parCantidadProducto, int parPrecioProducto)
        {
            this._TipoMovimiento = parTipoMovimiento;
            this._Producto = parProducto;
            this._CantidadProducto = parCantidadProducto;
            this._PrecioProducto = parPrecioProducto;
        }

       
    }
}
