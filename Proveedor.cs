using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Gestor_de_Sistema
{
    class Proveedor
    {
        private int _Rut;
        private string _DV, _RazonSocial, _Direccion;


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
        public string RazonSocial
        {
            get { return _RazonSocial; }
            set { _RazonSocial = value; }
        }
        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        public Proveedor()
        {

        }

        public Proveedor(string _DV)
        {
            this._DV = _DV;
        }
       

        public Proveedor(int _Rut, string _DV, string _RazonSocial, string _Direccion)
        {
            this._Rut = _Rut;
            this._DV = _DV;
            this._RazonSocial = _RazonSocial;
            this._Direccion = _Direccion;

            //constructor con los parametros
        }

       
        public Proveedor(int _Rut)
        {
            this._Rut = _Rut;
        }

        public bool Buscar_por_Rut(int rut)
        {
            try
            {
                if (conex.Conectar())
                {

                    cmd = new SqlCommand("BuscarProveedor");
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Rut", rut);
                    cmd.Connection = conex.Cn;

                    //For UPDATE, INSERT, and DELETE statements, the return value is the number of rows affected by the command. 
                    //For all other types of statements, the return value is -1.
                    if (cmd.ExecuteNonQuery() == -1)
                    {
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataRow dr = null;

                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            dr = dt.Rows[0];
                            _Rut = Convert.ToInt32(dr["Rut"]);
                            _DV = dr["DV"].ToString();
                            _RazonSocial = dr["RazonSocial"].ToString();
                            _Direccion = dr["Direccion"].ToString();
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
                    cmd = new SqlCommand("InsertarProveedor");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conex.Cn;

                    cmd.Parameters.AddWithValue("@Rut", _Rut);
                    cmd.Parameters.AddWithValue("@DV", _DV);
                    cmd.Parameters.AddWithValue("@RazonSocial", _RazonSocial);
                    cmd.Parameters.AddWithValue("@Direccion", _Direccion);
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
                    cmd = new SqlCommand("ActualizarProveedor");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conex.Cn;

                    cmd.Parameters.AddWithValue("@Rut", _Rut);
                    cmd.Parameters.AddWithValue("@DV", _DV);
                    cmd.Parameters.AddWithValue("@RazonSocial", _RazonSocial);
                    cmd.Parameters.AddWithValue("@Direccion", _Direccion);
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
                    cmd = new SqlCommand("EliminarProveedor");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conex.Cn;

                    cmd.Parameters.AddWithValue("@Rut", _Rut);
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
