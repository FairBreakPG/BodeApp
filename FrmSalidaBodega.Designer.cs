namespace Gestor_de_Sistema
{
    partial class FrmSalidaBodega
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSalidaBodega));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupboxDetallel = new System.Windows.Forms.GroupBox();
            this.GRIDVIEWsalidaB = new System.Windows.Forms.DataGridView();
            this.grpEnc_Movimiento = new System.Windows.Forms.GroupBox();
            this.cboBodega = new System.Windows.Forms.ComboBox();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.NombreTpoMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupboxDetallel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEWsalidaB)).BeginInit();
            this.grpEnc_Movimiento.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupboxDetallel
            // 
            this.groupboxDetallel.Controls.Add(this.GRIDVIEWsalidaB);
            this.groupboxDetallel.Location = new System.Drawing.Point(11, 206);
            this.groupboxDetallel.Margin = new System.Windows.Forms.Padding(2);
            this.groupboxDetallel.Name = "groupboxDetallel";
            this.groupboxDetallel.Padding = new System.Windows.Forms.Padding(2);
            this.groupboxDetallel.Size = new System.Drawing.Size(986, 215);
            this.groupboxDetallel.TabIndex = 33;
            this.groupboxDetallel.TabStop = false;
            this.groupboxDetallel.Text = "Detalle Salida Bodega";
            // 
            // GRIDVIEWsalidaB
            // 
            this.GRIDVIEWsalidaB.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRIDVIEWsalidaB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GRIDVIEWsalidaB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRIDVIEWsalidaB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreTpoMovimiento,
            this.CodigoProducto,
            this.NombreProducto,
            this.CantidadProducto,
            this.PrecioProducto});
            this.GRIDVIEWsalidaB.Location = new System.Drawing.Point(5, 18);
            this.GRIDVIEWsalidaB.Name = "GRIDVIEWsalidaB";
            this.GRIDVIEWsalidaB.RowHeadersWidth = 51;
            this.GRIDVIEWsalidaB.Size = new System.Drawing.Size(976, 192);
            this.GRIDVIEWsalidaB.TabIndex = 2;
            this.GRIDVIEWsalidaB.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRIDVIEWsalidaB_CellEndEdit);
            // 
            // grpEnc_Movimiento
            // 
            this.grpEnc_Movimiento.Controls.Add(this.cboBodega);
            this.grpEnc_Movimiento.Controls.Add(this.txtFolio);
            this.grpEnc_Movimiento.Controls.Add(this.label4);
            this.grpEnc_Movimiento.Controls.Add(this.label5);
            this.grpEnc_Movimiento.Location = new System.Drawing.Point(10, 85);
            this.grpEnc_Movimiento.Margin = new System.Windows.Forms.Padding(2);
            this.grpEnc_Movimiento.Name = "grpEnc_Movimiento";
            this.grpEnc_Movimiento.Padding = new System.Windows.Forms.Padding(2);
            this.grpEnc_Movimiento.Size = new System.Drawing.Size(986, 104);
            this.grpEnc_Movimiento.TabIndex = 32;
            this.grpEnc_Movimiento.TabStop = false;
            this.grpEnc_Movimiento.Text = "Encabezado Movimiento";
            // 
            // cboBodega
            // 
            this.cboBodega.FormattingEnabled = true;
            this.cboBodega.Location = new System.Drawing.Point(677, 47);
            this.cboBodega.Name = "cboBodega";
            this.cboBodega.Size = new System.Drawing.Size(121, 21);
            this.cboBodega.TabIndex = 42;
            this.cboBodega.Validating += new System.ComponentModel.CancelEventHandler(this.CboBodega_Validating);
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(174, 48);
            this.txtFolio.Margin = new System.Windows.Forms.Padding(2);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(121, 20);
            this.txtFolio.TabIndex = 6;
            this.txtFolio.Validating += new System.ComponentModel.CancelEventHandler(this.TxtFolio_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(674, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre Bodega";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "FolioMov";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(10, 37);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(97, 33);
            this.btnAgregar.TabIndex = 31;
            this.btnAgregar.Text = "     Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 25);
            this.toolStrip1.TabIndex = 34;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "NUEVO REGISTRO";
            // 
            // tsbSalir
            // 
            this.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalir.Image")));
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(23, 22);
            this.tsbSalir.Text = "Salir";
            this.tsbSalir.Click += new System.EventHandler(this.TsbSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(142, 37);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(104, 33);
            this.btnLimpiar.TabIndex = 35;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // NombreTpoMovimiento
            // 
            this.NombreTpoMovimiento.DataPropertyName = "NombreTpoMovimiento";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTpoMovimiento.DefaultCellStyle = dataGridViewCellStyle2;
            this.NombreTpoMovimiento.HeaderText = "Tipo Movimiento";
            this.NombreTpoMovimiento.MaxInputLength = 4;
            this.NombreTpoMovimiento.MinimumWidth = 6;
            this.NombreTpoMovimiento.Name = "NombreTpoMovimiento";
            this.NombreTpoMovimiento.ReadOnly = true;
            this.NombreTpoMovimiento.ToolTipText = "Ingrese el Tipo de Movimiento";
            this.NombreTpoMovimiento.Width = 220;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.DataPropertyName = "idProducto";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoProducto.DefaultCellStyle = dataGridViewCellStyle3;
            this.CodigoProducto.HeaderText = "ID Producto";
            this.CodigoProducto.MaxInputLength = 80;
            this.CodigoProducto.MinimumWidth = 6;
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.Width = 150;
            // 
            // NombreProducto
            // 
            this.NombreProducto.DataPropertyName = "NombreProducto";
            this.NombreProducto.HeaderText = "Nombre Producto";
            this.NombreProducto.MinimumWidth = 6;
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.Width = 263;
            // 
            // CantidadProducto
            // 
            this.CantidadProducto.DataPropertyName = "Cantidad";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "N3";
            dataGridViewCellStyle4.NullValue = "0";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CantidadProducto.DefaultCellStyle = dataGridViewCellStyle4;
            this.CantidadProducto.HeaderText = "Cantidad Producto";
            this.CantidadProducto.MinimumWidth = 6;
            this.CantidadProducto.Name = "CantidadProducto";
            this.CantidadProducto.Width = 150;
            // 
            // PrecioProducto
            // 
            this.PrecioProducto.DataPropertyName = "Precio";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 8.25F);
            dataGridViewCellStyle5.Format = "C0";
            dataGridViewCellStyle5.NullValue = "0";
            this.PrecioProducto.DefaultCellStyle = dataGridViewCellStyle5;
            this.PrecioProducto.HeaderText = "$ Precio Producto";
            this.PrecioProducto.MinimumWidth = 6;
            this.PrecioProducto.Name = "PrecioProducto";
            this.PrecioProducto.Width = 140;
            // 
            // FrmSalidaBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 432);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupboxDetallel);
            this.Controls.Add(this.grpEnc_Movimiento);
            this.Controls.Add(this.btnAgregar);
            this.IsMdiContainer = true;
            this.MinimizeBox = false;
            this.Name = "FrmSalidaBodega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salida Bodega";
            this.Load += new System.EventHandler(this.FrmSalidaBodega_Load);
            this.groupboxDetallel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEWsalidaB)).EndInit();
            this.grpEnc_Movimiento.ResumeLayout(false);
            this.grpEnc_Movimiento.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupboxDetallel;
        internal System.Windows.Forms.DataGridView GRIDVIEWsalidaB;
        private System.Windows.Forms.GroupBox grpEnc_Movimiento;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboBodega;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTpoMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioProducto;
    }
}