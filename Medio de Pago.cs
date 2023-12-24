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
    class Medio_de_Pago
    {
        private int _IdMedioPago;
        private string _NombreMedioPago;


        SqlCommand cmd;


        Conexion conex = new Conexion();

        // Metodos get and set
        public int IdMedioPago
        {
            get { return _IdMedioPago; }
            set { _IdMedioPago = value; }
        }

        public string NombreMedioPago
        {
            get { return _NombreMedioPago; }
            set { _NombreMedioPago = value; }
        }


        //constructor vacio sin Parametros
        public Medio_de_Pago()
        {

        }

        public Medio_de_Pago(string _NombreMedioPago)
        {
            this._NombreMedioPago = _NombreMedioPago;
        }

        public Medio_de_Pago(int _IdMedioPago, string _NombreMedioPago)
        {
            this._IdMedioPago = _IdMedioPago;
            this._NombreMedioPago = _NombreMedioPago;

            //constructor con los parametros
        }

        public Medio_de_Pago(int _IdMedioPago)
        {
            this._IdMedioPago = _IdMedioPago;
        }

        public bool Buscar_por_Codigo(int idMed)
        {
            try
            {
                if (conex.Conectar())
                {

                    cmd = new SqlCommand("BuscarMedioPago");
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idMedioPago", idMed);
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
                            _IdMedioPago = Convert.ToInt16(dr["idMedioPago"]);
                            _NombreMedioPago = dr["NombreMedioPago"].ToString();
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
                    cmd = new SqlCommand("InsertarMedioPago");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conex.Cn;

                    cmd.Parameters.AddWithValue("@NombreMedioPago", _NombreMedioPago);
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
                    cmd = new SqlCommand("ActualizarMedioPago");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conex.Cn;

                    cmd.Parameters.AddWithValue("@idMedioPago", _IdMedioPago);
                    cmd.Parameters.AddWithValue("@NombreMedioPago", _NombreMedioPago);
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
                    cmd = new SqlCommand("EliminarMedioPago");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conex.Cn;

                    cmd.Parameters.AddWithValue("@idMedioPago", _IdMedioPago);
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
