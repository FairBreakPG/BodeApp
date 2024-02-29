using System.Data.SqlClient;

namespace Gestor_de_Sistema
{
    class Bodega
    {

        private int id;
        private string nombre;
        SqlCommand cmd;
        Conexion conex = new Conexion();

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Bodega() { }

        public Bodega(string nombre)
        {
            this.nombre = nombre;
        }

        public Bodega(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public Bodega(int id)
        {
            this.id = id;
        }
    }
}
