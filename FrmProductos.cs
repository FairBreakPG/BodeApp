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
    public partial class FrmProductos : Form
    {
        SubFamilia oSubFamilia;
        Producto oProducto;

        public FrmProductos()
        {
            InitializeComponent();
           // this.ttMensaje.SetToolTip(this.txtCodigoSubFamilia, "Ingrese el ID  de la SubFamilia");
        }

        
        private void FrmProductos_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Limpiar();
            Botones();
        }


        private bool IsNuevo = false;
        private bool IsEditar = false;

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Gestion de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mostrar mensaje de error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Gestion de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //metodo limpiar para limpiar todos los controles del formulario
        private void Limpiar()
        {
            this.txtIDPRODUCTO.Text = string.Empty;
            this.txtProducto.Text = string.Empty;
            this.txtIdSubFamilia.Text = string.Empty;
            this.cboSubfamilia.Text = string.Empty;
            this.cboSubfamilia.SelectedItem = null;
        }

        // metodo par habilitar los controles del formulario
        private void Habilitar(bool valor)
        {            
            this.txtIDPRODUCTO.ReadOnly = !valor;
            this.txtProducto.ReadOnly = !valor;
            this.txtIdSubFamilia.ReadOnly = !valor;
        }

        private void Botones()
        {

            if (this.IsNuevo || this.IsEditar)
            {
                this.Habilitar(true);
                this.tsbNuevo.Enabled = false;
                this.btnInsertar.Enabled = false;
                this.btnBuscar.Enabled = true;
                this.btnActualizar.Enabled = true;
                this.tsbSalir.Enabled = true;
                this.btnEliminar.Enabled = true;
                this.tsbLimpiar.Enabled = false;
                this.cboSubfamilia.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.tsbNuevo.Enabled = true;
                this.btnInsertar.Enabled = false;
                this.btnBuscar.Enabled = false;
                this.btnActualizar.Enabled = false;
                this.tsbSalir.Enabled = true;
                this.btnEliminar.Enabled = false;
                this.tsbLimpiar.Enabled = true;
                this.cboSubfamilia.Enabled = false;
            }

        }

        private void TsbGuadar_Click(object sender, EventArgs e)
        {
            FrmBodega frmBodega = new FrmBodega();
            frmBodega.Show();
            this.Hide();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            oSubFamilia = new SubFamilia();
            oSubFamilia.CBOMostrar(ref cboSubfamilia);

            oProducto = new Producto();
            if (oProducto.Buscar_por_Codigo(Convert.ToInt16(txtIDPRODUCTO.Text), ref oSubFamilia))
            {
                txtProducto.Text = oProducto.NombreProducto.ToString();
                cboSubfamilia.SelectedValue = oSubFamilia.IdSubFamilia;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            oProducto = new Producto();
            oProducto.Eliminar(Convert.ToInt32(txtIDPRODUCTO.Text));
            Limpiar();
            this.cboSubfamilia.SelectedItem = null;
        }

        private void TsbLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void TsbNuevo_Click(object sender, EventArgs e)
        {
            this.btnInsertar.Enabled = true;
            this.btnBuscar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.btnActualizar.Enabled = false;
            this.txtProducto.ReadOnly = false;
            this.txtIdSubFamilia.ReadOnly = false;
            this.txtIDPRODUCTO.ReadOnly = true;
            Limpiar();
        }

        private void TsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TsbFamilia_Click(object sender, EventArgs e)
        {
            FrmFamilia frmfamilia = new FrmFamilia();
            frmfamilia.Show();
            this.Hide();
        }

        private void TsbSubFamilia_Click(object sender, EventArgs e)
        {
            FrmSubFamilia frmSubFamilia = new FrmSubFamilia();
            frmSubFamilia.Show();
            this.Hide();
        }

        private void TsbProveedor_Click(object sender, EventArgs e)
        {
            FrmProveedor frmProveedor = new FrmProveedor();
            frmProveedor.Show();
            this.Hide();
        }

        private void TsbComprador_Click(object sender, EventArgs e)
        {
            FrmComprador frmComprador = new FrmComprador();
            frmComprador.Show();
            this.Hide();
        }

        private void TsbTipoPago_Click(object sender, EventArgs e)
        {
            FrmMedio_de_Pago frmMedio_de_Pago = new FrmMedio_de_Pago();
            frmMedio_de_Pago.Show();
            this.Hide();
        }

        private void TsbTipoMovimiento_Click(object sender, EventArgs e)
        {
            FrmTipo_de_Movimiento frmTipo_De_Movimiento = new FrmTipo_de_Movimiento();
            frmTipo_De_Movimiento.Show();
            this.Hide();
        }

        private void BtnInsertar_Click_1(object sender, EventArgs e)
        {
            oSubFamilia = new SubFamilia(Convert.ToInt32(txtIdSubFamilia.Text));
            oProducto = new Producto(txtProducto.Text, oSubFamilia);
            oSubFamilia.IdSubFamilia = (Convert.ToInt32(txtIdSubFamilia.Text));
            oProducto.Insertar();
            Limpiar();
            this.btnActualizar.Enabled = true;
            this.btnEliminar.Enabled = true;
            this.btnBuscar.Enabled = true;
            this.tsbLimpiar.Enabled = true;
            this.txtIDPRODUCTO.ReadOnly = false;
            this.txtIdSubFamilia.ReadOnly = true;
            this.btnInsertar.Enabled = false;
        }

        private void BtnActualizar_Click_1(object sender, EventArgs e)
        {
            oProducto = new Producto(Convert.ToInt16(txtIDPRODUCTO.Text), txtProducto.Text);
            oProducto.Actualizar();
            Limpiar();
            this.btnActualizar.Enabled = false;
            this.btnInsertar.Enabled = true;
        }
    }
}
