namespace Gestor_de_Sistema
{
    partial class FrmOrdenCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRutComprador = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.dtFchEntre = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRutProveedor = new System.Windows.Forms.TextBox();
            this.txtNombreComprador = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.dtFchEmis = new System.Windows.Forms.DateTimePicker();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDetallePago = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.CodigoMedioPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMedioPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePago)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.dgvDetalle);
            this.GroupBox2.Location = new System.Drawing.Point(12, 145);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(984, 125);
            this.GroupBox2.TabIndex = 19;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Detalles Productos";
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
            this.dgvDetalle.Location = new System.Drawing.Point(6, 15);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.Size = new System.Drawing.Size(972, 103);
            this.dgvDetalle.TabIndex = 1;
            this.dgvDetalle.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDetalle_CellEndEdit_1);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtObservacion);
            this.GroupBox1.Controls.Add(this.label7);
            this.GroupBox1.Controls.Add(this.label6);
            this.GroupBox1.Controls.Add(this.txtRutComprador);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.dtFchEntre);
            this.GroupBox1.Controls.Add(this.label5);
            this.GroupBox1.Controls.Add(this.txtRazonSocial);
            this.GroupBox1.Controls.Add(this.label4);
            this.GroupBox1.Controls.Add(this.txtRutProveedor);
            this.GroupBox1.Controls.Add(this.txtNombreComprador);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.dtFchEmis);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.txtFolio);
            this.GroupBox1.Location = new System.Drawing.Point(12, 56);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(984, 83);
            this.GroupBox1.TabIndex = 20;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Encabezado Orden Compra";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(231, 43);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(100, 20);
            this.txtObservacion.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Observacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(346, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Fecha Entrega";
            // 
            // txtRutComprador
            // 
            this.txtRutComprador.Location = new System.Drawing.Point(456, 44);
            this.txtRutComprador.MaxLength = 8;
            this.txtRutComprador.Name = "txtRutComprador";
            this.txtRutComprador.Size = new System.Drawing.Size(100, 20);
            this.txtRutComprador.TabIndex = 30;
            this.txtRutComprador.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRutComprador.Validating += new System.ComponentModel.CancelEventHandler(this.TxtRutComprador_Validating_1);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label8.Location = new System.Drawing.Point(453, 26);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(78, 13);
            this.Label8.TabIndex = 32;
            this.Label8.Text = "Rut Comprador";
            // 
            // dtFchEntre
            // 
            this.dtFchEntre.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFchEntre.Location = new System.Drawing.Point(349, 44);
            this.dtFchEntre.Name = "dtFchEntre";
            this.dtFchEntre.Size = new System.Drawing.Size(84, 20);
            this.dtFchEntre.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(820, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Rzon Social";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(823, 44);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(117, 20);
            this.txtRazonSocial.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(713, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Rut Proveedor";
            // 
            // txtRutProveedor
            // 
            this.txtRutProveedor.Location = new System.Drawing.Point(716, 44);
            this.txtRutProveedor.Name = "txtRutProveedor";
            this.txtRutProveedor.Size = new System.Drawing.Size(91, 20);
            this.txtRutProveedor.TabIndex = 35;
            this.txtRutProveedor.Validating += new System.ComponentModel.CancelEventHandler(this.TxtRutProveedor_Validating_1);
            // 
            // txtNombreComprador
            // 
            this.txtNombreComprador.Location = new System.Drawing.Point(572, 44);
            this.txtNombreComprador.MaxLength = 8;
            this.txtNombreComprador.Name = "txtNombreComprador";
            this.txtNombreComprador.Size = new System.Drawing.Size(122, 20);
            this.txtNombreComprador.TabIndex = 33;
            this.txtNombreComprador.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label1.Location = new System.Drawing.Point(569, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(98, 13);
            this.Label1.TabIndex = 34;
            this.Label1.Text = "Nombre Comprador";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label3.Location = new System.Drawing.Point(126, 25);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(76, 13);
            this.Label3.TabIndex = 29;
            this.Label3.Text = "Fecha Emisión";
            // 
            // dtFchEmis
            // 
            this.dtFchEmis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFchEmis.Location = new System.Drawing.Point(129, 44);
            this.dtFchEmis.Name = "dtFchEmis";
            this.dtFchEmis.Size = new System.Drawing.Size(84, 20);
            this.dtFchEmis.TabIndex = 28;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label2.Location = new System.Drawing.Point(36, 24);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(85, 13);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Nro. Documento";
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(39, 43);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(70, 20);
            this.txtFolio.TabIndex = 4;
            this.txtFolio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFolio.TextChanged += new System.EventHandler(this.TxtFolio_TextChanged);
            this.txtFolio.Validated += new System.EventHandler(this.TxtFolio_Validated);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDetallePago);
            this.groupBox3.Location = new System.Drawing.Point(12, 286);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(984, 129);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle de Pagos";
            // 
            // dgvDetallePago
            // 
            this.dgvDetallePago.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetallePago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDetallePago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallePago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoMedioPago,
            this.NombreMedioPago,
            this.FechaPago,
            this.MontoPago});
            this.dgvDetallePago.Location = new System.Drawing.Point(6, 15);
            this.dgvDetallePago.Name = "dgvDetallePago";
            this.dgvDetallePago.Size = new System.Drawing.Size(972, 109);
            this.dgvDetallePago.TabIndex = 1;
            this.dgvDetallePago.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDetallePago_CellEndEdit);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(27, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 27);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(153, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 27);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(284, 12);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(107, 27);
            this.btnLimpiar.TabIndex = 25;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // CodigoMedioPago
            // 
            this.CodigoMedioPago.DataPropertyName = "IdMedioPago";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoMedioPago.DefaultCellStyle = dataGridViewCellStyle7;
            this.CodigoMedioPago.HeaderText = "ID Medio Pago";
            this.CodigoMedioPago.MaxInputLength = 4;
            this.CodigoMedioPago.Name = "CodigoMedioPago";
            this.CodigoMedioPago.ToolTipText = "Ingrese el Código de Producto";
            this.CodigoMedioPago.Width = 220;
            // 
            // NombreMedioPago
            // 
            this.NombreMedioPago.DataPropertyName = "NombreMedioPago";
            this.NombreMedioPago.HeaderText = "Nombre Medio Pago";
            this.NombreMedioPago.Name = "NombreMedioPago";
            this.NombreMedioPago.Width = 269;
            // 
            // FechaPago
            // 
            this.FechaPago.DataPropertyName = "FechaPago";
            this.FechaPago.HeaderText = "Fecha Pago";
            this.FechaPago.Name = "FechaPago";
            this.FechaPago.Width = 220;
            // 
            // MontoPago
            // 
            this.MontoPago.DataPropertyName = "MontoPago";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 8.25F);
            dataGridViewCellStyle8.Format = "C0";
            dataGridViewCellStyle8.NullValue = "0";
            this.MontoPago.DefaultCellStyle = dataGridViewCellStyle8;
            this.MontoPago.HeaderText = "Monto Pago";
            this.MontoPago.Name = "MontoPago";
            this.MontoPago.Width = 220;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.DataPropertyName = "idProducto";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoProducto.DefaultCellStyle = dataGridViewCellStyle2;
            this.CodigoProducto.HeaderText = "ID Producto";
            this.CodigoProducto.MaxInputLength = 4;
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.ToolTipText = "Ingrese el Código de Producto";
            this.CodigoProducto.Width = 220;
            // 
            // NombreProducto
            // 
            this.NombreProducto.DataPropertyName = "NombreProducto";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreProducto.DefaultCellStyle = dataGridViewCellStyle3;
            this.NombreProducto.HeaderText = "Nombre Producto";
            this.NombreProducto.MaxInputLength = 80;
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            this.NombreProducto.Width = 269;
            // 
            // CantidadProducto
            // 
            this.CantidadProducto.DataPropertyName = "CantidadProducto";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "N3";
            dataGridViewCellStyle4.NullValue = "0";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CantidadProducto.DefaultCellStyle = dataGridViewCellStyle4;
            this.CantidadProducto.HeaderText = "Cantidad Producto";
            this.CantidadProducto.Name = "CantidadProducto";
            this.CantidadProducto.Width = 220;
            // 
            // PrecioProducto
            // 
            this.PrecioProducto.DataPropertyName = "PrecioProducto";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 8.25F);
            dataGridViewCellStyle5.Format = "C0";
            dataGridViewCellStyle5.NullValue = "0";
            this.PrecioProducto.DefaultCellStyle = dataGridViewCellStyle5;
            this.PrecioProducto.HeaderText = "$ Precio Producto";
            this.PrecioProducto.Name = "PrecioProducto";
            this.PrecioProducto.Width = 220;
            // 
            // FrmOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 432);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox2);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOrdenCompra";
            this.Load += new System.EventHandler(this.FrmOrdenCompra_Load);
            this.GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePago)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.DataGridView dgvDetalle;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtNombreComprador;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtRutComprador;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.DateTimePicker dtFchEmis;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtFolio;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.DateTimePicker dtFchEntre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRutProveedor;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.DataGridView dgvDetallePago;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoMedioPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMedioPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoPago;
    }
}