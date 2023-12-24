namespace Gestor_de_Sistema
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fromulariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subFamiliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.famiiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bodegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoMovimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarOrdenDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recepcionBodegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarRecepciònDeBodegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bodegaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.generarSalidaDeBodegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromulariosToolStripMenuItem,
            this.ordenCompraToolStripMenuItem,
            this.recepcionBodegaToolStripMenuItem,
            this.bodegaToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fromulariosToolStripMenuItem
            // 
            this.fromulariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmProductosToolStripMenuItem,
            this.subFamiliaToolStripMenuItem,
            this.famiiaToolStripMenuItem,
            this.bodegaToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.compradoresToolStripMenuItem,
            this.tipoMovimientoToolStripMenuItem,
            this.tipoDePagoToolStripMenuItem});
            this.fromulariosToolStripMenuItem.Name = "fromulariosToolStripMenuItem";
            this.fromulariosToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.fromulariosToolStripMenuItem.Text = "Mantencion";
            // 
            // frmProductosToolStripMenuItem
            // 
            this.frmProductosToolStripMenuItem.Name = "frmProductosToolStripMenuItem";
            this.frmProductosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.frmProductosToolStripMenuItem.Text = "Productos";
            this.frmProductosToolStripMenuItem.Click += new System.EventHandler(this.FrmProductosToolStripMenuItem_Click);
            // 
            // subFamiliaToolStripMenuItem
            // 
            this.subFamiliaToolStripMenuItem.Name = "subFamiliaToolStripMenuItem";
            this.subFamiliaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.subFamiliaToolStripMenuItem.Text = "Sub-Familia";
            // 
            // famiiaToolStripMenuItem
            // 
            this.famiiaToolStripMenuItem.Name = "famiiaToolStripMenuItem";
            this.famiiaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.famiiaToolStripMenuItem.Text = "Famiia";
            // 
            // bodegaToolStripMenuItem
            // 
            this.bodegaToolStripMenuItem.Name = "bodegaToolStripMenuItem";
            this.bodegaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.bodegaToolStripMenuItem.Text = "Bodega";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // compradoresToolStripMenuItem
            // 
            this.compradoresToolStripMenuItem.Name = "compradoresToolStripMenuItem";
            this.compradoresToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.compradoresToolStripMenuItem.Text = "Compradores";
            // 
            // tipoMovimientoToolStripMenuItem
            // 
            this.tipoMovimientoToolStripMenuItem.Name = "tipoMovimientoToolStripMenuItem";
            this.tipoMovimientoToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.tipoMovimientoToolStripMenuItem.Text = "Tipo Movimiento";
            this.tipoMovimientoToolStripMenuItem.Click += new System.EventHandler(this.TipoMovimientoToolStripMenuItem_Click);
            // 
            // tipoDePagoToolStripMenuItem
            // 
            this.tipoDePagoToolStripMenuItem.Name = "tipoDePagoToolStripMenuItem";
            this.tipoDePagoToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.tipoDePagoToolStripMenuItem.Text = "Tipo de Pago";
            // 
            // ordenCompraToolStripMenuItem
            // 
            this.ordenCompraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarOrdenDeCompraToolStripMenuItem});
            this.ordenCompraToolStripMenuItem.Name = "ordenCompraToolStripMenuItem";
            this.ordenCompraToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.ordenCompraToolStripMenuItem.Text = "Orden Compra";
            this.ordenCompraToolStripMenuItem.Click += new System.EventHandler(this.OrdenCompraToolStripMenuItem_Click);
            // 
            // generarOrdenDeCompraToolStripMenuItem
            // 
            this.generarOrdenDeCompraToolStripMenuItem.Name = "generarOrdenDeCompraToolStripMenuItem";
            this.generarOrdenDeCompraToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.generarOrdenDeCompraToolStripMenuItem.Text = "Generar Orden de Compra";
            // 
            // recepcionBodegaToolStripMenuItem
            // 
            this.recepcionBodegaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarRecepciònDeBodegaToolStripMenuItem});
            this.recepcionBodegaToolStripMenuItem.Name = "recepcionBodegaToolStripMenuItem";
            this.recepcionBodegaToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.recepcionBodegaToolStripMenuItem.Text = "Recepcion Bodega";
            this.recepcionBodegaToolStripMenuItem.Click += new System.EventHandler(this.RecepcionBodegaToolStripMenuItem_Click);
            // 
            // generarRecepciònDeBodegaToolStripMenuItem
            // 
            this.generarRecepciònDeBodegaToolStripMenuItem.Name = "generarRecepciònDeBodegaToolStripMenuItem";
            this.generarRecepciònDeBodegaToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.generarRecepciònDeBodegaToolStripMenuItem.Text = "Generar Recepciòn de Bodega";
            // 
            // bodegaToolStripMenuItem1
            // 
            this.bodegaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarSalidaDeBodegaToolStripMenuItem});
            this.bodegaToolStripMenuItem1.Name = "bodegaToolStripMenuItem1";
            this.bodegaToolStripMenuItem1.Size = new System.Drawing.Size(59, 20);
            this.bodegaToolStripMenuItem1.Text = "Bodega";
            // 
            // generarSalidaDeBodegaToolStripMenuItem
            // 
            this.generarSalidaDeBodegaToolStripMenuItem.Name = "generarSalidaDeBodegaToolStripMenuItem";
            this.generarSalidaDeBodegaToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.generarSalidaDeBodegaToolStripMenuItem.Text = "Generar Salida de Bodega";
            this.generarSalidaDeBodegaToolStripMenuItem.Click += new System.EventHandler(this.GenerarSalidaDeBodegaToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 432);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fromulariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frmProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recepcionBodegaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subFamiliaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem famiiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bodegaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoMovimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDePagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarOrdenDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarRecepciònDeBodegaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bodegaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem generarSalidaDeBodegaToolStripMenuItem;
    }
}