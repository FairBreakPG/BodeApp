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
    public partial class FrmSalidaBodega : Form
    {
        EncMovimiento oEncMovimiento;
        Bodega oBodega;
        TipoMovimiento oTipoMovimiento;

        private Producto oProducto;
        SubFamilia osubFamilia;

        public FrmSalidaBodega()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            this.cboBodega.SelectedItem = null;
            this.txtFolio.Text = string.Empty;
        }

        private void FrmSalidaBodega_Load(object sender, EventArgs e)
        {
            oBodega = new Bodega();
            oBodega.CBOMostrar(ref cboBodega);

            GRIDVIEWsalidaB.AutoGenerateColumns = false;
            Limpiar();
        }     

        private void TxtFolio_Validating(object sender, CancelEventArgs e)
        {
            if (txtFolio.Text.Length == 0)
                return;
            oEncMovimiento = new EncMovimiento(Convert.ToInt32(txtFolio.Text));
            oBodega = new Bodega();

            if (oEncMovimiento.BuscarIdBodega(oBodega, ref GRIDVIEWsalidaB) == true)
            {
                cboBodega.Text = oEncMovimiento.Bodega.NombreBodega.ToString();                      
            }
        }

        private void GRIDVIEWsalidaB_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
            string headerText = GRIDVIEWsalidaB.Columns[(e.ColumnIndex)].HeaderText;

            if (headerText.Equals("ID Producto"))
            {
                oProducto = new Producto(Convert.ToInt32(GRIDVIEWsalidaB.Rows[(e.RowIndex)].Cells["CodigoProducto"].Value));

                GRIDVIEWsalidaB.Rows[e.RowIndex].Cells["NombreProducto"].Value = "";

                if (oProducto.Buscar_por_Codigo(oProducto.IdProducto, ref osubFamilia) == true)
                    GRIDVIEWsalidaB.Rows[e.RowIndex].Cells["NombreProducto"].Value = oProducto.NombreProducto;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {                      
            oBodega = new Bodega(Convert.ToInt32(cboBodega.SelectedValue));
            oEncMovimiento = new EncMovimiento(oBodega);
           

            foreach (DataGridViewRow fila in GRIDVIEWsalidaB.Rows)
            {
                if (fila.IsNewRow)
                    continue;
                oEncMovimiento.AgregarLineaDetMovi(oTipoMovimiento = new TipoMovimiento(2), new Producto(Convert.ToInt32(fila.Cells["CodigoProducto"].Value)), Convert.ToInt32(fila.Cells["CantidadProducto"].Value), Convert.ToInt32(fila.Cells["PrecioProducto"].Value));
            }

            if (oEncMovimiento.GrabarSalidaBodega() == true)
                txtFolio.Text = Convert.ToString(oEncMovimiento.FolioMov);

            Limpiar();
            GRIDVIEWsalidaB.DataSource = null;
        }

        private void CboBodega_Validating(object sender, CancelEventArgs e)
        {
            if (cboBodega.Text.Length == 0)
                return;


            oBodega = new Bodega(Convert.ToInt32(cboBodega.SelectedValue));

            if (oBodega.Buscar_por_Codigo(Convert.ToInt32(cboBodega.SelectedValue)) == true)
                oBodega = new Bodega();
        }

        private void TsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            GRIDVIEWsalidaB.DataSource = null;
        }
    }
   
}
