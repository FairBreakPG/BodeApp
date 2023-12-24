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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductos fmp = new FrmProductos();
            fmp.Show();
        }

        private void OrdenCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrdenCompra frm = new FrmOrdenCompra();
            frm.Show();
        }

        private void RecepcionBodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRecepcionBodega frm = new FrmRecepcionBodega();
            frm.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void TipoMovimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipo_de_Movimiento frmTipo_De_Movimiento = new FrmTipo_de_Movimiento();
            frmTipo_De_Movimiento.Show();
        }

        private void GenerarSalidaDeBodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSalidaBodega frmSalidaBodega = new FrmSalidaBodega();
            frmSalidaBodega.Show();
        }
    }
}
