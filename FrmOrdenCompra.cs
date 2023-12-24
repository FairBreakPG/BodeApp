using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Gestor_de_Sistema
{
    public partial class FrmOrdenCompra : Form
    {
        private Comprador oComprador;
        private Proveedor oProveedor;
        private Medio_de_Pago oMedio_de_Pago;
        private DetPago oDetPago;
        private Producto oProducto;
        private EncOrdenCompra oEncOrdenCompra;
        SubFamilia osubFamilia;

        SqlCommand cmd;
        Conexion conex = new Conexion();

        public FrmOrdenCompra()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            this.txtFolio.Text = string.Empty;
            this.txtObservacion.Text = string.Empty;
            this.txtRazonSocial.Text = string.Empty;
            this.txtRutComprador.Text = string.Empty;
            this.txtRutProveedor.Text = string.Empty;
            this.txtNombreComprador.Text = string.Empty;
            this.dgvDetallePago.Text = string.Empty;
            this.dgvDetalle.Text = string.Empty;
        }

        private void FrmOrdenCompra_Load(object sender, EventArgs e)
        {
            dgvDetalle.AutoGenerateColumns = false;
            dgvDetallePago.AutoGenerateColumns = false;
            Limpiar();
        }

        private void DgvDetalle_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            string headerText = dgvDetalle.Columns[(e.ColumnIndex)].HeaderText;

            if (headerText.Equals("ID Producto"))
            {
                oProducto = new Producto(Convert.ToInt32(dgvDetalle.Rows[(e.RowIndex)].Cells["CodigoProducto"].Value));

                dgvDetalle.Rows[e.RowIndex].Cells["NombreProducto"].Value = "";

                if (oProducto.Buscar_por_Codigo(oProducto.IdProducto, ref osubFamilia) == true)
                    dgvDetalle.Rows[e.RowIndex].Cells["NombreProducto"].Value = oProducto.NombreProducto;
            }
           
        }

        private void DgvDetallePago_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            string headerText = dgvDetallePago.Columns[(e.ColumnIndex)].HeaderText;

            if (headerText.Equals("ID Medio Pago"))
            {
                oMedio_de_Pago = new Medio_de_Pago(Convert.ToInt32(dgvDetallePago.Rows[(e.RowIndex)].Cells["CodigoMedioPago"].Value));

                dgvDetallePago.Rows[e.RowIndex].Cells["NombreMedioPago"].Value = "";

                if (oMedio_de_Pago.Buscar_por_Codigo(oMedio_de_Pago.IdMedioPago) == true)
                    dgvDetallePago.Rows[e.RowIndex].Cells["NombreMedioPago"].Value = oMedio_de_Pago.NombreMedioPago;
            }

            
        }


        private void TxtFolio_Validated(object sender, EventArgs e)
        {

            try
            {

                if (txtFolio.Text.Length == 0)
                    return;

                oComprador = new Comprador();
                oProveedor = new Proveedor();
                oEncOrdenCompra = new EncOrdenCompra(Convert.ToInt32(txtFolio.Text));
                if (oEncOrdenCompra.Buscar(oComprador, oProveedor, ref dgvDetalle, ref dgvDetallePago) == true)
                {
                    dtFchEmis.Value = oEncOrdenCompra.FechaEmision;
                    txtObservacion.Text = oEncOrdenCompra.Observaciones;
                    dtFchEntre.Value = oEncOrdenCompra.FechaEntrega;
                    txtRutComprador.Text = oEncOrdenCompra.Comprador.Rut.ToString();
                    txtNombreComprador.Text = oEncOrdenCompra.Comprador.NombreComprador;
                    txtRutProveedor.Text = oEncOrdenCompra.Proveedor.Rut.ToString();
                    txtRazonSocial.Text = oEncOrdenCompra.Proveedor.RazonSocial;
                   
                }
               
            }
            catch (Exception ex)
            {
               
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            oEncOrdenCompra = new EncOrdenCompra(dtFchEmis.Value, txtObservacion.Text, dtFchEntre.Value,oComprador, oProveedor);

            oComprador = new Comprador();
            oProveedor = new Proveedor();

            foreach (DataGridViewRow fila in dgvDetalle.Rows)
            {
                if (fila.IsNewRow)
                    continue;
                oEncOrdenCompra.AgregarLinea(new Producto(Convert.ToInt32(fila.Cells["CodigoProducto"].Value)), Convert.ToInt32(fila.Cells["CantidadProducto"].Value), Convert.ToInt32(fila.Cells["PrecioProducto"].Value));
            }

            foreach (DataGridViewRow fila in dgvDetallePago.Rows)
            {
                if (fila.IsNewRow)
                    continue;
                oEncOrdenCompra.AgregarLineaD(new Medio_de_Pago(Convert.ToInt32(fila.Cells["CodigoMedioPago"].Value)), Convert.ToDateTime(fila.Cells["FechaPago"].Value), Convert.ToInt32(fila.Cells["MontoPago"].Value));
            }           

            if (oEncOrdenCompra.GrabarOrdenCompra() == true)
                txtFolio.Text = Convert.ToString(oEncOrdenCompra.FolioOc);
            
        }

        private void TxtRutComprador_Validating_1(object sender, CancelEventArgs e)
        {
           
            if (txtRutComprador.Text.Length == 0)
                return;

            txtNombreComprador.Text = "";
            oComprador = new Comprador(Convert.ToInt32(txtRutComprador.Text));

            if (oComprador.Buscar_por_Rut(Convert.ToInt32(txtRutComprador.Text)) == true)
                txtNombreComprador.Text = oComprador.NombreComprador;
        }

        private void TxtRutProveedor_Validating_1(object sender, CancelEventArgs e)
        {
            
            if (txtRutProveedor.Text.Length == 0)
                return;

            txtRazonSocial.Text = "";
            oProveedor = new Proveedor(Convert.ToInt32(txtRutProveedor.Text));

            if (oProveedor.Buscar_por_Rut(Convert.ToInt32(txtRutProveedor.Text)) == true)
                txtRazonSocial.Text = oProveedor.RazonSocial;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            oEncOrdenCompra = new EncOrdenCompra();
            oEncOrdenCompra.Eliminar(Convert.ToInt32(txtFolio.Text));
            Limpiar();
        }

        private void TxtFolio_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            dgvDetalle.DataSource = null;
            dgvDetallePago.DataSource = null;
        }
    }
}
