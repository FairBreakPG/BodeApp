using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Forms;

namespace Gestor_de_Sistema
{
    class Familia
    {
        //Declaraciones de las variables
        private int _idFamilia;
        private string _NombreFamilia;

        SqlCommand cmd;
        Conexion conex = new Conexion();

        // Metodos get and set
        public int IdFamilia
        {
            get { return _idFamilia; }
            set { _idFamilia = value; }
        }

        public string NombreFamilia
        {
            get { return _NombreFamilia; }
            set { _NombreFamilia = value; }
        }

        //constructor vacio sin Parametros
        public Familia()
        {

        }

        public Familia(string _NombreFamilia)
        {
            this._NombreFamilia = _NombreFamilia;
        }

        public Familia(int _idFamilia, string _NombreFamilia)
        {
            this._idFamilia = _idFamilia;
            this._NombreFamilia = _NombreFamilia;

            //constructor con los parametros
        }

        public Familia(int _idFamilia)
        {
            this._idFamilia = _idFamilia;
        }

        public bool Buscar_por_Codigo(int idFam)
        {
            try
            {
                if (conex.Conectar())
                {

                    cmd = new SqlCommand("BuscarFamilia");
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idFamilia", idFam);
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
                            _idFamilia = Convert.ToInt16(dr["idFamilia"]);
                            _NombreFamilia = dr["NombreFamilia"].ToString();
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

        public bool BuscarCodigo(int idFam)
        {
            try
            {
                if (conex.Conectar())
                {

                    cmd = new SqlCommand("BuscarIDFamilia");
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idFamilia", idFam);
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
                            _idFamilia = Convert.ToInt16(dr["idFamilia"]);
                            _NombreFamilia = dr["NombreFamilia"].ToString();
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
                    cmd = new SqlCommand("InsertarFamilia");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conex.Cn;

                    cmd.Parameters.AddWithValue("@NombreFamilia", _NombreFamilia);
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
                    cmd = new SqlCommand("ActualizarFamilia");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conex.Cn;

                    cmd.Parameters.AddWithValue("@idFamilia", _idFamilia);
                    cmd.Parameters.AddWithValue("@NombreFamilia", _NombreFamilia);
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
                    cmd = new SqlCommand("EliminarFamilia");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conex.Cn;

                    cmd.Parameters.AddWithValue("@idFamilia", _idFamilia);
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
                    cmd = new SqlCommand("BuscarFamilia");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conex.Cn;

                    if (cmd.ExecuteNonQuery() == -1)
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            cboControl.DataSource = dt;
                            cboControl.DisplayMember = "NombreFamilia";
                            cboControl.ValueMember = "idFamilia";
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
