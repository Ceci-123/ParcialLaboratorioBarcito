namespace UI
{
    partial class Form_Ticket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ticket));
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.text_Box = new System.Windows.Forms.RichTextBox();
            this.lbl_estacionamiento = new System.Windows.Forms.Label();
            this.radioBtn_efectivo = new System.Windows.Forms.RadioButton();
            this.lbl_medioPago = new System.Windows.Forms.Label();
            this.radioBtn_TarjetaCredito = new System.Windows.Forms.RadioButton();
            this.radioBtn_TarjetaDebito = new System.Windows.Forms.RadioButton();
            this.lbl_TotalACobrar = new System.Windows.Forms.Label();
            this.lbl_TotalPesos = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_imprimirTicket = new System.Windows.Forms.Button();
            this.radioBtn_MercadoPago = new System.Windows.Forms.RadioButton();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_puestoVenta = new System.Windows.Forms.Label();
            this.chk_descuento = new System.Windows.Forms.CheckBox();
            this.lbl_descuento = new System.Windows.Forms.Label();
            this.chk_Estacionamiento = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.Location = new System.Drawing.Point(326, 28);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(104, 31);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Ticket";
            // 
            // text_Box
            // 
            this.text_Box.Location = new System.Drawing.Point(37, 95);
            this.text_Box.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.text_Box.Name = "text_Box";
            this.text_Box.Size = new System.Drawing.Size(393, 280);
            this.text_Box.TabIndex = 1;
            this.text_Box.Text = "";
            // 
            // lbl_estacionamiento
            // 
            this.lbl_estacionamiento.AutoSize = true;
            this.lbl_estacionamiento.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_estacionamiento.Location = new System.Drawing.Point(460, 98);
            this.lbl_estacionamiento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_estacionamiento.Name = "lbl_estacionamiento";
            this.lbl_estacionamiento.Size = new System.Drawing.Size(145, 19);
            this.lbl_estacionamiento.TabIndex = 2;
            this.lbl_estacionamiento.Text = "Estacionamiento";
            // 
            // radioBtn_efectivo
            // 
            this.radioBtn_efectivo.AutoSize = true;
            this.radioBtn_efectivo.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtn_efectivo.Location = new System.Drawing.Point(641, 139);
            this.radioBtn_efectivo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radioBtn_efectivo.Name = "radioBtn_efectivo";
            this.radioBtn_efectivo.Size = new System.Drawing.Size(94, 23);
            this.radioBtn_efectivo.TabIndex = 4;
            this.radioBtn_efectivo.TabStop = true;
            this.radioBtn_efectivo.Text = "Efectivo";
            this.radioBtn_efectivo.UseVisualStyleBackColor = true;
            // 
            // lbl_medioPago
            // 
            this.lbl_medioPago.AutoSize = true;
            this.lbl_medioPago.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_medioPago.Location = new System.Drawing.Point(460, 139);
            this.lbl_medioPago.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_medioPago.Name = "lbl_medioPago";
            this.lbl_medioPago.Size = new System.Drawing.Size(122, 19);
            this.lbl_medioPago.TabIndex = 5;
            this.lbl_medioPago.Text = "Medio de pago";
            // 
            // radioBtn_TarjetaCredito
            // 
            this.radioBtn_TarjetaCredito.AutoSize = true;
            this.radioBtn_TarjetaCredito.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtn_TarjetaCredito.Location = new System.Drawing.Point(641, 179);
            this.radioBtn_TarjetaCredito.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radioBtn_TarjetaCredito.Name = "radioBtn_TarjetaCredito";
            this.radioBtn_TarjetaCredito.Size = new System.Drawing.Size(174, 23);
            this.radioBtn_TarjetaCredito.TabIndex = 6;
            this.radioBtn_TarjetaCredito.TabStop = true;
            this.radioBtn_TarjetaCredito.Text = "Tarjeta de Credito";
            this.radioBtn_TarjetaCredito.UseVisualStyleBackColor = true;
            // 
            // radioBtn_TarjetaDebito
            // 
            this.radioBtn_TarjetaDebito.AutoSize = true;
            this.radioBtn_TarjetaDebito.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtn_TarjetaDebito.Location = new System.Drawing.Point(641, 221);
            this.radioBtn_TarjetaDebito.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radioBtn_TarjetaDebito.Name = "radioBtn_TarjetaDebito";
            this.radioBtn_TarjetaDebito.Size = new System.Drawing.Size(163, 23);
            this.radioBtn_TarjetaDebito.TabIndex = 7;
            this.radioBtn_TarjetaDebito.TabStop = true;
            this.radioBtn_TarjetaDebito.Text = "Tarjeta de debito";
            this.radioBtn_TarjetaDebito.UseVisualStyleBackColor = true;
            // 
            // lbl_TotalACobrar
            // 
            this.lbl_TotalACobrar.AutoSize = true;
            this.lbl_TotalACobrar.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TotalACobrar.Location = new System.Drawing.Point(124, 419);
            this.lbl_TotalACobrar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_TotalACobrar.Name = "lbl_TotalACobrar";
            this.lbl_TotalACobrar.Size = new System.Drawing.Size(185, 27);
            this.lbl_TotalACobrar.TabIndex = 8;
            this.lbl_TotalACobrar.Text = "Total a cobrar";
            // 
            // lbl_TotalPesos
            // 
            this.lbl_TotalPesos.AutoSize = true;
            this.lbl_TotalPesos.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TotalPesos.Location = new System.Drawing.Point(70, 468);
            this.lbl_TotalPesos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_TotalPesos.Name = "lbl_TotalPesos";
            this.lbl_TotalPesos.Size = new System.Drawing.Size(333, 27);
            this.lbl_TotalPesos.TabIndex = 9;
            this.lbl_TotalPesos.Text = "Presiona OK para calcular";
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.Color.Plum;
            this.btn_OK.Location = new System.Drawing.Point(506, 372);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(118, 109);
            this.btn_OK.TabIndex = 10;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_imprimirTicket
            // 
            this.btn_imprimirTicket.BackColor = System.Drawing.Color.Plum;
            this.btn_imprimirTicket.Location = new System.Drawing.Point(682, 372);
            this.btn_imprimirTicket.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_imprimirTicket.Name = "btn_imprimirTicket";
            this.btn_imprimirTicket.Size = new System.Drawing.Size(118, 109);
            this.btn_imprimirTicket.TabIndex = 11;
            this.btn_imprimirTicket.Text = "Imprimir ticket";
            this.btn_imprimirTicket.UseVisualStyleBackColor = false;
            this.btn_imprimirTicket.Click += new System.EventHandler(this.btn_imprimirTicket_Click);
            // 
            // radioBtn_MercadoPago
            // 
            this.radioBtn_MercadoPago.AutoSize = true;
            this.radioBtn_MercadoPago.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtn_MercadoPago.Location = new System.Drawing.Point(641, 265);
            this.radioBtn_MercadoPago.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radioBtn_MercadoPago.Name = "radioBtn_MercadoPago";
            this.radioBtn_MercadoPago.Size = new System.Drawing.Size(138, 23);
            this.radioBtn_MercadoPago.TabIndex = 12;
            this.radioBtn_MercadoPago.TabStop = true;
            this.radioBtn_MercadoPago.Text = "Mercado Pago";
            this.radioBtn_MercadoPago.UseVisualStyleBackColor = true;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(37, 38);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(56, 19);
            this.lbl_fecha.TabIndex = 13;
            this.lbl_fecha.Text = "Fecha";
            // 
            // lbl_puestoVenta
            // 
            this.lbl_puestoVenta.AutoSize = true;
            this.lbl_puestoVenta.Location = new System.Drawing.Point(460, 38);
            this.lbl_puestoVenta.Name = "lbl_puestoVenta";
            this.lbl_puestoVenta.Size = new System.Drawing.Size(138, 19);
            this.lbl_puestoVenta.TabIndex = 14;
            this.lbl_puestoVenta.Text = "Puesto de Venta";
            // 
            // chk_descuento
            // 
            this.chk_descuento.AutoSize = true;
            this.chk_descuento.Location = new System.Drawing.Point(641, 313);
            this.chk_descuento.Name = "chk_descuento";
            this.chk_descuento.Size = new System.Drawing.Size(15, 14);
            this.chk_descuento.TabIndex = 15;
            this.chk_descuento.UseVisualStyleBackColor = true;
            // 
            // lbl_descuento
            // 
            this.lbl_descuento.AutoSize = true;
            this.lbl_descuento.Location = new System.Drawing.Point(460, 310);
            this.lbl_descuento.Name = "lbl_descuento";
            this.lbl_descuento.Size = new System.Drawing.Size(150, 19);
            this.lbl_descuento.TabIndex = 16;
            this.lbl_descuento.Text = "Aplica Descuento";
            // 
            // chk_Estacionamiento
            // 
            this.chk_Estacionamiento.AutoSize = true;
            this.chk_Estacionamiento.Location = new System.Drawing.Point(641, 94);
            this.chk_Estacionamiento.Name = "chk_Estacionamiento";
            this.chk_Estacionamiento.Size = new System.Drawing.Size(202, 23);
            this.chk_Estacionamiento.TabIndex = 17;
            this.chk_Estacionamiento.Text = "uso estacionamiento?";
            this.chk_Estacionamiento.UseVisualStyleBackColor = true;
            // 
            // Form_Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(848, 570);
            this.Controls.Add(this.chk_Estacionamiento);
            this.Controls.Add(this.lbl_descuento);
            this.Controls.Add(this.chk_descuento);
            this.Controls.Add(this.lbl_puestoVenta);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.radioBtn_MercadoPago);
            this.Controls.Add(this.btn_imprimirTicket);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.lbl_TotalPesos);
            this.Controls.Add(this.lbl_TotalACobrar);
            this.Controls.Add(this.radioBtn_TarjetaDebito);
            this.Controls.Add(this.radioBtn_TarjetaCredito);
            this.Controls.Add(this.lbl_medioPago);
            this.Controls.Add(this.radioBtn_efectivo);
            this.Controls.Add(this.lbl_estacionamiento);
            this.Controls.Add(this.text_Box);
            this.Controls.Add(this.lbl_titulo);
            this.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Ticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket cliente";
            this.Load += new System.EventHandler(this.Form_Ticket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.RichTextBox text_Box;
        private System.Windows.Forms.Label lbl_estacionamiento;
        private System.Windows.Forms.RadioButton radioBtn_efectivo;
        private System.Windows.Forms.Label lbl_medioPago;
        private System.Windows.Forms.RadioButton radioBtn_TarjetaCredito;
        private System.Windows.Forms.RadioButton radioBtn_TarjetaDebito;
        private System.Windows.Forms.Label lbl_TotalACobrar;
        private System.Windows.Forms.Label lbl_TotalPesos;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_imprimirTicket;
        private System.Windows.Forms.RadioButton radioBtn_MercadoPago;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_puestoVenta;
        private System.Windows.Forms.CheckBox chk_descuento;
        private System.Windows.Forms.Label lbl_descuento;
        private System.Windows.Forms.CheckBox chk_Estacionamiento;
    }
}