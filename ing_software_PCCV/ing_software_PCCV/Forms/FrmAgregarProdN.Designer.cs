namespace ing_software_PCCV.Forms
{
    partial class FrmAgregarProdN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarProdN));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbVestimenta = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbxProveedor = new System.Windows.Forms.ComboBox();
            this.txtDescripcionV = new System.Windows.Forms.RichTextBox();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.txtCantidadV = new System.Windows.Forms.TextBox();
            this.txtPrecioV = new System.Windows.Forms.TextBox();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.txtNombreV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTalla = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnVestimenta = new System.Windows.Forms.RadioButton();
            this.rbtnCalzado = new System.Windows.Forms.RadioButton();
            this.rbtnBisuteria = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblidUsuario = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Talla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.chxFactura = new System.Windows.Forms.CheckBox();
            this.txtNFac = new System.Windows.Forms.TextBox();
            this.txtCantTot = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.gbVestimenta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 45);
            this.panel1.TabIndex = 2;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1333, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(601, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar producto nuevo";
            // 
            // gbVestimenta
            // 
            this.gbVestimenta.Controls.Add(this.btnGuardar);
            this.gbVestimenta.Controls.Add(this.txtDescripcionV);
            this.gbVestimenta.Controls.Add(this.txtTalla);
            this.gbVestimenta.Controls.Add(this.txtCantidadV);
            this.gbVestimenta.Controls.Add(this.txtPrecioV);
            this.gbVestimenta.Controls.Add(this.txtNombreV);
            this.gbVestimenta.Controls.Add(this.label3);
            this.gbVestimenta.Controls.Add(this.lblTalla);
            this.gbVestimenta.Controls.Add(this.label5);
            this.gbVestimenta.Controls.Add(this.label4);
            this.gbVestimenta.Controls.Add(this.label2);
            this.gbVestimenta.Location = new System.Drawing.Point(30, 195);
            this.gbVestimenta.Name = "gbVestimenta";
            this.gbVestimenta.Size = new System.Drawing.Size(543, 393);
            this.gbVestimenta.TabIndex = 3;
            this.gbVestimenta.TabStop = false;
            this.gbVestimenta.Text = "Datos del producto";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Salmon;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(181, 270);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(196, 31);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbxProveedor
            // 
            this.cbxProveedor.FormattingEnabled = true;
            this.cbxProveedor.Location = new System.Drawing.Point(12, 80);
            this.cbxProveedor.Name = "cbxProveedor";
            this.cbxProveedor.Size = new System.Drawing.Size(170, 24);
            this.cbxProveedor.TabIndex = 3;
            // 
            // txtDescripcionV
            // 
            this.txtDescripcionV.Location = new System.Drawing.Point(292, 135);
            this.txtDescripcionV.Name = "txtDescripcionV";
            this.txtDescripcionV.Size = new System.Drawing.Size(212, 97);
            this.txtDescripcionV.TabIndex = 2;
            this.txtDescripcionV.Text = "";
            // 
            // txtTalla
            // 
            this.txtTalla.Location = new System.Drawing.Point(66, 209);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(161, 23);
            this.txtTalla.TabIndex = 1;
            // 
            // txtCantidadV
            // 
            this.txtCantidadV.Location = new System.Drawing.Point(316, 60);
            this.txtCantidadV.Name = "txtCantidadV";
            this.txtCantidadV.Size = new System.Drawing.Size(161, 23);
            this.txtCantidadV.TabIndex = 1;
            this.txtCantidadV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadV_KeyPress);
            // 
            // txtPrecioV
            // 
            this.txtPrecioV.Location = new System.Drawing.Point(66, 136);
            this.txtPrecioV.Name = "txtPrecioV";
            this.txtPrecioV.Size = new System.Drawing.Size(161, 23);
            this.txtPrecioV.TabIndex = 1;
            this.txtPrecioV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioV_KeyPress);
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(97, 28);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(85, 23);
            this.txtFactura.TabIndex = 1;
            this.txtFactura.TextChanged += new System.EventHandler(this.txtNFacturaV_TextChanged);
            // 
            // txtNombreV
            // 
            this.txtNombreV.Location = new System.Drawing.Point(67, 61);
            this.txtNombreV.Name = "txtNombreV";
            this.txtNombreV.Size = new System.Drawing.Size(161, 23);
            this.txtNombreV.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Descripción:";
            // 
            // lblTalla
            // 
            this.lblTalla.AutoSize = true;
            this.lblTalla.Location = new System.Drawing.Point(64, 175);
            this.lblTalla.Name = "lblTalla";
            this.lblTalla.Size = new System.Drawing.Size(39, 17);
            this.lblTalla.TabIndex = 0;
            this.lblTalla.Text = "Talla";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Proveedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Precio:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(11, 28);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 17);
            this.label21.TabIndex = 0;
            this.label21.Text = "N° Factura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // rbtnVestimenta
            // 
            this.rbtnVestimenta.AutoSize = true;
            this.rbtnVestimenta.Checked = true;
            this.rbtnVestimenta.Location = new System.Drawing.Point(19, 29);
            this.rbtnVestimenta.Name = "rbtnVestimenta";
            this.rbtnVestimenta.Size = new System.Drawing.Size(96, 21);
            this.rbtnVestimenta.TabIndex = 4;
            this.rbtnVestimenta.TabStop = true;
            this.rbtnVestimenta.Text = "Vestimenta";
            this.rbtnVestimenta.UseVisualStyleBackColor = true;
            this.rbtnVestimenta.CheckedChanged += new System.EventHandler(this.rbtnVestimenta_CheckedChanged);
            // 
            // rbtnCalzado
            // 
            this.rbtnCalzado.AutoSize = true;
            this.rbtnCalzado.Location = new System.Drawing.Point(19, 56);
            this.rbtnCalzado.Name = "rbtnCalzado";
            this.rbtnCalzado.Size = new System.Drawing.Size(77, 21);
            this.rbtnCalzado.TabIndex = 5;
            this.rbtnCalzado.Text = "Calzado";
            this.rbtnCalzado.UseVisualStyleBackColor = true;
            this.rbtnCalzado.CheckedChanged += new System.EventHandler(this.rbtnCalzado_CheckedChanged);
            // 
            // rbtnBisuteria
            // 
            this.rbtnBisuteria.AutoSize = true;
            this.rbtnBisuteria.Location = new System.Drawing.Point(18, 83);
            this.rbtnBisuteria.Name = "rbtnBisuteria";
            this.rbtnBisuteria.Size = new System.Drawing.Size(81, 21);
            this.rbtnBisuteria.TabIndex = 6;
            this.rbtnBisuteria.Text = "Bisuteria";
            this.rbtnBisuteria.UseVisualStyleBackColor = true;
            this.rbtnBisuteria.CheckedChanged += new System.EventHandler(this.rbtnBisuteria_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCantTot);
            this.groupBox1.Controls.Add(this.txtNFac);
            this.groupBox1.Controls.Add(this.btnFinalizar);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(1109, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 412);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vista preliminar del reporte";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(89, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Total:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Cantidad total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 17);
            this.label10.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "N° de factura:";
            // 
            // lblidUsuario
            // 
            this.lblidUsuario.AutoSize = true;
            this.lblidUsuario.Location = new System.Drawing.Point(1242, 480);
            this.lblidUsuario.Name = "lblidUsuario";
            this.lblidUsuario.Size = new System.Drawing.Size(0, 17);
            this.lblidUsuario.TabIndex = 8;
            this.lblidUsuario.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnCalzado);
            this.groupBox2.Controls.Add(this.rbtnVestimenta);
            this.groupBox2.Controls.Add(this.rbtnBisuteria);
            this.groupBox2.Location = new System.Drawing.Point(30, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 116);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Categoria del producto";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chxFactura);
            this.groupBox3.Controls.Add(this.txtFactura);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.cbxProveedor);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(276, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 116);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos iniciales";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvLista);
            this.groupBox4.Location = new System.Drawing.Point(590, 54);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(498, 534);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos de compra";
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AllowUserToResizeColumns = false;
            this.dgvLista.AllowUserToResizeRows = false;
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLista.BackgroundColor = System.Drawing.Color.White;
            this.dgvLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Precio,
            this.Talla,
            this.Cantidad,
            this.Descripcion});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLista.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLista.GridColor = System.Drawing.SystemColors.GrayText;
            this.dgvLista.Location = new System.Drawing.Point(6, 27);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLista.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLista.RowHeadersWidth = 5;
            this.dgvLista.Size = new System.Drawing.Size(486, 501);
            this.dgvLista.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft MHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblTotal.Location = new System.Drawing.Point(95, 241);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(28, 32);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotal.Click += new System.EventHandler(this.label7_Click);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Talla
            // 
            this.Talla.HeaderText = "Medida";
            this.Talla.Name = "Talla";
            this.Talla.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.Salmon;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Location = new System.Drawing.Point(41, 315);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(136, 34);
            this.btnFinalizar.TabIndex = 5;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(587, 622);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(16, 17);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "1";
            // 
            // chxFactura
            // 
            this.chxFactura.AutoSize = true;
            this.chxFactura.Location = new System.Drawing.Point(192, 28);
            this.chxFactura.Name = "chxFactura";
            this.chxFactura.Size = new System.Drawing.Size(99, 21);
            this.chxFactura.TabIndex = 4;
            this.chxFactura.Text = "Sin Factura";
            this.chxFactura.UseVisualStyleBackColor = true;
            this.chxFactura.CheckedChanged += new System.EventHandler(this.chxFactura_CheckedChanged);
            // 
            // txtNFac
            // 
            this.txtNFac.Enabled = false;
            this.txtNFac.Location = new System.Drawing.Point(34, 71);
            this.txtNFac.Name = "txtNFac";
            this.txtNFac.Size = new System.Drawing.Size(148, 23);
            this.txtNFac.TabIndex = 6;
            // 
            // txtCantTot
            // 
            this.txtCantTot.Enabled = false;
            this.txtCantTot.Location = new System.Drawing.Point(37, 160);
            this.txtCantTot.Name = "txtCantTot";
            this.txtCantTot.Size = new System.Drawing.Size(148, 23);
            this.txtCantTot.TabIndex = 7;
            // 
            // FrmAgregarProdN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblidUsuario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbVestimenta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAgregarProdN";
            this.Text = "FrmAgregarProdN";
            this.Load += new System.EventHandler(this.FrmAgregarProdN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.gbVestimenta.ResumeLayout(false);
            this.gbVestimenta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbVestimenta;
        private System.Windows.Forms.TextBox txtNombreV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtDescripcionV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidadV;
        private System.Windows.Forms.TextBox txtPrecioV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxProveedor;
        private System.Windows.Forms.RadioButton rbtnVestimenta;
        private System.Windows.Forms.RadioButton rbtnCalzado;
        private System.Windows.Forms.RadioButton rbtnBisuteria;
        private System.Windows.Forms.TextBox txtTalla;
        private System.Windows.Forms.Label lblTalla;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblidUsuario;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Talla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.CheckBox chxFactura;
        private System.Windows.Forms.TextBox txtCantTot;
        private System.Windows.Forms.TextBox txtNFac;
    }
}