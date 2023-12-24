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
    class Comprador
    {
        private int _Rut, _EstadoComprador;
        private string _DV, _NombreComprador, _ApellidoComprador;
         


        SqlCommand cmd;


        Conexion conex = new Conexion();

        // Metodos get and set
        public int Rut
        {
            get { return _Rut; }
            set { _Rut = value; }
        }

        public string DV
        {
            get { return _DV; }
            set { _DV = value; }
        }
        public string NombreComprador
        {
            get { return _NombreComprador; }
            set { _NombreComprador = value; }
        }
        public string ApellidoComprador
        {
            get { return _ApellidoComprador; }
            set { _ApellidoComprador = value; }
        }
        public int EstadoComprador
        {
            get { return _EstadoComprador; }
            set { _EstadoComprador = value; }
        }

        public Comprador()
        {

        }

        public Comprador(string _DV)
        {
            this._DV = _DV;
        }


        public Comprador(int _Rut, string _DV, string _NombreComprador, string _ApellidoComprador, int _EstadoComprador)
        {
            this._Rut = _Rut;
            this._DV = _DV;
            this._NombreComprador = _NombreComprador;
            this._ApellidoComprador = _ApellidoComprador;
            this._EstadoComprador = _EstadoComprador;
        }

        public Comprador(int _Rut)
        {
            this._Rut = _Rut;
        }

        public bool Buscar_por_Rut(int rut)
        {
            try
            {
                if (conex.Conectar())
                {

                    cmd = new SqlCommand("BuscarComprador");
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RutComprador", rut);
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
                            _Rut = Convert.ToInt32(dr["RutComprador"]);
                            _DV = dr["DvComprador"].ToString();
                            _NombreComprador = dr["NombreComprador"].ToString();
                            _ApellidoComprador = dr["ApellidoComprador"].ToString();
                            _EstadoComprador = Convert.ToInt32(dr["EstadoComprador"]);
                            return true;
                        }
                        MessageBox.Show("Sr. Usuario, Codigo ingresado no existe");
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
        public bool Insertar()
        {
            try
            {
                if (conex.Conectar())
                {
                    cmd = new SqlCommand("InsertarComprador");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conex.Cn;
                    cmd.Parameters.AddWithValue("@RutComprador", _Rut);
                    cmd.Parameters.AddWithValue("@DvComprador", _DV);
                    cmd.Parameters.AddWithValue("@NombreComprador", _NombreComprador);
                    cmd.Parameters.AddWithValue("@ApellidoComprador", _ApellidoComprador);
                    cmd.Parameters.AddWithValue("@EstadoComprador", _EstadoComprador);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Sr. Usuario, El registro ha sido grabado con exito", "Ejemplo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public bool Actualizar()
        {
            try
            {
                if (conex.Conectar())
                {
                    cmd = new SqlCommand("ActualizarComprador");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conex.Cn;

                    cmd.Parameters.AddWithValue("@RutComprador", _Rut);
                    cmd.Parameters.AddWithValue("@DvComprador", _DV);
                    cmd.Parameters.AddWithValue("@NombreComprador", _NombreComprador);
                    cmd.Parameters.AddWithValue("@ApellidoComprador", _ApellidoComprador);
                    cmd.Parameters.AddWithValue("@EstadoComprador", _EstadoComprador);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Sr. Usuario, El registro ha sido actualizado con exito", "Ejemplo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public bool Eliminar()
        {
            try
            {
                if (conex.Conectar())
                {
                    cmd = new SqlCommand("ELIMINARcompradores");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conex.Cn;

                    cmd.Parameters.AddWithValue("@RutComprador", _Rut);
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
