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
    class TipoMovimiento
    {
        //Declaraciones de las variables
        private int _idMovimiento;
        private int _OperacionMovimiento;
        private string _NombreMovimiento;

        SqlCommand cmd;
        Conexion conex = new Conexion();

        // Metodos get and set
        public int IdMovimiento
        {
            get { return _idMovimiento; }
            set { _idMovimiento = value; }
        }

        public int OperacionMovimiento
        {
            get { return _OperacionMovimiento; }
            set { _OperacionMovimiento = value; }
        }

        public string NombreMovimiento
        {
            get { return _NombreMovimiento; }
            set { _NombreMovimiento = value; }
        }

        //constructor vacio sin Parametros
        public TipoMovimiento()
        {

        }

        public TipoMovimiento(string _NombreMovimiento, int _OperacionMovimiento)
        {
            this._NombreMovimiento = _NombreMovimiento;
            this._OperacionMovimiento = _OperacionMovimiento;
        }

        public TipoMovimiento(int _idMovimiento, int _OperacionMovimiento, string _NombreMovimiento)
        {
            this._idMovimiento = _idMovimiento;
            this._NombreMovimiento = _NombreMovimiento;
            this._OperacionMovimiento = _OperacionMovimiento;

            //constructor con los parametros
        }
       
        public TipoMovimiento( int _idMovimiento)
        {
            this._idMovimiento = _idMovimiento;  
        }


        public bool Buscar_por_Codigo(int idBod)
        {
            try
            {
                if (conex.Conectar())
                {

                    cmd = new SqlCommand("BuscarTipoMovimiento");
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idTipoMovimiento", idBod);
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
                            _idMovimiento = Convert.ToInt32(dr["idTipoMovimiento"]);
                            _NombreMovimiento = dr["NombreTpoMovimiento"].ToString();
                            _OperacionMovimiento = Convert.ToInt32(dr["OperacionMovimiento"]);
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
                    cmd = new SqlCommand("InsertarTipoMovimiento");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conex.Cn;

                    cmd.Parameters.AddWithValue("@NombreTpoMovimiento", _NombreMovimiento);
                    cmd.Parameters.AddWithValue("@OperacionMovimiento", _OperacionMovimiento);
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
                    cmd = new SqlCommand("ActualizarTipoMovimiento");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conex.Cn;

                    cmd.Parameters.AddWithValue("@idTipoMovimiento", _idMovimiento);
                    cmd.Parameters.AddWithValue("@NombreTpoMovimiento", _NombreMovimiento);
                    cmd.Parameters.AddWithValue("@OperacionMovimiento", _OperacionMovimiento);
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
                    cmd = new SqlCommand("EliminarTipoMovimiento");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conex.Cn;

                    cmd.Parameters.AddWithValue("@idTipoMovimiento", _idMovimiento);
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
