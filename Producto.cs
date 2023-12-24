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
   class Producto
   {
        int _idProducto;
        string _NombreProducto;
        SubFamilia subFamilia;

        Conexion conex = new Conexion();

        SqlCommand cmd;

        public int IdProducto
        {
            get
            {
                return _idProducto;
            }

            set
            {
                _idProducto = value;
            }
        }

        public string NombreProducto
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

        internal SubFamilia SubFamilia
        {
            get
            {
                return subFamilia;
            }

            set
            {
                subFamilia = value;
            }
        }

        public Producto()
        {

        }

        public Producto(int _idProducto)
        {
            this._idProducto = _idProducto;
        }

        public Producto(int _idProducto, string _NombreProducto)
        {
            this._idProducto = _idProducto;
            this._NombreProducto = _NombreProducto;
        }


        public Producto(string _NombreProducto, SubFamilia subFamilia)
        {
            this._NombreProducto = _NombreProducto;
            this.subFamilia = subFamilia;
        }

        public Producto(int _idProducto, string _NombreProducto, SubFamilia subFamilia)
        {
            this._idProducto = _idProducto;
            this._NombreProducto = _NombreProducto;
            this.subFamilia = subFamilia;
        }

        public bool Buscar_por_Codigo(int idPro, ref SubFamilia oSubFamilia)
        {
            try
            {
                if (conex.Conectar())
                {
                    _idProducto = idPro;
                    
                    cmd = new SqlCommand("BuscarProducto");
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idProducto", _idProducto);
                    
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
                            _NombreProducto = dr["NombreProducto"].ToString();
                            
                            subFamilia = new SubFamilia(Convert.ToInt16(dr["SubFamilia"]));
                            oSubFamilia = subFamilia;

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
                    cmd = new SqlCommand("InsertarProducto");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conex.Cn;

                    cmd.Parameters.AddWithValue("@NombreProducto", _NombreProducto);
                    cmd.Parameters.AddWithValue("@SubFamilia", subFamilia.IdSubFamilia);
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
                    cmd = new SqlCommand("ActualizarProducto");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conex.Cn;
                    cmd.Parameters.AddWithValue("@idProducto", _idProducto);
                    cmd.Parameters.AddWithValue("@NombreProducto", _NombreProducto);
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
        public bool Eliminar(int idProducto)
        {
            try
            {
                if (conex.Conectar())
                {
                    _idProducto = idProducto;
                    cmd = new SqlCommand("EliminarProducto");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conex.Cn;

                    cmd.Parameters.AddWithValue("@idProducto", _idProducto);
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
