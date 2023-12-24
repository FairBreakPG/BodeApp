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
    public partial class FrmFamilia : Form
    {
        Familia oFamilia;

        private bool IsNuevo = false;

        private bool IsEditar = false;

        public FrmFamilia()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtCodigoFamilia, "Ingrese el id de la Bodega");
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
            this.txtCodigoFamilia.Text = string.Empty;
            this.txtNombreFamila.Text = string.Empty;
            this.txtFamilia.Text = string.Empty;
            this.txtIdfamilia.Text = string.Empty;
        }

        // metodo par habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
           // this.txtCodigoFamilia.ReadOnly = !valor;
            this.txtNombreFamila.ReadOnly = !valor;
            this.txtIdfamilia.ReadOnly = !valor;
            this.txtCodigoFamilia.ReadOnly = !valor;
            this.txtFamilia.ReadOnly = !valor;
        }

        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar)
            {
                this.Habilitar(true);
                this.tsbNuevo.Enabled = false;
                this.btnInsertar.Enabled = true;
                this.btnBuscar.Enabled = false;
                this.btnActualizar.Enabled = true;
                this.tsbSalir.Enabled = true;
                this.btnEliminar.Enabled = true;

            }
            else
            {
                this.Habilitar(false);
                this.tsbNuevo.Enabled = true;
                this.btnInsertar.Enabled = true;
                this.btnBuscar.Enabled = true;
                this.btnActualizar.Enabled = false;
                this.tsbSalir.Enabled = true;
                this.btnEliminar.Enabled = false;
            }
        }

        private void FrmFamilia_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            //this.Habilitar(false);
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
            
        }

        private void TsbSalir_Click(object sender, EventArgs e)
        {
           
        }

        private void TsbGuadar_Click(object sender, EventArgs e)
        {
           
        }

        private void TsbLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            oFamilia = new Familia();

            if (oFamilia.BuscarCodigo(Convert.ToInt16(txtCodigoFamilia.Text)))
            {
                txtNombreFamila.Text = oFamilia.NombreFamilia.ToString();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            oFamilia = new Familia(Convert.ToInt16(txtCodigoFamilia.Text));
            oFamilia.Eliminar();
            Limpiar();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            // nombres caja de textos formulario Mantencion familia
            oFamilia = new Familia(Convert.ToInt16(txtIdfamilia.Text), txtFamilia.Text);
            oFamilia.Actualizar();
            Limpiar();
            this.txtIdfamilia.ReadOnly = true;
            this.btnInsertar.Enabled = true;
            this.btnActualizar.Enabled = false;
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            oFamilia = new Familia(txtFamilia.Text.ToString());
            oFamilia.Insertar();
            Limpiar();
            this.btnActualizar.Enabled = true;
            this.btnEliminar.Enabled = true;
            this.btnBuscar.Enabled = true;
            this.tsbLimpiar.Enabled = true;
            this.txtIdfamilia.ReadOnly = false;
            this.txtFamilia.ReadOnly = false;
            this.txtCodigoFamilia.ReadOnly = false;
            this.btnInsertar.Enabled = false;
        }

        private void TsbLimpiar_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void TsbSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TsbNuevo_Click_1(object sender, EventArgs e)
        {
            this.btnInsertar.Enabled = true;
            this.btnActualizar.Enabled = false;
            this.txtFamilia.ReadOnly = false;           
            this.txtCodigoFamilia.ReadOnly = true;
            Limpiar();
        }

        private void TsbFrmBodega_Click(object sender, EventArgs e)
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

        private void TsbBuscar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
