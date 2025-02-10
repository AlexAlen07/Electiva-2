namespace PSC09
{
    partial class frmFactura
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPagaImpuesto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFechaFactura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.TextBox();
            this.lblNombrePaga = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.TextBox();
            this.lblImpuestoLn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalLn = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblImpuesto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrarLn = new System.Windows.Forms.Button();
            this.btnLimpiarDet = new System.Windows.Forms.Button();
            this.btnInsertarLn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnArticulo = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 100);
            this.label1.TabIndex = 42;
            this.label1.Text = "Facturacion";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFactura
            // 
            this.lblFactura.Location = new System.Drawing.Point(311, 122);
            this.lblFactura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblFactura.Multiline = true;
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(198, 32);
            this.lblFactura.TabIndex = 106;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 32);
            this.label2.TabIndex = 105;
            this.label2.Text = "Numero Factura";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(311, 163);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCliente.Multiline = true;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(198, 32);
            this.txtCliente.TabIndex = 109;
            this.txtCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_KeyDown);
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_KeyPress);
            this.txtCliente.Leave += new System.EventHandler(this.txtCliente_Leave);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 32);
            this.label3.TabIndex = 108;
            this.label3.Text = "Cliente";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPagaImpuesto
            // 
            this.lblPagaImpuesto.Location = new System.Drawing.Point(311, 205);
            this.lblPagaImpuesto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblPagaImpuesto.Multiline = true;
            this.lblPagaImpuesto.Name = "lblPagaImpuesto";
            this.lblPagaImpuesto.Size = new System.Drawing.Size(198, 32);
            this.lblPagaImpuesto.TabIndex = 112;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 32);
            this.label4.TabIndex = 111;
            this.label4.Text = "Paga Impuesto";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFechaFactura
            // 
            this.lblFechaFactura.Location = new System.Drawing.Point(311, 246);
            this.lblFechaFactura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblFechaFactura.Multiline = true;
            this.lblFechaFactura.Name = "lblFechaFactura";
            this.lblFechaFactura.Size = new System.Drawing.Size(245, 32);
            this.lblFechaFactura.TabIndex = 114;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 32);
            this.label5.TabIndex = 113;
            this.label5.Text = "Fecha Factura";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(562, 163);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblNombre.Multiline = true;
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(380, 32);
            this.lblNombre.TabIndex = 115;
            // 
            // lblNombrePaga
            // 
            this.lblNombrePaga.Location = new System.Drawing.Point(562, 205);
            this.lblNombrePaga.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblNombrePaga.Multiline = true;
            this.lblNombrePaga.Name = "lblNombrePaga";
            this.lblNombrePaga.Size = new System.Drawing.Size(380, 32);
            this.lblNombrePaga.TabIndex = 116;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 32);
            this.label6.TabIndex = 117;
            this.label6.Text = "Articulo";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(12, 330);
            this.txtArticulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtArticulo.Multiline = true;
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(173, 32);
            this.txtArticulo.TabIndex = 118;
            this.txtArticulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArticulo_KeyDown);
            this.txtArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArticulo_KeyPress);
            this.txtArticulo.Leave += new System.EventHandler(this.txtArticulo_Leave);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(245, 330);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblDescripcion.Multiline = true;
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(311, 32);
            this.lblDescripcion.TabIndex = 120;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(562, 330);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(187, 32);
            this.txtCantidad.TabIndex = 121;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            this.txtCantidad.Leave += new System.EventHandler(this.txtCantidad_Leave);
            // 
            // lblPrecio
            // 
            this.lblPrecio.Location = new System.Drawing.Point(755, 330);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblPrecio.Multiline = true;
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(187, 32);
            this.lblPrecio.TabIndex = 122;
            // 
            // lblImpuestoLn
            // 
            this.lblImpuestoLn.Location = new System.Drawing.Point(948, 330);
            this.lblImpuestoLn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblImpuestoLn.Multiline = true;
            this.lblImpuestoLn.Name = "lblImpuestoLn";
            this.lblImpuestoLn.Size = new System.Drawing.Size(187, 32);
            this.lblImpuestoLn.TabIndex = 123;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(755, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 32);
            this.label7.TabIndex = 124;
            this.label7.Text = "Precio";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Gray;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(562, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 32);
            this.label8.TabIndex = 125;
            this.label8.Text = "Cantidad";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Gray;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(245, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(311, 32);
            this.label9.TabIndex = 126;
            this.label9.Text = "Descripcion";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Gray;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(948, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 32);
            this.label10.TabIndex = 128;
            this.label10.Text = "Impuesto Ln";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Gray;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(1141, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 32);
            this.label11.TabIndex = 129;
            this.label11.Text = "Total Ln";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalLn
            // 
            this.lblTotalLn.Location = new System.Drawing.Point(1141, 330);
            this.lblTotalLn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTotalLn.Multiline = true;
            this.lblTotalLn.Name = "lblTotalLn";
            this.lblTotalLn.Size = new System.Drawing.Size(184, 32);
            this.lblTotalLn.TabIndex = 130;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 369);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(1313, 259);
            this.dgv.TabIndex = 131;
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(1075, 715);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTotal.Multiline = true;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(250, 32);
            this.lblTotal.TabIndex = 141;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(781, 715);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(288, 32);
            this.label12.TabIndex = 140;
            this.label12.Text = "Total";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.Location = new System.Drawing.Point(1075, 675);
            this.lblImpuesto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblImpuesto.Multiline = true;
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(250, 32);
            this.lblImpuesto.TabIndex = 139;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(781, 675);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(288, 32);
            this.label13.TabIndex = 138;
            this.label13.Text = "Impuesto";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Location = new System.Drawing.Point(1075, 635);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblSubTotal.Multiline = true;
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(250, 32);
            this.lblSubTotal.TabIndex = 137;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(781, 635);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(288, 32);
            this.label14.TabIndex = 136;
            this.label14.Text = "Sub Total";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::PSC09.Properties.Resources.edit;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(162, 635);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(144, 100);
            this.btnEditar.TabIndex = 135;
            this.btnEditar.Text = "Editar Lineas";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnBorrarLn
            // 
            this.btnBorrarLn.Image = global::PSC09.Properties.Resources.delete_table_row;
            this.btnBorrarLn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBorrarLn.Location = new System.Drawing.Point(312, 635);
            this.btnBorrarLn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBorrarLn.Name = "btnBorrarLn";
            this.btnBorrarLn.Size = new System.Drawing.Size(144, 100);
            this.btnBorrarLn.TabIndex = 134;
            this.btnBorrarLn.Text = "Borrar Lineas";
            this.btnBorrarLn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrarLn.UseVisualStyleBackColor = true;
            this.btnBorrarLn.Click += new System.EventHandler(this.btnBorrarLn_Click);
            // 
            // btnLimpiarDet
            // 
            this.btnLimpiarDet.Image = global::PSC09.Properties.Resources.filenew;
            this.btnLimpiarDet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpiarDet.Location = new System.Drawing.Point(462, 635);
            this.btnLimpiarDet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpiarDet.Name = "btnLimpiarDet";
            this.btnLimpiarDet.Size = new System.Drawing.Size(144, 100);
            this.btnLimpiarDet.TabIndex = 133;
            this.btnLimpiarDet.Text = "Limpiar Detalle";
            this.btnLimpiarDet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiarDet.UseVisualStyleBackColor = true;
            // 
            // btnInsertarLn
            // 
            this.btnInsertarLn.Image = global::PSC09.Properties.Resources.insert_table_row;
            this.btnInsertarLn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInsertarLn.Location = new System.Drawing.Point(12, 635);
            this.btnInsertarLn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsertarLn.Name = "btnInsertarLn";
            this.btnInsertarLn.Size = new System.Drawing.Size(144, 100);
            this.btnInsertarLn.TabIndex = 132;
            this.btnInsertarLn.Text = "Insertar Lineas";
            this.btnInsertarLn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInsertarLn.UseVisualStyleBackColor = true;
            this.btnInsertarLn.Click += new System.EventHandler(this.btnInsertarLn_Click);
            // 
            // button3
            // 
            this.button3.Image = global::PSC09.Properties.Resources.fileprint;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(1012, 9);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 100);
            this.button3.TabIndex = 127;
            this.button3.Text = "Imprimir";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnArticulo
            // 
            this.btnArticulo.Image = global::PSC09.Properties.Resources.Lupa;
            this.btnArticulo.Location = new System.Drawing.Point(191, 330);
            this.btnArticulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnArticulo.Name = "btnArticulo";
            this.btnArticulo.Size = new System.Drawing.Size(48, 33);
            this.btnArticulo.TabIndex = 119;
            this.btnArticulo.UseVisualStyleBackColor = true;
            // 
            // btnCliente
            // 
            this.btnCliente.Image = global::PSC09.Properties.Resources.Lupa1;
            this.btnCliente.Location = new System.Drawing.Point(515, 163);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(41, 33);
            this.btnCliente.TabIndex = 110;
            this.btnCliente.Text = "...";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.Image = global::PSC09.Properties.Resources.Lupa;
            this.btnFactura.Location = new System.Drawing.Point(515, 121);
            this.btnFactura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(41, 33);
            this.btnFactura.TabIndex = 107;
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::PSC09.Properties.Resources.exit;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(1162, 9);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(144, 100);
            this.btnSalir.TabIndex = 46;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = global::PSC09.Properties.Resources.editdelete;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBorrar.Location = new System.Drawing.Point(862, 9);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(144, 100);
            this.btnBorrar.TabIndex = 45;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::PSC09.Properties.Resources.filenew;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpiar.Location = new System.Drawing.Point(712, 9);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(144, 100);
            this.btnLimpiar.TabIndex = 44;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::PSC09.Properties.Resources.filesave;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(562, 9);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(144, 100);
            this.btnGuardar.TabIndex = 43;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 773);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblImpuesto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBorrarLn);
            this.Controls.Add(this.btnLimpiarDet);
            this.Controls.Add(this.btnInsertarLn);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lblTotalLn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblImpuestoLn);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btnArticulo);
            this.Controls.Add(this.txtArticulo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNombrePaga);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblFechaFactura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPagaImpuesto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFactura);
            this.Controls.Add(this.lblFactura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Name = "frmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmFactura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.TextBox lblFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lblPagaImpuesto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lblFechaFactura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lblNombre;
        private System.Windows.Forms.TextBox lblNombrePaga;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Button btnArticulo;
        private System.Windows.Forms.TextBox lblDescripcion;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox lblPrecio;
        private System.Windows.Forms.TextBox lblImpuestoLn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox lblTotalLn;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnBorrarLn;
        private System.Windows.Forms.Button btnLimpiarDet;
        private System.Windows.Forms.Button btnInsertarLn;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox lblTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox lblImpuesto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox lblSubTotal;
        private System.Windows.Forms.Label label14;
    }
}