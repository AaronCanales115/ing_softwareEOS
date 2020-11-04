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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rbtnVestimenta = new System.Windows.Forms.RadioButton();
            this.rbtnCalzado = new System.Windows.Forms.RadioButton();
            this.rbtnBisuteria = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.gbVestimenta.SuspendLayout();
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
            this.gbVestimenta.Controls.Add(this.comboBox1);
            this.gbVestimenta.Controls.Add(this.richTextBox1);
            this.gbVestimenta.Controls.Add(this.textBox4);
            this.gbVestimenta.Controls.Add(this.textBox5);
            this.gbVestimenta.Controls.Add(this.textBox3);
            this.gbVestimenta.Controls.Add(this.textBox2);
            this.gbVestimenta.Controls.Add(this.textBox1);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 23);
            this.textBox1.TabIndex = 1;
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
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(106, 61);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(161, 44);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 23);
            this.textBox2.TabIndex = 1;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(106, 153);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(161, 23);
            this.textBox3.TabIndex = 1;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Estado:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(106, 237);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(161, 23);
            this.textBox5.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 195);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // rbtnVestimenta
            // 
            this.rbtnVestimenta.AutoSize = true;
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
            this.rbtnCalzado.TabStop = true;
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
            this.rbtnBisuteria.TabStop = true;
            this.rbtnBisuteria.Text = "Bisuteria";
            this.rbtnBisuteria.UseVisualStyleBackColor = true;
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(106, 279);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(161, 23);
            this.textBox4.TabIndex = 1;
            // 
            // FrmAgregarProdN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.rbtnBisuteria);
            this.Controls.Add(this.rbtnCalzado);
            this.Controls.Add(this.rbtnVestimenta);
            this.Controls.Add(this.gbVestimenta);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAgregarProdN";
            this.Text = "FrmAgregarProdN";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.gbVestimenta.ResumeLayout(false);
            this.gbVestimenta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbVestimenta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbtnVestimenta;
        private System.Windows.Forms.RadioButton rbtnCalzado;
        private System.Windows.Forms.RadioButton rbtnBisuteria;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
    }
}