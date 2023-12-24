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
    public partial class FrmSubFamilia : Form
    {
        private bool IsNuevo = false;

        private bool IsEditar = false;

        Familia oFamilia;
        SubFamilia oSubFamilia;

        public FrmSubFamilia()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtCodigoSubFamilia, "Ingrese el ID  de la SubFamilia");
            
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
            this.txtCodigoSubFamilia.Text = string.Empty;
            this.txtNombreSubFamilia.Text = string.Empty;
            this.txtSubFamilia.Text = string.Empty;
            this.txtIdFamilia.Text = string.Empty;
            this.txtSubFamilia.Text = string.Empty;
            this.cboFamilia.Text = string.Empty;
        }

        // metodo par habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtNombreSubFamilia.ReadOnly = !valor;
            this.txtSubFamilia.ReadOnly = !valor;
            this.txtIdFamilia.ReadOnly = !valor;
            this.txtIDSubFamilia.ReadOnly = !valor;
            this.txtCodigoSubFamilia.ReadOnly = !valor;
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
                this.cboFamilia.Enabled = true;
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
                this.cboFamilia.Enabled = false;
            }
        }

        private void FrmSubFamilia_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Limpiar();
            Botones();
        }

        private void TsbGuadar_Click(object sender, EventArgs e)
        {
            FrmBodega frmBodega = new FrmBodega();
            frmBodega.Show();
            this.Hide();
        }

        private void TsbModificar_Click(object sender, EventArgs e)
        {
           
        }

        private void TsbEliminar_Click(object sender, EventArgs e)
        {
           
        }

        private void TsbBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void TsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TsbNuevo_Click(object sender, EventArgs e)
        {
            this.btnInsertar.Enabled = true;
            this.txtSubFamilia.ReadOnly = false;
            this.txtIdFamilia.ReadOnly = false;
            Limpiar();
            
        }

        private void TxtSubFamilia_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            oFamilia = new Familia();
            oFamilia.CBOMostrar(ref cboFamilia);

            oSubFamilia = new SubFamilia();
            if (oSubFamilia.Buscar_por_Codigo(Convert.ToInt16(txtCodigoSubFamilia.Text), ref oFamilia))
            {
                txtNombreSubFamilia.Text = oSubFamilia.NombreSubFamilia.ToString();
                cboFamilia.SelectedValue = oFamilia.IdFamilia;
            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            oSubFamilia = new SubFamilia();
            oSubFamilia.Eliminar(Convert.ToInt32(txtCodigoSubFamilia.Text));
            Limpiar();
        }

        private void TsbLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            oFamilia = new Familia(txtIdFamilia.Text);
            oSubFamilia = new SubFamilia(txtSubFamilia.Text.ToString(), oFamilia);
            // Aqui hago la instancia del Objeto OFamilia para pasar le el parametro del IDfamilia, pero me da error
            oFamilia.IdFamilia = (Convert.ToInt32(txtIdFamilia.Text));
            oSubFamilia.Insertar();
            Limpiar();
            this.btnActualizar.Enabled = true;
            this.btnInsertar.Enabled = false;
            this.btnEliminar.Enabled = true;
            this.btnBuscar.Enabled = true;
            this.tsbLimpiar.Enabled = true;
            this.txtIDSubFamilia.ReadOnly = false;
            this.txtIdFamilia.ReadOnly = true;
            this.txtCodigoSubFamilia.ReadOnly = false;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            oSubFamilia = new SubFamilia(Convert.ToInt16(txtIDSubFamilia.Text), txtSubFamilia.Text);
            oSubFamilia.Actualizar();
            Limpiar();
            this.btnActualizar.Enabled = false;
            this.btnInsertar.Enabled = true;
            this.txtIDSubFamilia.ReadOnly = true;
        }

        private void TsbFrmBodega_Click(object sender, EventArgs e)
        {
            FrmProductos frmProducto = new FrmProductos();
            frmProducto.Show();
            this.Hide();
        }

        private void TsbBuscar_Click_1(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos();
            frmProductos.Show();
            this.Hide();
        }

        private void TsbFamilia_Click(object sender, EventArgs e)
        {
            FrmFamilia frmFamilia = new FrmFamilia();
            frmFamilia.Show();
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

        private void TsbLimpiar_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void TsbNuevo_Click_1(object sender, EventArgs e)
        {
            this.btnInsertar.Enabled = true;
            this.btnActualizar.Enabled = false;
            this.txtSubFamilia.ReadOnly = false;
            this.txtIdFamilia.ReadOnly = false;
            Limpiar();
        }

        private void TsbSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
