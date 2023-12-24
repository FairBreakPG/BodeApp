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
    public partial class FrmBodega : Form
    {
        Bodega oBodega;

        private bool IsNuevo = false;

        private bool IsEditar = false;

        public FrmBodega()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtCodigoBogeda, "Ingrese el id de la Bodega");
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
            this.txtCodigoBogeda.Text = string.Empty;
            this.txtNombreBodega.Text = string.Empty;
            this.txtBodega.Text = string.Empty;
            this.txtIdBodega.Text = string.Empty;
        }

        // metodo par habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtCodigoBogeda.ReadOnly = !valor;
            this.txtIdBodega.ReadOnly = !valor;
            this.txtNombreBodega.ReadOnly = !valor;
            this.txtBodega.ReadOnly = !valor;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Botones();
            Limpiar();
        }

        // metodo para habilitar botones
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
        private void TsbGuadar_Click(object sender, EventArgs e)
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
            this.txtBodega.ReadOnly = false;                    
        }

        private void TsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TsbBuscar_Click(object sender, EventArgs e)
        {
        }

        private void TsbLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            oBodega = new Bodega(txtBodega.Text.ToString());
            oBodega.Insertar();
            this.btnEliminar.Enabled = true;
            this.btnInsertar.Enabled = false;
            this.btnBuscar.Enabled = true;
            this.btnActualizar.Enabled = true;
            this.btnEliminar.Enabled = true;
            this.txtIdBodega.ReadOnly = false;
            this.txtBodega.ReadOnly = false;
            this.txtCodigoBogeda.ReadOnly = false;
            this.tsbLimpiar.Enabled = true;
            Limpiar();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            oBodega = new Bodega(Convert.ToInt16(txtIdBodega.Text), txtBodega.Text);
            oBodega.Actualizar();
            Limpiar();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

            oBodega = new Bodega();

            if (oBodega.Buscar_por_Codigo(Convert.ToInt16(txtCodigoBogeda.Text)))
            {
                txtNombreBodega.Text = oBodega.NombreBodega.ToString();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            oBodega = new Bodega(Convert.ToInt16(txtCodigoBogeda.Text));
            oBodega.Eliminar();
            Limpiar();
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
            this.txtBodega.ReadOnly = false;
            Limpiar();
        }

        private void TsbSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
