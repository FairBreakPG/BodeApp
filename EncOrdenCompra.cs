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
    class EncOrdenCompra
    {
        // declarion de los variables
        private int _FolioOc;
        private DateTime _FechaEmision;
        private string _Obvservaciones;
        private DateTime _FechaEntrega;
        //variable de tipo Objeto
        private Comprador _Comprador;
        private Proveedor _Proveedor;
        //variable Objeto de tipo Lista
        private List <DetPago> _DetallesPago;
        private List<DetOC> _DetallesOC;
        Comprador oComprador;
        Proveedor oProveedor;

        Conexion conex = new Conexion();
        SqlCommand cmd;
        SqlCommand cmd2;
        // las propriedades de la clase EncOrdenCompra

        public EncOrdenCompra()
        {

        }

        public EncOrdenCompra(int FolioOc)
        {
            this._FolioOc = FolioOc;
        }

        public EncOrdenCompra(DateTime FechaEmision, string Observaciones, DateTime FechaEntrega, Comprador ParComprador, Proveedor ParProveedor)
        {
            this._FechaEmision = FechaEmision;
            this._Obvservaciones = Observaciones;
            this._FechaEntrega = FechaEntrega;
            this._Comprador = ParComprador;
            this._Proveedor = ParProveedor;
            DetallesPago = new List<DetPago>();          
            DetallesOC = new List<DetOC>();
        }

       
        // Declaraciones de las propriedades
        public int FolioOc
        {
            get
            {
                return _FolioOc;
            }
            set
            {
                _FolioOc = value;
            }
        }
        public DateTime FechaEmision
        {
            get
            {
                return _FechaEmision;
            }
            set
            {
                _FechaEmision = value;
            }
        }
        public string Observaciones
        {
            get
            {
                return _Obvservaciones;
            }
            set
            {
                _Obvservaciones = value;
            }
        }
        public DateTime FechaEntrega
        {
            get
            {
                return _FechaEntrega;
            }
            set
            {
                _FechaEntrega = value;
            }
        }

        public Comprador Comprador
        {
            get
            {
                return _Comprador;
            }
            set
            {
                _Comprador = value;
            }
        }

        public Proveedor Proveedor
        {
            get
            {
                return _Proveedor;
            }
            set
            {
                _Proveedor = value;
            }
        }

        internal List<DetOC> DetallesOC { get => _DetallesOC; set => _DetallesOC = value; }
        internal List<DetPago> DetallesPago { get => _DetallesPago; set => _DetallesPago = value; }

        public void AgregarComprador(Comprador ParComprador)
        {
            _Comprador = ParComprador;
        }

        public void AgregarProveedor(Proveedor ParProveedor)
        {
            _Proveedor = ParProveedor;
        }

        public bool GrabarOrdenCompra()
        {
            try
            {
                if (conex.Conectar())
                {
                    oProveedor = new Proveedor();
                    oComprador = new Comprador();

                    cmd = new SqlCommand("grabarOrdenCompra"); 
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FechaEmision", _FechaEmision);
                    cmd.Parameters.AddWithValue("@Observaciones", _Obvservaciones);
                    cmd.Parameters.AddWithValue("@FechaEntrega", _FechaEntrega);
                    cmd.Parameters.AddWithValue("@RutComprador", _Comprador.Rut);
                    cmd.Parameters.AddWithValue("@RutProveedor", _Proveedor.Rut);

                    SqlParameter parametroTablaDetOc = cmd.Parameters.Add("@paramDetalleProductos", SqlDbType.Structured);
                    parametroTablaDetOc.Value = objToDataTableOC(new DetOC());

                    SqlParameter parametroTablaDetPago = cmd.Parameters.Add("@paramDetallePago", SqlDbType.Structured);
                    parametroTablaDetPago.Value = objToDataTablePago(new DetPago());

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
                            _FolioOc =(Convert.ToInt16(dr["FolioOc"]));
                            return true;
                           
                        }
                        MessageBox.Show("Documento grabado con exito", "Sistema de Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                    return false;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private DataTable objToDataTableOC(DetOC parDetalleOrC)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("tProducto", System.Type.GetType("System.Int32"));
            dt.Columns.Add("tCantidad", System.Type.GetType("System.Int32"));
            dt.Columns.Add("tPrecio", System.Type.GetType("System.Int32"));

            foreach (var parDetalleOc in _DetallesOC)
            dt.Rows.Add(parDetalleOc.Producto.IdProducto, parDetalleOc.CantidadProducto, parDetalleOc.PrecioProducto);

            return dt;
        }

        private DataTable objToDataTablePago(DetPago parDetalleDetPa)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("tMedio_de_Pago", System.Type.GetType("System.Int32"));
            dt.Columns.Add("tFechaPago", System.Type.GetType("System.DateTime"));
            dt.Columns.Add("tMontoPago", System.Type.GetType("System.Int32"));

            foreach (var parDetallePago in _DetallesPago)
            dt.Rows.Add(parDetallePago.Medio_De_Pago.IdMedioPago, parDetallePago.FechaPago, parDetallePago.MontoPago);
            return dt;
        }

        public bool Buscar(Comprador oComprador, Proveedor oProveedor, 
            ref DataGridView miGrillaProducto, ref DataGridView miGrillaPagos)
        {
            try
            {
                if (conex.Conectar())
                cmd = new SqlCommand("mostrarOrdendeCompra_Productos");
                cmd2 = new SqlCommand("mostrarOrdendeCompra_Pagos");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Numero", FolioOc);
                cmd2.Parameters.AddWithValue("@Numero", FolioOc);

                cmd.Connection = conex.Cn;
                cmd2.Connection = conex.Cn;

                if (cmd.ExecuteNonQuery() == -1)
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataRow dr = null;

                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dr = dt.Rows[0];

                        _FolioOc = (Convert.ToInt32(dr["FolioOc"]));
                        _FechaEmision = (Convert.ToDateTime(dr["FechaEmision"]));
                        _Obvservaciones = dr["Observaciones"].ToString();
                        _FechaEntrega = (Convert.ToDateTime(dr["FechaEntrega"]));
                        oComprador.Rut = (Convert.ToInt32(dr["RutComprador"]));
                        oComprador.NombreComprador = dr["NombreComprador"].ToString();
                        oProveedor.Rut = (Convert.ToInt32(dr["RutProveedor"]));
                        oProveedor.RazonSocial = dr["RazonSocial"].ToString();

                        AgregarComprador(oComprador);
                        AgregarProveedor(oProveedor);
                        miGrillaProducto.DataSource = dt;

                        if (cmd2.ExecuteNonQuery() == -1)
                        {
                            DataTable dt2 = new DataTable();
                            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                            
                            da2.Fill(dt2);
                            miGrillaPagos.DataSource = dt2;
                        }                    
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public bool BuscarEncOrdCompra(int FolioOc)
           
        {
            try
            {
                if (conex.Conectar())
                cmd = new SqlCommand("mostrarOrdendeCompra_Productos");              
                cmd.CommandType = CommandType.StoredProcedure;              
                cmd.Parameters.AddWithValue("@Numero", FolioOc);              
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

                        _FolioOc = (Convert.ToInt32(dr["FolioOc"]));
                    }
                    else
                        MessageBox.Show("Codigo Ingresado no existe", "Sistema de Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void AgregarLinea(Producto ParProducto, int parCantidadProducto, int parPrecioProducto)
        {
            DetOC oDetalle = new DetOC(ParProducto, parCantidadProducto, parPrecioProducto);
            _DetallesOC.Add(oDetalle);
        }

        public void AgregarLineaD(Medio_de_Pago parMedio_de_Pago, DateTime parFechapago, int parMontoPago)
        {
            DetPago oDetallePago = new DetPago(parMedio_de_Pago, parFechapago, parMontoPago);
            _DetallesPago.Add(oDetallePago);
        }

        public bool Eliminar(int FolioOc)
        {
            try
            {
                if (conex.Conectar())
                {
                    _FolioOc = FolioOc;
                    cmd = new SqlCommand("EliminarOC");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conex.Cn;

                    cmd.Parameters.AddWithValue("@Numero", _FolioOc);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Sr. Usuario, El registro ha sido Eliminado con exito", "Ejemplo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;

                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Reportar este Error a Soporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            finally
            {
                if (conex.Cn != null && conex.Cn.State == ConnectionState.Open) conex.Cn.Close();
            }
        }

       
    }
}
