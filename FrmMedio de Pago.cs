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
    public partial class FrmMedio_de_Pago : Form
    {
        private bool IsNuevo = false;

        private bool IsEditar = false;
        public FrmMedio_de_Pago()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtCodigoMedioPago, "Ingrese el id Medio de Pago");
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
            this.txtCodigoMedioPago.Text = string.Empty;
            this.txtNombreMedioPago.Text = string.Empty;
            this.txtCodigo.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
        }

        // metodo par habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtNombreMedioPago.ReadOnly = !valor;
            this.txtCodigoMedioPago.ReadOnly = !valor;
            this.txtCodigo.ReadOnly = !valor;
            this.txtNombre.ReadOnly = !valor;
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
                this.tsbLimpiar.Enabled = true;
            }
        }

        Medio_de_Pago oMedio_de_Pago;

        private void FrmMedio_de_Pago_Load(object sender, EventArgs e)
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

        private void TsbGuadar_Click(object sender, EventArgs e)
        {
            
        }

        private void TsbNuevo_Click(object sender, EventArgs e)
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

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            oMedio_de_Pago = new Medio_de_Pago();

            if (oMedio_de_Pago.Buscar_por_Codigo(Convert.ToInt16(txtCodigoMedioPago.Text)))
            {
                txtNombreMedioPago.Text = oMedio_de_Pago.NombreMedioPago.ToString();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            oMedio_de_Pago = new Medio_de_Pago(Convert.ToInt32(txtCodigoMedioPago.Text));
            oMedio_de_Pago.Eliminar();
            Limpiar();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            oMedio_de_Pago = new Medio_de_Pago(Convert.ToInt32(txtCodigo.Text), txtNombre.Text);
            oMedio_de_Pago.Actualizar();
            Limpiar();

            this.btnActualizar.Enabled = false;
            this.txtCodigo.ReadOnly = true;
            this.txtNombre.ReadOnly = false;
            this.btnInsertar.Enabled = true;
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            oMedio_de_Pago = new Medio_de_Pago(txtNombre.Text.ToString());
            oMedio_de_Pago.Insertar();
            Limpiar();
            this.btnActualizar.Enabled = true;
            this.btnEliminar.Enabled = true;
            this.btnBuscar.Enabled = true;
            this.tsbLimpiar.Enabled = true;
            this.txtCodigo.ReadOnly = false;
            this.txtNombre.ReadOnly = false;
            this.txtCodigoMedioPago.ReadOnly = false;
            this.btnInsertar.Enabled = false;
        }

        private void TsbNuevo_Click_1(object sender, EventArgs e)
        {
            this.btnInsertar.Enabled = true;
            this.btnBuscar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.btnActualizar.Enabled = false;
            this.txtNombre.ReadOnly = false;
            this.txtCodigo.ReadOnly = true;
            //this.txtCodigoMedioPago.ReadOnly = false;
            Limpiar();
        }

        private void TsbLimpiar_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void TsbSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
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

        private void TsbTipoMovimiento_Click(object sender, EventArgs e)
        {
            FrmTipo_de_Movimiento frmTipo_De_Movimiento = new FrmTipo_de_Movimiento();
            frmTipo_De_Movimiento.Show();
            this.Hide();
        }
    }
}
