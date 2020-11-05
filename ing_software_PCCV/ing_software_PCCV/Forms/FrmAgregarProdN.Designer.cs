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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbVestimenta = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.cbxProveedor = new System.Windows.Forms.ComboBox();
            this.txtDescripcionV = new System.Windows.Forms.RichTextBox();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.txtStockV = new System.Windows.Forms.TextBox();
            this.txtPrecioV = new System.Windows.Forms.TextBox();
            this.txtNombreV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnVestimenta = new System.Windows.Forms.RadioButton();
            this.rbtnCalzado = new System.Windows.Forms.RadioButton();
            this.rbtnBisuteria = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.gbVestimenta.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(456, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar producto nuevo";
            // 
            // gbVestimenta
            // 
            this.gbVestimenta.Controls.Add(this.btnGuardar);
            this.gbVestimenta.Controls.Add(this.cbxEstado);
            this.gbVestimenta.Controls.Add(this.cbxProveedor);
            this.gbVestimenta.Controls.Add(this.txtDescripcionV);
            this.gbVestimenta.Controls.Add(this.txtTalla);
            this.gbVestimenta.Controls.Add(this.txtStockV);
            this.gbVestimenta.Controls.Add(this.txtPrecioV);
            this.gbVestimenta.Controls.Add(this.txtNombreV);
            this.gbVestimenta.Controls.Add(this.label3);
            this.gbVestimenta.Controls.Add(this.label8);
            this.gbVestimenta.Controls.Add(this.label7);
            this.gbVestimenta.Controls.Add(this.label6);
            this.gbVestimenta.Controls.Add(this.label5);
            this.gbVestimenta.Controls.Add(this.label4);
            this.gbVestimenta.Controls.Add(this.label2);
            this.gbVestimenta.Location = new System.Drawing.Point(32, 134);
            this.gbVestimenta.Name = "gbVestimenta";
            this.gbVestimenta.Size = new System.Drawing.Size(545, 330);
            this.gbVestimenta.TabIndex = 3;
            this.gbVestimenta.TabStop = false;
            this.gbVestimenta.Text = "Datos del producto";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(379, 149);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(84, 31);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(106, 237);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(161, 24);
            this.cbxEstado.TabIndex = 3;
            // 
            // cbxProveedor
            // 
            this.cbxProveedor.FormattingEnabled = true;
            this.cbxProveedor.Location = new System.Drawing.Point(106, 195);
            this.cbxProveedor.Name = "cbxProveedor";
            this.cbxProveedor.Size = new System.Drawing.Size(161, 24);
            this.cbxProveedor.TabIndex = 3;
            // 
            // txtDescripcionV
            // 
            this.txtDescripcionV.Location = new System.Drawing.Point(106, 61);
            this.txtDescripcionV.Name = "txtDescripcionV";
            this.txtDescripcionV.Size = new System.Drawing.Size(161, 44);
            this.txtDescripcionV.TabIndex = 2;
            this.txtDescripcionV.Text = "";
            // 
            // txtTalla
            // 
            this.txtTalla.Location = new System.Drawing.Point(106, 279);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(161, 23);
            this.txtTalla.TabIndex = 1;
            // 
            // txtStockV
            // 
            this.txtStockV.Location = new System.Drawing.Point(106, 153);
            this.txtStockV.Name = "txtStockV";
            this.txtStockV.Size = new System.Drawing.Size(161, 23);
            this.txtStockV.TabIndex = 1;
            // 
            // txtPrecioV
            // 
            this.txtPrecioV.Location = new System.Drawing.Point(106, 111);
            this.txtPrecioV.Name = "txtPrecioV";
            this.txtPrecioV.Size = new System.Drawing.Size(161, 23);
            this.txtPrecioV.TabIndex = 1;
            // 
            // txtNombreV
            // 
            this.txtNombreV.Location = new System.Drawing.Point(106, 27);
            this.txtNombreV.Name = "txtNombreV";
            this.txtNombreV.Size = new System.Drawing.Size(161, 23);
            this.txtNombreV.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Descripción:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Talla:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Estado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Proveedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Stock:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // rbtnVestimenta
            // 
            this.rbtnVestimenta.AutoSize = true;
            this.rbtnVestimenta.Checked = true;
            this.rbtnVestimenta.Location = new System.Drawing.Point(41, 107);
            this.rbtnVestimenta.Name = "rbtnVestimenta";
            this.rbtnVestimenta.Size = new System.Drawing.Size(96, 21);
            this.rbtnVestimenta.TabIndex = 4;
            this.rbtnVestimenta.TabStop = true;
            this.rbtnVestimenta.Text = "Vestimenta";
            this.rbtnVestimenta.UseVisualStyleBackColor = true;
            // 
            // rbtnCalzado
            // 
            this.rbtnCalzado.AutoSize = true;
            this.rbtnCalzado.Location = new System.Drawing.Point(154, 107);
            this.rbtnCalzado.Name = "rbtnCalzado";
            this.rbtnCalzado.Size = new System.Drawing.Size(77, 21);
            this.rbtnCalzado.TabIndex = 5;
            this.rbtnCalzado.Text = "Calzado";
            this.rbtnCalzado.UseVisualStyleBackColor = true;
            // 
            // rbtnBisuteria
            // 
            this.rbtnBisuteria.AutoSize = true;
            this.rbtnBisuteria.Location = new System.Drawing.Point(267, 107);
            this.rbtnBisuteria.Name = "rbtnBisuteria";
            this.rbtnBisuteria.Size = new System.Drawing.Size(81, 21);
            this.rbtnBisuteria.TabIndex = 6;
            this.rbtnBisuteria.Text = "Bisuteria";
            this.rbtnBisuteria.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(829, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 325);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vista preliminar del reporte";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Total:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Cantidad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Producto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "N° de factura:";
            // 
            // FrmAgregarProdN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbtnBisuteria);
            this.Controls.Add(this.rbtnCalzado);
            this.Controls.Add(this.rbtnVestimenta);
            this.Controls.Add(this.gbVestimenta);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAgregarProdN";
            this.Text = "FrmAgregarProdN";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.gbVestimenta.ResumeLayout(false);
            this.gbVestimenta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtStockV;
        private System.Windows.Forms.TextBox txtPrecioV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxProveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbtnVestimenta;
        private System.Windows.Forms.RadioButton rbtnCalzado;
        private System.Windows.Forms.RadioButton rbtnBisuteria;
        private System.Windows.Forms.TextBox txtTalla;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}