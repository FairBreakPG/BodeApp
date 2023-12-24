using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestor_de_Sistema
{
    class EncMovimiento
    {
       private int _FolioMov;
       private TipoMovimiento _TipoMovimiento;
       private EncOrdenCompra _EncOrdenCompra;
       private Bodega _Bodega;
       private int _NroFactura;
       private DateTime _FechaFactura;

       Bodega oBodega;
       EncOrdenCompra oEncOrdenCompra;
       TipoMovimiento oTipoMovimiento;
       private List<DetMovimiento> _DetallesMovimiento;

        Conexion conex = new Conexion();
        SqlCommand cmd;
       
        public EncMovimiento(TipoMovimiento parTipoMovimiento, EncOrdenCompra parEncOrdenCompra, Bodega parBodega, int parNroFactura, DateTime parFechaFactura)
        {
            this._TipoMovimiento = parTipoMovimiento;
            this._EncOrdenCompra = parEncOrdenCompra;
            this._Bodega = parBodega;
            this._NroFactura = parNroFactura;
            this._FechaFactura = parFechaFactura;
            DetallesMovimiento = new List<DetMovimiento>();
        }

        public EncMovimiento()
        {

        }

        // nuevo por si acaso
        public EncMovimiento(Bodega parBodega)
        {
            this._Bodega = parBodega;
        }


        public EncMovimiento(TipoMovimiento parTipoMovimiento, Bodega parBodega)
        {
            this._TipoMovimiento = parTipoMovimiento;
            this._Bodega = parBodega;
        }

        public EncMovimiento(int FolioMov)
        {
            this._FolioMov = FolioMov;
        }

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

        public EncOrdenCompra EncOrdenCompra
        {
            get
            {
                return _EncOrdenCompra;
            }
            set
            {
                _EncOrdenCompra = value;
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

        public int NroFactura
        {
            get
            {
                return _NroFactura;
            }
            set
            {
                _NroFactura = value;
            }
        }

        public DateTime FechaFactura
        {
            get
            {
                return _FechaFactura;
            }
            set
            {
                _FechaFactura = value;
            }
        }

        internal List<DetMovimiento> DetallesMovimiento { get => _DetallesMovimiento; set => _DetallesMovimiento = value; }
        
        public void AgregarBodega(Bodega ParBodega)
        {
            _Bodega = ParBodega;
        }

        public void AgregarMovimiento(TipoMovimiento ParTipoMovimiento)
        {
            _TipoMovimiento = ParTipoMovimiento;
        }

        public void AgregarOrdConpra(EncOrdenCompra ParEncOrdenCompra)
        {
            _EncOrdenCompra = ParEncOrdenCompra;
        }      

        private DataTable objToDataTableDetMov(DetMovimiento parDetalleMov)
        {           
            DataTable dt = new DataTable();

            oTipoMovimiento = new TipoMovimiento(2);
           
            dt.Columns.Add("tProducto", System.Type.GetType("System.Int32"));
            dt.Columns.Add("tNombre", System.Type.GetType("System.String"));
            dt.Columns.Add("tCantidad", System.Type.GetType("System.Int32"));
            dt.Columns.Add("tPrecio", System.Type.GetType("System.Int32"));           

            foreach (var parDetalleDetMov in _DetallesMovimiento)
                dt.Rows.Add(parDetalleDetMov.TipoMovimiento.IdMovimiento,parDetalleDetMov.Producto.IdProducto, parDetalleDetMov.CantidadProducto, parDetalleDetMov.PrecioProducto);
            _DetallesMovimiento = new List<DetMovimiento>();
            return dt;

        }

        // nuevo igual 
        //private DataTable objToDataTableDetMovi(DetMovimiento parDetalleMovi)
        //{
        //    DataTable dt = new DataTable();
        //    oTipoMovimiento = new TipoMovimiento(1);

        //    dt.Columns.Add("tProducto", System.Type.GetType("System.Int32"));
        //    dt.Columns.Add("tNombre", System.Type.GetType("System.String"));
        //    dt.Columns.Add("tCantidad", System.Type.GetType("System.Int32"));
        //    dt.Columns.Add("tPrecio", System.Type.GetType("System.Int32"));

        //    foreach (var parDetalleDetMovi in _DetallesMovimiento)
        //        dt.Rows.Add(parDetalleDetMovi.TipoMovimiento.IdMovimiento, parDetalleDetMovi.Producto.IdProducto, parDetalleDetMovi.CantidadProducto, parDetalleDetMovi.PrecioProducto);
        //    _DetallesMovimiento = new List<DetMovimiento>();
        //    return dt;

        //}



        public void AgregarLinea(Producto ParProducto, int parCantidadProducto, int parPrecioProducto)
        {

            DetMovimiento oDetMovimiento = new DetMovimiento(ParProducto, parCantidadProducto, parPrecioProducto);
            _DetallesMovimiento.Add(oDetMovimiento);
        }

        public void AgregarLineaDetMov(TipoMovimiento parTipoMovmiento, Producto parProducto, int parCantidadProducto, int parPrecioProducto)
        {

            DetMovimiento oDetMovimiento = new DetMovimiento(parTipoMovmiento, parProducto, parCantidadProducto, parPrecioProducto);
            _DetallesMovimiento.Add(oDetMovimiento);

        }

        // nuevo por si acaso
        public void AgregarLineaDetMovi(TipoMovimiento parTipoMovmiento, Producto parProducto, int parCantidadProducto, int parPrecioProducto)
        {

            DetMovimiento oDetMovimiento = new DetMovimiento(parTipoMovmiento, parProducto, parCantidadProducto, parPrecioProducto);
            _DetallesMovimiento = new List<DetMovimiento>();
            _DetallesMovimiento.Add(oDetMovimiento);

        }


        public bool GrabarRecepcionBodega()
        {
            try
            {
                if (conex.Conectar())
                {

                    oBodega = new Bodega();
                    oTipoMovimiento = new TipoMovimiento();
                    oEncOrdenCompra = new EncOrdenCompra();

                    cmd = new SqlCommand("RecepcionDeProductos");
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TpoMovimiento", _TipoMovimiento.IdMovimiento);
                    cmd.Parameters.AddWithValue("@NroOc", _EncOrdenCompra.FolioOc);
                    cmd.Parameters.AddWithValue("@Bodega", _Bodega.IdBodega);
                    cmd.Parameters.AddWithValue("@NroFactura", _NroFactura);
                    cmd.Parameters.AddWithValue("@FechaFactura", _FechaFactura);

                    SqlParameter parametroTablaDetMovimiento = cmd.Parameters.Add("@ParametroDetalleProducto", SqlDbType.Structured);
                    parametroTablaDetMovimiento.Value = objToDataTableDetMov(new DetMovimiento());

                    cmd.Connection = conex.Cn;

                    if (cmd.ExecuteNonQuery() == -1)
                    {
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        DataRow dr = null;

                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            dr = dt.Rows[0];
                            _FolioMov = (Convert.ToInt16(dr["numeroRecep"]));
                            return true;
                        }
                        MessageBox.Show("Documento grabado con exito", "Sistema de Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                    

                    return false;

                }
                MessageBox.Show("No se puede Grabar la  Recepcion de Producto", "Sistema de Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //nuevo por si acaso

        public bool GrabarSalidaBodega()
        {
            try
            {
                if (conex.Conectar())
                {
                    _Bodega = new Bodega(Bodega.IdBodega);

                    cmd = new SqlCommand("GrabarSalidaBodega");
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idBodegas", _Bodega.IdBodega);
                  
                    SqlParameter parametroTablaDetMovimientoSalida = cmd.Parameters.Add("@paramDetalleMovimientos", SqlDbType.Structured);
                    parametroTablaDetMovimientoSalida.Value = objToDataTableDetMov(new DetMovimiento());

                    cmd.Connection = conex.Cn;

                    if (cmd.ExecuteNonQuery() == -1)
                    {
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        DataRow dr = null;

                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            dr = dt.Rows[0];
                            _FolioMov = (Convert.ToInt16(dr["@NumeroSB"]));
                            return true;
                        }
                        MessageBox.Show("Documento grabado con exito", "Sistema de Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }


                    return false;

                }
                MessageBox.Show("No se puede Grabar la  Recepcion de Producto", "Sistema de Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public bool Buscar(TipoMovimiento oTipoMovimiento, EncOrdenCompra oEncOrdenCompra, Bodega oBodega,
             ref DataGridView miGrillaProducto)
        {

            try
            {
                if (conex.Conectar())

                cmd = new SqlCommand("mostrarRecepcionProductos");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Numero", FolioMov);
                cmd.Connection = conex.Cn;

                if (cmd.ExecuteNonQuery() == -1)
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataRow dr = null;

                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dr = dt.Rows[0];

                        _FolioMov = (Convert.ToInt32(dr["FolioMov"]));
                        oTipoMovimiento.IdMovimiento = (Convert.ToInt32(dr["idTipoMovimiento"]));
                        oEncOrdenCompra.FolioOc = (Convert.ToInt32(dr["NroOc"]));
                        oBodega.NombreBodega = dr["NombreBodega"].ToString();                      
                        _NroFactura = (Convert.ToInt32(dr["NroFactura"]));
                        _FechaFactura = (Convert.ToDateTime(dr["FechaFactura"]));
                       
                        AgregarOrdConpra(oEncOrdenCompra);
                        AgregarBodega(oBodega);
                        AgregarMovimiento(oTipoMovimiento);
                       
                        miGrillaProducto.DataSource = dt;

                        return true;
                    }
                    else
                        MessageBox.Show("Codigo Ingresado no existe", "Sistema de Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool BuscarIdBodega(/*TipoMovimiento oTipomovimiento,*/ Bodega oBodega, ref DataGridView GRIDVIEWsalidaB)
        {
            try
            {
                if (conex.Conectar())

                cmd = new SqlCommand("mostrarSalidaProductosBodega");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Numero", FolioMov);
                cmd.Connection = conex.Cn;

                if (cmd.ExecuteNonQuery() == -1)
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataRow dr = null;

                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dr = dt.Rows[0];

                        _FolioMov = (Convert.ToInt32(dr["FolioMov"]));

                        //(//oTipoMovimiento = new TipoMovimiento();) no era necesario
                        ///
                        //oTipomovimiento.NombreMovimiento = dr["NombreTpoMovimiento"].ToString();
                        //AgregarMovimiento(oTipomovimiento);

                        oBodega.NombreBodega = dr["NombreBodega"].ToString();                      
                        AgregarBodega(oBodega);

                        GRIDVIEWsalidaB.DataSource = dt;

                        return true;
                    }
                    else
                        return false;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    }
}
