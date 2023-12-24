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
    class SubFamilia
    {
        int _idSubFamilia;
        string _NombreSubFamilia;
        Familia familia;



        Conexion conex = new Conexion();


        SqlCommand cmd;

        public int IdSubFamilia
        {
            get
            {
                return _idSubFamilia;
            }

            set
            {
                _idSubFamilia = value;
            }
        }

        public string NombreSubFamilia
        {
            get
            {
                return _NombreSubFamilia;
            }

            set
            {
                _NombreSubFamilia = value;
            }
        }

        internal Familia Familia
        {
            get
            {
                return familia;
            }

            set
            {
                familia = value;
            }
        }

        public SubFamilia()
        {
            
        }

        public SubFamilia(int _idSubFamilia)
        {
            this._idSubFamilia = _idSubFamilia;
        }

        public SubFamilia(int _idSubFamilia, string _NombreSubfamilia)
        {
            this._idSubFamilia = _idSubFamilia;
            this._NombreSubFamilia = _NombreSubfamilia;
        }


        public SubFamilia(string _NombreSubFamilia, Familia familia)
        {
            this._NombreSubFamilia = _NombreSubFamilia;
            this.familia = familia;
        }

        public SubFamilia(int _idSubFamilia, string _NombreSubFamilia, Familia familia)
        {
            this._idSubFamilia = _idSubFamilia;
            this._NombreSubFamilia = _NombreSubFamilia;
            this.familia = familia;
        }

        public bool Buscar_por_Codigo(int idSub, ref Familia oFamilia)
        {
            try
            {
                if (conex.Conectar())
                {
                    _idSubFamilia = idSub;
                    cmd = new SqlCommand("BuscarSubFAMILIA");
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idSubFamilia", _idSubFamilia);
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
                            _NombreSubFamilia = dr["NombreSubFamilia"].ToString();
                            familia = new Familia(Convert.ToInt16(dr["Familia"]));
                            oFamilia = familia;

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
                    cmd = new SqlCommand("InsertarSubFAMILIA");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conex.Cn;


                    cmd.Parameters.AddWithValue("@NombreSubFamilia", _NombreSubFamilia);
                    cmd.Parameters.AddWithValue("@Familia", familia.IdFamilia);
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
                    cmd = new SqlCommand("ActualizarSubFAMILIA");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conex.Cn;
                    cmd.Parameters.AddWithValue("@idSubFamilia", _idSubFamilia);
                    cmd.Parameters.AddWithValue("@NombreSubFamilia", _NombreSubFamilia);
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
        public bool Eliminar(int idSubFamilia)
        {
            try
            {
                if (conex.Conectar())
                {
                    _idSubFamilia = idSubFamilia;
                    cmd = new SqlCommand("EliminarSubFAMILIA");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conex.Cn;

                    cmd.Parameters.AddWithValue("@idSubFamilia", _idSubFamilia);
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
                    cmd = new SqlCommand("BuscarSuBFamilia1");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conex.Cn;

                    if (cmd.ExecuteNonQuery() == -1)
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            cboControl.DataSource = dt;
                            cboControl.DisplayMember = "NombreSubFamilia";
                            cboControl.ValueMember = "idSubFamilia";
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
