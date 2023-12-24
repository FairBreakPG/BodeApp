using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_Sistema
{
    public partial class FrmRecepcionBodega : Form
    {
       
        private TipoMovimiento oTipoMovimiento;
        private EncOrdenCompra oEncOrdenCompra;
        private Bodega oBodega;
        private Producto oProducto;
        private EncMovimiento oEncMovimiento;
        
        SubFamilia osubFamilia;

        public FrmRecepcionBodega()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            this.txtFolioMov.Text = string.Empty;
            this.txtTipoMovimiento.Text = string.Empty;
            this.txtNroOc.Text = string.Empty;
            this.txtNrofactura.Text = string.Empty;
            this.cboBodega.SelectedItem = null;
        }

        private void FrmRecepcionBodega_Load(object sender, EventArgs e)
        {
            oBodega = new Bodega();
            oBodega.CBOMostrar(ref cboBodega);

            dgvDetalle.AutoGenerateColumns = false;
            Limpiar();
        }

        private void DgvDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
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

       

        private void TxtNroOc_Validating(object sender, CancelEventArgs e)
        {
            if (txtNroOc.Text.Length == 0)
                return;


            oEncOrdenCompra = new EncOrdenCompra(Convert.ToInt32(txtNroOc.Text));

            if (oEncOrdenCompra.BuscarEncOrdCompra(Convert.ToInt32(txtNroOc.Text)) == true)
                oEncMovimiento = new EncMovimiento();
        }

        private void TxtFolioMov_Validating(object sender, CancelEventArgs e)
        {
            if (txtFolioMov.Text.Length == 0)
                return;

            oTipoMovimiento = new TipoMovimiento();
            oEncOrdenCompra = new EncOrdenCompra();
            oBodega = new Bodega();
            oEncMovimiento = new EncMovimiento(Convert.ToInt32(txtFolioMov.Text));
            if (oEncMovimiento.Buscar(oTipoMovimiento, oEncOrdenCompra, oBodega, ref dgvDetalle) == true)
            {
                txtTipoMovimiento.Text =oEncMovimiento.TipoMovimiento.IdMovimiento.ToString();
                txtNroOc.Text = oEncMovimiento.EncOrdenCompra.FolioOc.ToString();
                cboBodega.Text = oEncMovimiento.Bodega.NombreBodega.ToString();
                txtNrofactura.Text = oEncMovimiento.NroFactura.ToString();
                dtFechaFactura.Value = oEncMovimiento.FechaFactura;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            oTipoMovimiento = new TipoMovimiento(2);
            oEncOrdenCompra = new EncOrdenCompra(Convert.ToInt32(txtNroOc.Text));
            oBodega = new Bodega(Convert.ToInt32(cboBodega.SelectedValue));

            oEncMovimiento = new EncMovimiento(oTipoMovimiento, oEncOrdenCompra, oBodega ,Convert.ToInt32(txtNrofactura.Text),dtFechaFactura.Value);
           
            foreach (DataGridViewRow fila in dgvDetalle.Rows)
            {               

                if (fila.IsNewRow)
                    continue;
                oEncMovimiento.AgregarLineaDetMov(oTipoMovimiento = new TipoMovimiento(2),new Producto(Convert.ToInt32(fila.Cells["CodigoProducto"].Value)), Convert.ToInt32(fila.Cells["CantidadProducto"].Value), Convert.ToInt32(fila.Cells["PrecioProducto"].Value));
                
                
            }         

            if (oEncMovimiento.GrabarRecepcionBodega() == true)
                txtFolioMov.Text = Convert.ToString(oEncMovimiento.FolioMov);

            Limpiar();
            dgvDetalle.DataSource = null;
        }

        private void TxtTipoMovimiento_Validating(object sender, CancelEventArgs e)
        {

            if (txtTipoMovimiento.Text.Length == 0)
                return;
            

            oTipoMovimiento = new TipoMovimiento(Convert.ToInt32(txtTipoMovimiento.Text));

            if (oTipoMovimiento.Buscar_por_Codigo(Convert.ToInt32(txtTipoMovimiento.Text)) == true)
               oTipoMovimiento = new TipoMovimiento();
        }

        private void CboBodega_Validating(object sender, CancelEventArgs e)
        {
            if (cboBodega.Text.Length == 0)
                return;


            oBodega = new Bodega(Convert.ToInt32(cboBodega.SelectedValue));

            if (oBodega.Buscar_por_Codigo(Convert.ToInt32(cboBodega.SelectedValue)) == true)
                oBodega = new Bodega();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            dgvDetalle.DataSource = null;
        }
    }
}
