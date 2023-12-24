namespace Gestor_de_Sistema
{
    partial class FrmRecepcionBodega
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTipoMovimiento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboBodega = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNroOc = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.dtFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.label = new System.Windows.Forms.Label();
            this.txtNrofactura = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtFolioMov = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.dgvDetalle);
            this.GroupBox2.Location = new System.Drawing.Point(20, 151);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(968, 269);
            this.GroupBox2.TabIndex = 20;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Detalles Movimientos";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProducto,
            this.NombreProducto,
            this.CantidadProducto,
            this.PrecioProducto});
            this.dgvDetalle.Location = new System.Drawing.Point(6, 19);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.Size = new System.Drawing.Size(956, 236);
            this.dgvDetalle.TabIndex = 1;
            this.dgvDetalle.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDetalle_CellEndEdit);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(22, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 27);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtTipoMovimiento);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.cboBodega);
            this.GroupBox1.Controls.Add(this.label6);
            this.GroupBox1.Controls.Add(this.txtNroOc);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.dtFechaFactura);
            this.GroupBox1.Controls.Add(this.label);
            this.GroupBox1.Controls.Add(this.txtNrofactura);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.txtFolioMov);
            this.GroupBox1.Location = new System.Drawing.Point(20, 62);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(968, 83);
            this.GroupBox1.TabIndex = 27;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Encabezado Movimiento";
            // 
            // txtTipoMovimiento
            // 
            this.txtTipoMovimiento.Location = new System.Drawing.Point(163, 43);
            this.txtTipoMovimiento.MaxLength = 8;
            this.txtTipoMovimiento.Name = "txtTipoMovimiento";
            this.txtTipoMovimiento.Size = new System.Drawing.Size(100, 20);
            this.txtTipoMovimiento.TabIndex = 42;
            this.txtTipoMovimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTipoMovimiento.Validating += new System.ComponentModel.CancelEventHandler(this.TxtTipoMovimiento_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(160, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Tipo Movimiento";
            // 
            // cboBodega
            // 
            this.cboBodega.FormattingEnabled = true;
            this.cboBodega.Location = new System.Drawing.Point(471, 42);
            this.cboBodega.Name = "cboBodega";
            this.cboBodega.Size = new System.Drawing.Size(121, 21);
            this.cboBodega.TabIndex = 41;
            this.cboBodega.Validating += new System.ComponentModel.CancelEventHandler(this.CboBodega_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(770, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Fecha Factura";
            // 
            // txtNroOc
            // 
            this.txtNroOc.Location = new System.Drawing.Point(320, 43);
            this.txtNroOc.MaxLength = 8;
            this.txtNroOc.Name = "txtNroOc";
            this.txtNroOc.Size = new System.Drawing.Size(100, 20);
            this.txtNroOc.TabIndex = 30;
            this.txtNroOc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNroOc.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNroOc_Validating);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label8.Location = new System.Drawing.Point(317, 25);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(39, 13);
            this.Label8.TabIndex = 32;
            this.Label8.Text = "NroOC";
            // 
            // dtFechaFactura
            // 
            this.dtFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFactura.Location = new System.Drawing.Point(773, 43);
            this.dtFechaFactura.Name = "dtFechaFactura";
            this.dtFechaFactura.Size = new System.Drawing.Size(85, 20);
            this.dtFechaFactura.TabIndex = 39;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(468, 22);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(56, 13);
            this.label.TabIndex = 36;
            this.label.Text = "Id Bodega";
            // 
            // txtNrofactura
            // 
            this.txtNrofactura.Location = new System.Drawing.Point(644, 43);
            this.txtNrofactura.MaxLength = 8;
            this.txtNrofactura.Name = "txtNrofactura";
            this.txtNrofactura.Size = new System.Drawing.Size(88, 20);
            this.txtNrofactura.TabIndex = 33;
            this.txtNrofactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label1.Location = new System.Drawing.Point(641, 23);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(83, 13);
            this.Label1.TabIndex = 34;
            this.Label1.Text = "Numero Factura";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label2.Location = new System.Drawing.Point(26, 24);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(85, 13);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Nro. Documento";
            // 
            // txtFolioMov
            // 
            this.txtFolioMov.Location = new System.Drawing.Point(29, 43);
            this.txtFolioMov.Name = "txtFolioMov";
            this.txtFolioMov.Size = new System.Drawing.Size(70, 20);
            this.txtFolioMov.TabIndex = 4;
            this.txtFolioMov.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFolioMov.Validating += new System.ComponentModel.CancelEventHandler(this.TxtFolioMov_Validating);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(194, 12);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(107, 27);
            this.btnLimpiar.TabIndex = 28;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.DataPropertyName = "idProducto";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoProducto.DefaultCellStyle = dataGridViewCellStyle2;
            this.CodigoProducto.HeaderText = "ID Producto";
            this.CodigoProducto.MaxInputLength = 80;
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.Width = 190;
            // 
            // NombreProducto
            // 
            this.NombreProducto.DataPropertyName = "NombreProducto";
            this.NombreProducto.HeaderText = "Nombre Producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.Width = 340;
            // 
            // CantidadProducto
            // 
            this.CantidadProducto.DataPropertyName = "Cantidad";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "N3";
            dataGridViewCellStyle3.NullValue = "0";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CantidadProducto.DefaultCellStyle = dataGridViewCellStyle3;
            this.CantidadProducto.HeaderText = "Cantidad Producto";
            this.CantidadProducto.Name = "CantidadProducto";
            this.CantidadProducto.Width = 190;
            // 
            // PrecioProducto
            // 
            this.PrecioProducto.DataPropertyName = "Precio";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 8.25F);
            dataGridViewCellStyle4.Format = "C0";
            dataGridViewCellStyle4.NullValue = "0";
            this.PrecioProducto.DefaultCellStyle = dataGridViewCellStyle4;
            this.PrecioProducto.HeaderText = "$ Precio Producto";
            this.PrecioProducto.Name = "PrecioProducto";
            this.PrecioProducto.Width = 190;
            // 
            // FrmRecepcionBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 432);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.GroupBox2);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRecepcionBodega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRecepcionBodega";
            this.Load += new System.EventHandler(this.FrmRecepcionBodega_Load);
            this.GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Button btnAgregar;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtNroOc;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.DateTimePicker dtFechaFactura;
        private System.Windows.Forms.Label label;
        internal System.Windows.Forms.TextBox txtNrofactura;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtFolioMov;
        private System.Windows.Forms.ComboBox cboBodega;
        internal System.Windows.Forms.TextBox txtTipoMovimiento;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioProducto;
    }
}