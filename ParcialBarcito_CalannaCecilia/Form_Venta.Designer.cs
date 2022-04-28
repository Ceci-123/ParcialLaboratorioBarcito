namespace UI
{
    partial class Form_Venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Venta));
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_AgregarProductos = new System.Windows.Forms.Button();
            this.btn_cerrarMesa = new System.Windows.Forms.Button();
            this.num_cantidad = new System.Windows.Forms.NumericUpDown();
            this.cmbBx_producto = new System.Windows.Forms.ComboBox();
            this.lbl_producto = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.Location = new System.Drawing.Point(191, 22);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(80, 31);
            this.lbl_titulo.TabIndex = 5;
            this.lbl_titulo.Text = "Mesa";
            // 
            // btn_AgregarProductos
            // 
            this.btn_AgregarProductos.Location = new System.Drawing.Point(26, 167);
            this.btn_AgregarProductos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_AgregarProductos.Name = "btn_AgregarProductos";
            this.btn_AgregarProductos.Size = new System.Drawing.Size(289, 185);
            this.btn_AgregarProductos.TabIndex = 3;
            this.btn_AgregarProductos.Text = "Agregar productos";
            this.btn_AgregarProductos.UseVisualStyleBackColor = true;
            this.btn_AgregarProductos.Click += new System.EventHandler(this.btn_AgregarProductos_Click);
            // 
            // btn_cerrarMesa
            // 
            this.btn_cerrarMesa.Location = new System.Drawing.Point(347, 167);
            this.btn_cerrarMesa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_cerrarMesa.Name = "btn_cerrarMesa";
            this.btn_cerrarMesa.Size = new System.Drawing.Size(289, 185);
            this.btn_cerrarMesa.TabIndex = 4;
            this.btn_cerrarMesa.Text = "Cerrar la mesa";
            this.btn_cerrarMesa.UseVisualStyleBackColor = true;
            this.btn_cerrarMesa.Click += new System.EventHandler(this.btn_cerrarMesa_Click);
            // 
            // num_cantidad
            // 
            this.num_cantidad.Location = new System.Drawing.Point(353, 123);
            this.num_cantidad.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.num_cantidad.Name = "num_cantidad";
            this.num_cantidad.Size = new System.Drawing.Size(108, 26);
            this.num_cantidad.TabIndex = 2;
            // 
            // cmbBx_producto
            // 
            this.cmbBx_producto.FormattingEnabled = true;
            this.cmbBx_producto.Location = new System.Drawing.Point(26, 123);
            this.cmbBx_producto.Name = "cmbBx_producto";
            this.cmbBx_producto.Size = new System.Drawing.Size(263, 27);
            this.cmbBx_producto.TabIndex = 1;
            // 
            // lbl_producto
            // 
            this.lbl_producto.AutoSize = true;
            this.lbl_producto.Location = new System.Drawing.Point(26, 89);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(89, 19);
            this.lbl_producto.TabIndex = 6;
            this.lbl_producto.Text = "Producto ";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Location = new System.Drawing.Point(353, 89);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(83, 19);
            this.lbl_cantidad.TabIndex = 7;
            this.lbl_cantidad.Text = "Cantidad";
            // 
            // Form_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(680, 381);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.lbl_producto);
            this.Controls.Add(this.cmbBx_producto);
            this.Controls.Add(this.num_cantidad);
            this.Controls.Add(this.btn_cerrarMesa);
            this.Controls.Add(this.btn_AgregarProductos);
            this.Controls.Add(this.lbl_titulo);
            this.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta en Mesa";
            ((System.ComponentModel.ISupportInitialize)(this.num_cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_AgregarProductos;
        private System.Windows.Forms.Button btn_cerrarMesa;
        private System.Windows.Forms.NumericUpDown num_cantidad;
        private System.Windows.Forms.ComboBox cmbBx_producto;
        private System.Windows.Forms.Label lbl_producto;
        private System.Windows.Forms.Label lbl_cantidad;
    }
}