using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gestor_de_Sistema
{
    class Conexion
    {
        public SqlConnection Cn;

        public Conexion()
        {

        }
        public bool Conectar()
        {
            try
            {
                //public static string Cn = "Data Source = JAYPROG; Initial Catalog=Taller; Integrated Security=true";
                Cn = new SqlConnection("Data Source = JAYPROG; Initial Catalog=TallerProyecto; Integrated Security=true");
                Cn.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message.ToString());
                return false;
            }
        }
    }
}
