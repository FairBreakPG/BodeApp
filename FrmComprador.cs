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
    public partial class FrmComprador : Form
    {
        private bool IsNuevo = false;

        private bool IsEditar = false;

        Comprador oComprador;
        public FrmComprador()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtRutComprador, "Ingrese el Rut del Comprador");
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
            this.txtRutComprador.Text = string.Empty;
            this.txtDvComprador.Text = string.Empty;
            this.txtNombreComprador.Text = string.Empty;
            this.txtApellidoComprador.Text = string.Empty;
            this.txtEstadoComprador.Text = string.Empty;
            this.txtRut.Text = string.Empty;
            this.txtDV.Text = string.Empty;
            this.txtComprador.Text = string.Empty;
            this.txtApellido.Text = string.Empty;
            this.txtEstado.Text = string.Empty;
        }

        // metodo par habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtRutComprador.ReadOnly = !valor;
            this.txtDvComprador.ReadOnly = !valor;
            this.txtNombreComprador.ReadOnly = !valor;
            this.txtApellidoComprador.ReadOnly = !valor;
            this.txtEstadoComprador.ReadOnly = !valor;
            this.txtRut.ReadOnly = !valor;
            this.txtDV.ReadOnly = !valor;
            this.txtComprador.ReadOnly = !valor;
            this.txtApellido.ReadOnly = !valor;
            this.txtEstado.ReadOnly = !valor;
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
                this.tsbLimpiar.Enabled = true;
            }

        }       
        private void ToolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void FrmComprador_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Limpiar();
            Botones();
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

        private void BtnInsertar_Click(object sender, EventArgs e)
        {           
            oComprador = new Comprador(Convert.ToInt32(txtRut.Text), txtDV.Text.ToString(), txtComprador.Text.ToString(), txtApellido.Text.ToString(), (Convert.ToInt32(txtEstado.Text)));
            oComprador.Insertar();           
            this.btnEliminar.Enabled = true;
            this.tsbLimpiar.Enabled = true;
            this.btnActualizar.Enabled = true;
            this.btnBuscar.Enabled = true;
            this.btnInsertar.Enabled = false;
            this.txtRutComprador.ReadOnly = false;


            Limpiar();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            oComprador = new Comprador(Convert.ToInt32(txtRut.Text), txtDV.Text.ToString(), txtComprador.Text.ToString(), txtApellido.Text.ToString(), (Convert.ToInt32(txtEstado.Text)));
            oComprador.Actualizar();
            Limpiar();
            this.btnActualizar.Enabled = false;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            oComprador = new Comprador();

            if (oComprador.Buscar_por_Rut(Convert.ToInt32(txtRutComprador.Text)))
            {
                txtDvComprador.Text = oComprador.DV.ToString();
                txtNombreComprador.Text = oComprador.NombreComprador.ToString();
                txtApellidoComprador.Text = oComprador.ApellidoComprador.ToString();
                txtEstadoComprador.Text = oComprador.EstadoComprador.ToString();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            oComprador = new Comprador(Convert.ToInt32(txtRutComprador.Text));
            oComprador.Eliminar();
            Limpiar();
        }

        private void TsbLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void TsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TsbNuevo_Click(object sender, EventArgs e)
        {
            this.btnInsertar.Enabled = true;
            this.btnActualizar.Enabled = false;
            this.txtRut.ReadOnly = false;
            this.txtDV.ReadOnly = false;
            this.txtComprador.ReadOnly = false;
            this.txtApellido.ReadOnly = false;
            this.txtEstado.ReadOnly = false;            
            Limpiar();
        }

        private void TsbFamilia_Click(object sender, EventArgs e)
        {
            FrmFamilia frmFamilia = new FrmFamilia();
            frmFamilia.Show();
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

        private void TsbFrmBodega_Click(object sender, EventArgs e)
        {
            FrmBodega frmBodega = new FrmBodega();
            frmBodega.Show();
            this.Hide();
        }

        private void TsbProducto_Click(object sender, EventArgs e)
        {
            FrmProductos frmProducto = new FrmProductos();
            frmProducto.Show();
            this.Hide();
        }
    }
}
