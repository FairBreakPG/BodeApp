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
    public partial class FrmTipo_de_Movimiento : Form
    {
        private bool IsNuevo = false;

        private bool IsEditar = false;

        public FrmTipo_de_Movimiento()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtCodigo, "Ingrese el Codigo de Tipo Movimiento");
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
            this.txtOperacion.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtCodigo.Text = string.Empty;
           
        }

        // metodo par habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtCodigo.ReadOnly = !valor;
            this.txtNombre.ReadOnly = !valor;
            this.txtOperacion.ReadOnly = !valor;
          
        }

        TipoMovimiento oTipoMovimiento;

        // metodo para habilitar botones
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar)
            {
                this.Habilitar(true);
                this.tsbNuevo.Enabled = false;
                this.btnBuscar.Enabled = false;
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

        private void FrmTipo_de_Movimiento_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Botones();
            Limpiar();
        }

      
        private void TsbFrmBodega_Click(object sender, EventArgs e)
        {
            FrmBodega frmBodega = new FrmBodega();
            frmBodega.Show();
            this.Hide();
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

        private void TsbLimpiar_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void TsbNuevo_Click_1(object sender, EventArgs e)
        {
            this.btnInsertar.Enabled = true;
            this.btnActualizar.Enabled = false;
            this.btnBuscar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.txtNombre.ReadOnly = false;
            this.txtOperacion.ReadOnly = false;
            this.txtCodigo.ReadOnly = true;

            Limpiar();
        }

        private void TsbSalir_Click_1(object sender, EventArgs e)
        {           
            this.Close();
        }

        private void TsbBuscar_Click_1(object sender, EventArgs e)
        {
            FrmProductos frmProducto = new FrmProductos();
            frmProducto.Show();
            this.Hide();
        }

        private void BtnInsertar_Click_2(object sender, EventArgs e)
        {
            oTipoMovimiento = new TipoMovimiento(txtNombre.Text.ToString(), (Convert.ToInt32(txtOperacion.Text)));
            oTipoMovimiento.Insertar();
            this.btnActualizar.Enabled = true;
            this.btnEliminar.Enabled = true;
            this.btnBuscar.Enabled = true;
            this.tsbLimpiar.Enabled = true;
            this.btnInsertar.Enabled = false;

            this.txtCodigo.ReadOnly = false;
            Limpiar();
        }

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            oTipoMovimiento = new TipoMovimiento();

            if (oTipoMovimiento.Buscar_por_Codigo(Convert.ToInt32(txtCodigo.Text)))
            {
                txtNombre.Text = oTipoMovimiento.NombreMovimiento.ToString();
                txtOperacion.Text = oTipoMovimiento.OperacionMovimiento.ToString();
            }
        }

        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            oTipoMovimiento = new TipoMovimiento(Convert.ToInt32(txtCodigo.Text));
            oTipoMovimiento.Eliminar();
            Limpiar();
        }

        private void BtnActualizar_Click_1(object sender, EventArgs e)
        {
            oTipoMovimiento = new TipoMovimiento(Convert.ToInt32(txtCodigo.Text), (Convert.ToInt32(txtOperacion.Text)), txtNombre.Text);
            oTipoMovimiento.Actualizar();
            this.btnActualizar.Enabled = false;
            this.btnInsertar.Enabled = true;
            Limpiar();
        }
    }
}
