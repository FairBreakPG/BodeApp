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
    public partial class FrmProveedor : Form
    {
        private bool IsNuevo = false;

        private bool IsEditar = false;

        public FrmProveedor()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtRut, "Ingrese el Rut del Proveedor");
        }

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

            this.txtDireccionProveedor.Text = string.Empty;
            this.txtDVProveedor.Text = string.Empty;
            this.txtRazonSocialProveedor.Text = string.Empty;
            this.txtRutProveedor.Text = string.Empty;
            this.txtRut.Text = string.Empty;
            this.txtDV.Text = string.Empty;
            this.txtRazonSocial.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            
        }

        // metodo par habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtRazonSocial.ReadOnly = !valor;
            this.txtDV.ReadOnly = !valor;
            this.txtDireccion.ReadOnly = !valor;
            this.txtDireccionProveedor.ReadOnly = !valor;
            this.txtDVProveedor.ReadOnly = !valor;
            this.txtRazonSocialProveedor.ReadOnly = !valor;
            this.txtRutProveedor.ReadOnly = !valor;
            this.txtRut.ReadOnly = !valor;

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
                this.tsbLimpiar.Enabled = true;
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
                this.tsbLimpiar.Enabled = false;
            }
        }

        Proveedor oProveedor;

        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Botones();
            Limpiar();
        }

        private void TsbBuscar_Click(object sender, EventArgs e)
        {
           
        }

        private void TsbModificar_Click(object sender, EventArgs e)
        {
            
        }

        private void TsbEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void TsbNuevo_Click(object sender, EventArgs e)
        {
            this.btnInsertar.Enabled = true;
            this.txtDireccionProveedor.ReadOnly = false;
            this.txtDVProveedor.ReadOnly = false;
            this.txtRazonSocialProveedor.ReadOnly = false;
            this.txtRutProveedor.ReadOnly = false;
        }

        private void TsbGuadar_Click(object sender, EventArgs e)
        {
            
        }

        private void TsbLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void TsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            oProveedor = new Proveedor(Convert.ToInt32(txtRutProveedor.Text), txtDVProveedor.Text.ToString(), txtRazonSocialProveedor.Text.ToString(), txtDireccionProveedor.Text.ToString());
            oProveedor.Insertar();
            this.btnActualizar.Enabled = true;
            this.btnEliminar.Enabled = true;
            this.btnBuscar.Enabled = true;
            this.tsbLimpiar.Enabled = true;
            this.btnInsertar.Enabled = false;
            Limpiar();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            oProveedor = new Proveedor();

            if (oProveedor.Buscar_por_Rut(Convert.ToInt32(txtRut.Text)))
            {
                txtDV.Text = oProveedor.DV.ToString();
                txtRazonSocial.Text = oProveedor.RazonSocial.ToString();
                txtDireccion.Text = oProveedor.Direccion.ToString();
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            oProveedor = new Proveedor(Convert.ToInt32(txtRutProveedor.Text), txtDVProveedor.Text, txtRazonSocialProveedor.Text, txtDireccionProveedor.Text);
            oProveedor.Actualizar();
            Limpiar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            oProveedor = new Proveedor(Convert.ToInt32(txtRutProveedor.Text));
            oProveedor.Eliminar();
            Limpiar();
        }

        private void TsbSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TsbLimpiar_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void TsbFrmBodega_Click(object sender, EventArgs e)
        {
            FrmBodega frmBodega = new FrmBodega();
            frmBodega.Show();
            this.Hide();
        }

        private void TsbBuscar_Click_1(object sender, EventArgs e)
        {
            FrmProductos frmProducto = new FrmProductos();
            frmProducto.Show();
            this.Hide();
        }

        private void TsbSubFamilia_Click(object sender, EventArgs e)
        {
            FrmSubFamilia frmSubFamilia = new FrmSubFamilia();
            frmSubFamilia.Show();
            this.Hide();
        }

        private void TsbComprador_Click(object sender, EventArgs e)
        {
            FrmComprador frmComprador = new FrmComprador();
            frmComprador.Show();
            this.Hide();
        }

        private void TsbTipoMovimiento_Click(object sender, EventArgs e)
        {
            FrmTipo_de_Movimiento frmTipo_De_Movimiento = new FrmTipo_de_Movimiento();
            frmTipo_De_Movimiento.Show();
            this.Hide();
        }

        private void TsbTipoPago_Click(object sender, EventArgs e)
        {
            FrmMedio_de_Pago frmMedio_de_Pago = new FrmMedio_de_Pago();
            frmMedio_de_Pago.Show();
            this.Hide();
        }

        private void TsbFamilia_Click(object sender, EventArgs e)
        {
            FrmFamilia frmFamilia = new FrmFamilia();
            frmFamilia.Show();
            this.Hide();
        }

        private void TsbNuevo_Click_1(object sender, EventArgs e)
        {
            this.btnInsertar.Enabled = true;
            this.btnActualizar.Enabled = false;
            this.btnBuscar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.txtRutProveedor.ReadOnly = false;
            this.txtDVProveedor.ReadOnly = false;
            this.txtRazonSocialProveedor.ReadOnly = false;
            this.txtDireccionProveedor.ReadOnly = false;
            Limpiar();
        }
    }
}
