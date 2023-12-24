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
    class Bodega
    {
        //Declaraciones de las variables
        private int _idBodega;
        private string _NombreBodega;

        SqlCommand cmd;
       

        Conexion conex = new Conexion();

        // Metodos get and set
        public int IdBodega
        {
            get { return _idBodega; }
            set { _idBodega = value; }
        }
        public string NombreBodega
        {
            get { return _NombreBodega; }
            set { _NombreBodega = value; }
        }

        //constructor vacio sin Parametros
        public Bodega()
        {

        }

        public Bodega(string _NombreBodega)
        {
            this._NombreBodega = _NombreBodega;
        }

        public Bodega(int _idBodega, string _NombreBodega)
        {
            this._idBodega = _idBodega;
            this._NombreBodega = _NombreBodega;

            //constructor con los parametros
        }

        public Bodega(int _idBodega)
        {
            this._idBodega = _idBodega;
        }

        public bool Buscar_por_Codigo(int idBod)
        {
            try
            {
                if (conex.Conectar())
                {

                    cmd = new SqlCommand("BuscarBodega");
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idBodegas", idBod);
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
                            _idBodega = Convert.ToInt16(dr["idBodegas"]);
                            _NombreBodega = dr["NombreBodega"].ToString();
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
                    cmd = new SqlCommand("InsertarBodega");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conex.Cn;

                    cmd.Parameters.AddWithValue("@NombreBodega", _NombreBodega);
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
                    cmd = new SqlCommand("ActualizarBodegas");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conex.Cn;

                    cmd.Parameters.AddWithValue("@idBodegas", _idBodega);
                    cmd.Parameters.AddWithValue("@NombreBodega", _NombreBodega);
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
                    cmd = new SqlCommand("EliminarBodega");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conex.Cn;

                    cmd.Parameters.AddWithValue("@idBodegas", _idBodega);
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

        public void CBOMostrar(ref ComboBox cboControl)
        {
            DataTable dt = new DataTable();
            try
            {
                if (conex.Conectar())
                {
                    cmd = new SqlCommand("BuscarBodegas");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conex.Cn;

                    if (cmd.ExecuteNonQuery() == -1)
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            cboControl.DataSource = dt;
                            cboControl.DisplayMember = "NombreBodega";
                            cboControl.ValueMember = "idBodegas";
                            cboControl.SelectedValue = 0;
                        }
                        else cboControl.DataSource = null;
                    }
                    else cboControl.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Reportar este Error a Soporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboControl.DataSource = null;

            }
            finally
            {
                if (conex.Cn != null && conex.Cn.State == ConnectionState.Open) conex.Cn.Close();
            }
        }

    }
}
